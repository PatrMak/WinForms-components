using System;
using Login;
using System.Windows.Forms;

namespace WinForms_components
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.tgButton1.Select();
        }


        private void btButton3_Click(object sender, EventArgs e)
        {
            const string login = "Login";
            const string password = "Password";
            _ = new FormLogin(login, password);

        }
    }
}
