
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;



namespace Login
{
    public partial class FormLogin : Form
    {

        private string login;
        private string password;
        string assemblyLocation;
        public FormLogin(string login,string password)
        {
            InitializeComponent();
            this.login = login;
            this.password = password;
            this.FormBorderStyle = FormBorderStyle.None;
            this.CenterToScreen();
            this.TopMost = true;
            assemblyLocation = Application.StartupPath;
            lblInvalid.Visible = false;
            this.ShowDialog();
            
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            LoginResult.Result = LoginResult.LoginResultEnum.wrong;
            this.Close();
        }


        private void btLogin_Click(object sender, EventArgs e)
        {
            if(txtLogin.Txt == login && txtPassword.Txt ==password)
            {
                LoginResult.Result = LoginResult.LoginResultEnum.correct;
                this.Close();
            }
            else
            {
                LoginResult.Result = LoginResult.LoginResultEnum.wrong;
                lblInvalid.Visible = true;
            }
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int IParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
 

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.btLogin.Select();
        }

    }
}
