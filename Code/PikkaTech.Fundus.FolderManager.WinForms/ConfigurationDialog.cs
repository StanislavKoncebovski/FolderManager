using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PikkaTech.Fundus.FolderManager.WinForms
{
    public partial class ConfigurationDialog : Form
    {
        public ConfigurationDialog()
        {
            InitializeComponent();
        }

        private void OnOk(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnCancel(object sender, EventArgs e)
        {

        }

        public Configuration Configuration
        {
            get
            {
                if (this._pgConfiguration.SelectedObject is Configuration configuration)
                {
                    return configuration;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                this._pgConfiguration.SelectedObject = value;
            }
        }
    }
}
