using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static byfly_.MainForm;

namespace byfly_
{
    public partial class SettingsForm : Form
    {
        Parser GetBalance = new Parser();

        public SettingsForm(Parser ParserObject)
        {
            InitializeComponent();
            GetBalance = ParserObject;
            loginBox.Text = Properties.Settings.Default.login;
            passBox.Text = Properties.Settings.Default.password;
            payBox.Text = Properties.Settings.Default.pay;
        }

        private void saveButton_Click(object sender , EventArgs e)
        {
            if (loginBox.Text != null && passBox.Text != null && payBox.Text != null)
            {
                Properties.Settings.Default.login = loginBox.Text;
                Properties.Settings.Default.password = passBox.Text;
                Properties.Settings.Default.pay = payBox.Text;
                Properties.Settings.Default.Save();
                GetBalance.GetBalanceStart();
                this.Close();
            }
        }
    }
}
