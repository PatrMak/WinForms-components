using MsbBoxType;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;




namespace MsgBox
{
    public partial class FormMessageBox : Form
    {
        string assemblyLocation;
        public FormMessageBox(MsgBoxType msgBoxType, MsgBoxButton msgBoxButton, string msgBoxText)
        {
            InitializeComponent();


            this.FormBorderStyle = FormBorderStyle.None;
            this.CenterToScreen();

            assemblyLocation = Application.StartupPath;


            this.picBox.Top = (this.pnlPicBox.Height - this.picBox.Height) / 2;
            this.picBox.Left = (this.pnlPicBox.Width - this.picBox.Width) / 2;

            CallButton(msgBoxType, msgBoxButton);
            CallLabelText(msgBoxText);

            this.ShowDialog();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            MsgBoxResult.msgBoxResult = MsgBoxResultEnum.Exit;
            this.Close();
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

        private void FormMessageBox_Load(object sender, EventArgs e)
        {

        }


        public void CallButton(MsgBoxType msgBoxType, MsgBoxButton msgBoxButton)
        {
            switch(msgBoxType)
            {
                case MsgBoxType.Warning:
                    CallMsgBoxTypeWarning();
                    break;
                case MsgBoxType.Information:
                    CallMsgBoxTypeInformation();
                    break;
                case MsgBoxType.Error:
                    CallMsgBoxTypeError();
                    break;
            }

            switch (msgBoxButton)
            {
                case MsgBoxButton.MsgBoxButtonOK:
                    Point pointOK = new Point(260, 156);
                    CreateButtonOK(pointOK);
                    break;
                case MsgBoxButton.MsgBoxButtonOKCancel:
                    Point pointOK2 = new Point(356, 156);
                    Point pointCancel2 = new Point(170, 156);
                    CreateButtonOK(pointOK2);
                    CreateButtonCancel(pointCancel2);
                    break;
                case MsgBoxButton.MsgBoxButtonUpdateCancel:
                    Point pointCancel = new Point(356, 156);
                    Point pointUpdate = new Point(170, 156);
                    CreateButtonUpdate(pointUpdate);
                    CreateButtonCancel(pointCancel);
                    break;
                case MsgBoxButton.MsgBoxButtonUpdateRegisterCancel:
                    Point pointUpdate1 = new Point(74, 156);
                    Point pointRegister = new Point(260, 156);
                    Point pointCancel1 = new Point(446, 156);
                    CreateButtonUpdate(pointUpdate1);
                    CreateButtonRegister(pointRegister);
                    CreateButtonCancel(pointCancel1);
                    break;
            }
        }


        private void MsgButtonOK_Click(object sender, EventArgs e)
        {
            MsgBoxResult.msgBoxResult = MsgBoxResultEnum.OK;
            this.Close();
        }

        private void MsgButtonCancel_Click(object sender, EventArgs e)
        {
            MsgBoxResult.msgBoxResult = MsgBoxResultEnum.Cancel;
            this.Close();
        }

        private void MsgButtonUpdate_Click(object sender, EventArgs e)
        {
            MsgBoxResult.msgBoxResult = MsgBoxResultEnum.Update;
            this.Close();
        }

        private void MsgButtonRegister_Click(object sender, EventArgs e)
        {
            MsgBoxResult.msgBoxResult = MsgBoxResultEnum.Register;
            this.Close();
        }


        private void CallMsgBoxTypeWarning()
        {
         
            lblMsgBoxType.Text = "Warning";
            picBox.ImageLocation = assemblyLocation+"\\Resource\\Warning.png";
      
        }

        private void CallMsgBoxTypeInformation()
        {
            lblMsgBoxType.Text = "Information";
            picBox.ImageLocation = assemblyLocation+"\\Resource\\Aproved.png";
        }


        private void CallMsgBoxTypeError()
        {
            lblMsgBoxType.Text = "Error";
            picBox.ImageLocation = assemblyLocation + "\\Resource\\Error.png";
        }

        private void CreateButtonOK(Point buttonLocation)
        {
            FontAwesome.Sharp.IconButton MsgButtonOK = new FontAwesome.Sharp.IconButton();
            MsgButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(170)))), ((int)(((byte)(171)))));
            MsgButtonOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            MsgButtonOK.FlatAppearance.BorderSize = 0;
            MsgButtonOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            MsgButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MsgButtonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            MsgButtonOK.ForeColor = System.Drawing.Color.Black;
            MsgButtonOK.IconChar = FontAwesome.Sharp.IconChar.None;
            MsgButtonOK.IconColor = System.Drawing.Color.Black;
            MsgButtonOK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MsgButtonOK.IconSize = 35;
            MsgButtonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MsgButtonOK.Location = buttonLocation; // new System.Drawing.Point(260, 158);
            MsgButtonOK.Name = "MsgButtonOK";
            MsgButtonOK.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            MsgButtonOK.Size = new System.Drawing.Size(180, 50);
            MsgButtonOK.TabIndex = 16;
            MsgButtonOK.Text = "OK";
            MsgButtonOK.UseVisualStyleBackColor = false;
            MsgButtonOK.Visible = true;
            MsgButtonOK.Click += new System.EventHandler(MsgButtonOK_Click);
            this.Controls.Add(MsgButtonOK);
        }

        private void CreateButtonCancel(Point buttonLocation)
        {
            FontAwesome.Sharp.IconButton MsgButtonCancel= new FontAwesome.Sharp.IconButton();
            MsgButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(170)))), ((int)(((byte)(171)))));
            MsgButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            MsgButtonCancel.FlatAppearance.BorderSize = 0;
            MsgButtonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            MsgButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MsgButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            MsgButtonCancel.ForeColor = System.Drawing.Color.Black;
            MsgButtonCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            MsgButtonCancel.IconColor = System.Drawing.Color.Black;
            MsgButtonCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MsgButtonCancel.IconSize = 35;
            MsgButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MsgButtonCancel.Location = buttonLocation;// new System.Drawing.Point(356, 158);
            MsgButtonCancel.Name = "MsgButtonCancel";
            MsgButtonCancel.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            MsgButtonCancel.Size = new System.Drawing.Size(180, 50);
            MsgButtonCancel.TabIndex = 19;
            MsgButtonCancel.Text = "Cancel";
            MsgButtonCancel.UseVisualStyleBackColor = false;
            MsgButtonCancel.Visible = true;
            MsgButtonCancel.Click += new System.EventHandler(MsgButtonCancel_Click);
            this.Controls.Add(MsgButtonCancel);
        }



        private void CreateButtonUpdate(Point buttonLocation)
        {
            FontAwesome.Sharp.IconButton MsgButtonUpdate = new FontAwesome.Sharp.IconButton();
            MsgButtonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(170)))), ((int)(((byte)(171)))));
            MsgButtonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            MsgButtonUpdate.FlatAppearance.BorderSize = 0;
            MsgButtonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            MsgButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MsgButtonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            MsgButtonUpdate.ForeColor = System.Drawing.Color.Black;
            MsgButtonUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            MsgButtonUpdate.IconColor = System.Drawing.Color.Black;
            MsgButtonUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MsgButtonUpdate.IconSize = 35;
            MsgButtonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MsgButtonUpdate.Location = buttonLocation;//new System.Drawing.Point(170, 158);
            MsgButtonUpdate.Name = "MsgButtonUpdate";
            MsgButtonUpdate.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            MsgButtonUpdate.Size = new System.Drawing.Size(180, 50);
            MsgButtonUpdate.TabIndex = 20;
            MsgButtonUpdate.Text = "Update";
            MsgButtonUpdate.UseVisualStyleBackColor = false;
            MsgButtonUpdate.Visible = true;
            MsgButtonUpdate.Click += new System.EventHandler(MsgButtonUpdate_Click);
            this.Controls.Add(MsgButtonUpdate);
        }

        private void CreateButtonRegister(Point buttonLocation)
        {
            FontAwesome.Sharp.IconButton MsgButtonRegister = new FontAwesome.Sharp.IconButton();
            MsgButtonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(170)))), ((int)(((byte)(171)))));
            MsgButtonRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            MsgButtonRegister.FlatAppearance.BorderSize = 0;
            MsgButtonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            MsgButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MsgButtonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            MsgButtonRegister.ForeColor = System.Drawing.Color.Black;
            MsgButtonRegister.IconChar = FontAwesome.Sharp.IconChar.None;
            MsgButtonRegister.IconColor = System.Drawing.Color.Black;
            MsgButtonRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MsgButtonRegister.IconSize = 35;
            MsgButtonRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MsgButtonRegister.Location = buttonLocation;//new System.Drawing.Point(170, 158);
            MsgButtonRegister.Name = "MsgButtonRegister";
            MsgButtonRegister.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            MsgButtonRegister.Size = new System.Drawing.Size(180, 50);
            MsgButtonRegister.TabIndex = 20;
            MsgButtonRegister.Text = "Register";
            MsgButtonRegister.UseVisualStyleBackColor = false;
            MsgButtonRegister.Visible = true;
            MsgButtonRegister.Click += new System.EventHandler(MsgButtonRegister_Click);
            this.Controls.Add(MsgButtonRegister);
        }

        private void CallLabelText(string txt)
        {
            lblMsgBoxText.Text = txt;
            lblMsgBoxText.MaximumSize = new Size(this.ClientSize.Width - this.pnlPicBox.Width - 4, 0);

            lblMsgBoxText.Left = (this.ClientSize.Width - lblMsgBoxText.Width) / 2;
            lblMsgBoxText.Left = lblMsgBoxText.Left < this.pnlPicBox.Width ? this.pnlPicBox.Width + 2 : lblMsgBoxText.Left;

            lblMsgBoxText.Top = (this.ClientSize.Height - lblMsgBoxText.Height) / 2;
        }
    }
}
