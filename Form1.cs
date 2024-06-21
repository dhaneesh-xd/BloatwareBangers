using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloatwareBangers
{
    internal partial class BBmainForm : Form
    {
        private Operations operations;

        public BBmainForm()
        {
            InitializeComponent();
            this.operations = new Operations();
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
        }
        private void BBmainForm_Load(object sender, EventArgs e)
        {
            
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTabPage = tabControl.SelectedTab;
            if (selectedTabPage == disableApp)
            {
                for (int i = 0; i < checkedListBoxAppsUninstall.Items.Count; i++)
                {
                    checkedListBoxAppsUninstall.SetItemChecked(i, false);
                }
            }
            else if (selectedTabPage == uninstallApp)
            {
                for (int i = 0; i < checkedListBoxAppsDisable.Items.Count; i++)
                {
                    checkedListBoxAppsDisable.SetItemChecked(i, false);
                }
            }
        }
        private void scanButton_Click(object sender, EventArgs e)
        {
            (string deviceName, List<string> appLists) = operations.GetSystemApps();
            deviceNameShow.Text = deviceName;
            checkedListBoxAppsUninstall.Items.Clear();
            foreach (string appInfo in appLists)
            {
                checkedListBoxAppsUninstall.Items.Add(appInfo);
                checkedListBoxAppsDisable.Items.Add(appInfo);
            }
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            TabPage selectedTabPage = tabControl.SelectedTab;
            List<string> appsSelected = new List<string>();
            if (selectedTabPage == uninstallApp)
            {
                foreach (string item in checkedListBoxAppsUninstall.Items)
                {
                    appsSelected.Add(item);
                }
                (string outputComments, string outputPackageName) = operations.DeleteApps(appsSelected);
                outputBox.Text = outputComments + Environment.NewLine + outputPackageName;
            }
            if (selectedTabPage == disableApp)
            {
                foreach (string item in checkedListBoxAppsDisable.Items)
                {
                    appsSelected.Add(item);
                }
                (string outputComments, string outputPackageName) = operations.DisableApps(appsSelected);
                outputBox.Text = outputComments + Environment.NewLine + outputPackageName;
            }
        }
    }
}
