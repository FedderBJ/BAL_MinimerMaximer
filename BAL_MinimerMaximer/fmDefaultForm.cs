using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security;

namespace BAL_MinimerMaximer
{
    public partial class fmDefaultForm : Form
    {
        private Process OSK;

        public fmDefaultForm()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {

            }

            if (keyData == Keys.Escape)
            {
                this.Close();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            if (OSK != null)
            {
                OSK.Kill();
                OSK = null;
                btnKeyboard.Text = "Tastatur";
            }
            else
            {
                OSK = Process.Start(new ProcessStartInfo(
                ((Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\osk.exe"))));
                btnKeyboard.Text = "Luk Tastatur";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeLanguage(string lang)
        {
            var ci = new CultureInfo(lang);
            System.Threading.Thread.CurrentThread.CurrentUICulture = ci;
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(this.GetType());
                resources.ApplyResources(c, c.Name, ci);
                if (c.GetType() == typeof(DataGridView))
                {
                    var dgv = (DataGridView)c;
                    foreach (DataGridViewColumn col in dgv.Columns)
                    {
                        resources.ApplyResources(col, col.Name);
                    }
                }
            }
        }

    }
}
