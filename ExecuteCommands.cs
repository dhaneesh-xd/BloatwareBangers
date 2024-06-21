using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloatwareBangers
{
    internal class ExecuteCommands
    {
        internal string ExecuteAdbCommand(string adbCommand)
        {
            string adbPath = $"C:/platform-tools/adb.exe";
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = adbPath,
                Arguments = adbCommand,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process() { StartInfo = startInfo })
            {
                process.StartInfo.FileName = adbPath;
                process.StartInfo.Arguments = adbCommand;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                StringBuilder outputBuilder = new StringBuilder();
                StringBuilder errorBuilder = new StringBuilder();

                process.OutputDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        outputBuilder.AppendLine(e.Data);
                    }
                };

                process.ErrorDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        errorBuilder.AppendLine(e.Data);
                    }
                };
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();
                string output = outputBuilder.ToString().Trim();
                string error = errorBuilder.ToString().Trim();
                return $"{output}{Environment.NewLine}{error}";
            }
        }
    }
}
