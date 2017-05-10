using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace byfly_
{
    public partial class MainForm : Form
    {
        public Parser GetBalance = new Parser();

        public MainForm()
        {
            InitializeComponent();
            GetBalance.balanceLabel = balance;
            GetBalance.payLabel = DaysBeforeShutdown;
            GetBalance.GetBalanceClass = GetBalance;
            this.GetBalance.GetBalanceStart();
        }


        public class Parser
        {

            #region Инициализация
            public Parser GetBalanceClass ;
            public Label balanceLabel;
            public Label payLabel;
            private WebBrowser client;
            private string line = "Актуальный баланс: <b>";
            #endregion

            public void GetBalanceStart()
            {
                if (String.Compare(Properties.Settings.Default.login , "") != 0 && String.Compare(Properties.Settings.Default.password , "") != 0)
                    this.StartParse();
                else
                {
                    SettingsForm settings = new SettingsForm(GetBalanceClass);
                    settings.ShowDialog();
                }
            }

            private void StartParse()
            {
                client = new WebBrowser();
                client.DocumentCompleted += Client_DocumentCompleted;
                string beltelecom = "https://issa.beltelecom.by/main.html";
                string authData = String.Format("redirect=%2Fmain.html&oper_user={0}&passwd={1}" ,
                    Properties.Settings.Default.login , Properties.Settings.Default.password);

                client.Navigate(beltelecom , "_self" ,
                                   System.Text.Encoding.ASCII.GetBytes(authData) ,
                               "Content-Type: application/x-www-form-urlencoded");
            }

            private void Client_DocumentCompleted(object sender , WebBrowserDocumentCompletedEventArgs e)
            {
                ErrorsHandler(client.DocumentText);
            }

            private void ReadData(string data)
            {
                string balance = data.Substring(data.IndexOf(line) + line.Length , 7);
                if (balance.IndexOf(" ") > -1)
                    balance = balance.Substring(0 , balance.IndexOf(" "));
                balanceLabel.Text = String.Format("Актуальный баланс: {0}" , balance );

                if (balance != null)
                    GetDaysBeforeSh(balance);
            }

            private void ErrorsHandler(string data)
            {
                try
                {
                    if (data.IndexOf(line) > -1)
                        this.ReadData(data);
                    else if (data.IndexOf(Properties.Resources.UserNotFound) > -1)
                        throw new Exception(Properties.Resources.MessageLoginError);
                    else if (data.IndexOf(Properties.Resources.MessageAuthorizationAttempts) > -1)
                        throw new Exception(Properties.Resources.MessageAuthorizationAttempts);
                    else
                        throw new Exception(Properties.Resources.UnknowError);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message , "Ошибка");
                }
            }

            private void GetDaysBeforeSh(string balance)
            {
                double qw = Convert.ToDouble(balance.Replace(".", ","));

                if (String.Compare(Properties.Settings.Default.pay , "") == 0)
                    payLabel.Text = "Дней до отключения: #";
                else if (balance.IndexOf("-") > -1)
                    payLabel.Text = "Дней до отключения: 0";
                else if (Properties.Settings.Default.pay != null)
                {
                    double days = Convert.ToDouble(Properties.Settings.Default.pay);
                    days /= 31;
                    days = Convert.ToDouble(balance.Replace("." , ",")) / days;
                    days = (int)days;
                    payLabel.Text = String.Format("Дней до отключения: {0}" , days.ToString());
                }
            }
        }

        private void settingsButton_Click(object sender , EventArgs e)
        {
            SettingsForm settings = new SettingsForm(GetBalance);
            settings.ShowDialog();
        }

        private void pictureBox1_Click(object sender , EventArgs e)
        {
            Process.Start("https://issa.beltelecom.by/main.html");
        }
    }
}
