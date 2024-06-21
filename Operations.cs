using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BloatwareBangers
{
    internal class Operations
    {
        private ExecuteCommands executeCommands;
        public Operations()
        {

            this.executeCommands = new ExecuteCommands();

        }
        internal (string deviceName, List<string> appLists) GetSystemApps()
        {
            List<string> appLists = new List<string>();
            string systemAppsOutput = executeCommands.ExecuteAdbCommand("shell pm list packages -f");
            string name = executeCommands.ExecuteAdbCommand("shell getprop ro.product.device");
            if (!string.IsNullOrEmpty(systemAppsOutput))
            {
                List<string> apkNames = new List<string>();
                string[] lines = systemAppsOutput.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                    string[] lineParts = line.Split('=');
                    string appName2 = lineParts[lineParts.Length - 1].Trim();
                    string packagePath = lineParts[0].Trim();
                    string[] pathParts = packagePath.Split('/');
                    string apkNameWithExtension = pathParts[pathParts.Length - 1]; 
                    if (apkNameWithExtension.EndsWith(".apk", StringComparison.OrdinalIgnoreCase))
                    {
                        string apkName = Regex.Replace(apkNameWithExtension, @"\.apk$", "");
                        apkNames.Add(apkName + " " + " - " + " " + appName2);
                    }
                }
                apkNames.Sort();
                foreach (string apkName in apkNames)
                {
                    appLists.Add(apkName);   
                }
            }
            string deviceName = Regex.Replace(name, @"\r\n?|\n", "");
            return (deviceName, appLists);
        }
        internal (string outoutputPackageNameput, string outputComments) DeleteApps(List<string> appsSelected)
        {
            List<string> selectedApps = new List<string>();
            string outputComments = "";
            string outputPackageName = "";
            foreach (string item in appsSelected)
            {
                string[] tempNameToDelete = item.Split('-');
                string appNameToDelete = tempNameToDelete[tempNameToDelete.Length - 1];
                //string packageName = item.ToString().Trim(); 
                selectedApps.Add(appNameToDelete);
            }
            foreach (string packageName in selectedApps)
            {
                string uninstallCommand = $"shell pm uninstall -k --user 0 {packageName}";
                string commandOutput = executeCommands.ExecuteAdbCommand(uninstallCommand);
                outputPackageName = ($"Uninstalling {packageName}:" + Environment.NewLine);
                outputComments = commandOutput + Environment.NewLine;
            }
            return (outputPackageName, outputComments);
        }
        internal (string outoutputPackageNameput, string outputComments) DisableApps(List<string> appsSelected)
        {
            List<string> selectedApps = new List<string>();
            string outputComments = "";
            string outputPackageName = "";
            foreach (string item in appsSelected)
            {
                string[] tempNameToDelete = item.Split('-');
                string appNameToDelete = tempNameToDelete[tempNameToDelete.Length - 1]; 
                selectedApps.Add(appNameToDelete);
            }
            foreach (string packageName in selectedApps)
            {
                string uninstallCommand = $"shell pm disable -k --user 0 {packageName}";
                string commandOutput = executeCommands.ExecuteAdbCommand(uninstallCommand);
                outputPackageName = ($"Disabling {packageName}:" + Environment.NewLine);
                outputComments = commandOutput + Environment.NewLine;
            }
            return (outputPackageName, outputComments);
        }
    }
}
