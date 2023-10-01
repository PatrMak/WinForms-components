using System;
using Login;
using System.Windows.Forms;
using MsgBox;

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

        private void btMsgBox_Click(object sender, EventArgs e)
        {
            _ = new FormMessageBox(MsgBoxType.Information, MsgBoxButton.MsgBoxButtonOKCancel, "Teraz przetestujemy dluzszy tekst czy nie wyjdzie jakis cyrk");
        }
    }
}
