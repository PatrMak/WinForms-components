namespace MsgBox
{
    partial class FormMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMsgBoxType = new System.Windows.Forms.Label();
            this.btExit = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlPicBox = new System.Windows.Forms.Panel();
            this.lblMsgBoxText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.pnlPicBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMsgBoxType
            // 
            this.lblMsgBoxType.AutoSize = true;
            this.lblMsgBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMsgBoxType.Location = new System.Drawing.Point(10, 12);
            this.lblMsgBoxType.Name = "lblMsgBoxType";
            this.lblMsgBoxType.Size = new System.Drawing.Size(52, 20);
            this.lblMsgBoxType.TabIndex = 11;
            this.lblMsgBoxType.Text = "Home";
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.ForeColor = System.Drawing.Color.Black;
            this.btExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btExit.IconColor = System.Drawing.Color.White;
            this.btExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btExit.IconSize = 50;
            this.btExit.Location = new System.Drawing.Point(640, 2);
            this.btExit.Margin = new System.Windows.Forms.Padding(0);
            this.btExit.Name = "btExit";
            this.btExit.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btExit.Size = new System.Drawing.Size(58, 43);
            this.btExit.TabIndex = 9;
            this.btExit.TabStop = false;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(170)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.lblMsgBoxType);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 45);
            this.panel1.TabIndex = 15;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // picBox
            // 
            this.picBox.ImageLocation = "";
            this.picBox.Location = new System.Drawing.Point(30, 31);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(100, 100);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 17;
            this.picBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(170)))), ((int)(((byte)(171)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(698, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 166);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(170)))), ((int)(((byte)(171)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 166);
            this.panel4.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(170)))), ((int)(((byte)(171)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(2, 209);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(696, 2);
            this.panel5.TabIndex = 22;
            // 
            // pnlPicBox
            // 
            this.pnlPicBox.Controls.Add(this.picBox);
            this.pnlPicBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPicBox.Location = new System.Drawing.Point(2, 45);
            this.pnlPicBox.Name = "pnlPicBox";
            this.pnlPicBox.Size = new System.Drawing.Size(139, 164);
            this.pnlPicBox.TabIndex = 23;
            // 
            // lblMsgBoxText
            // 
            this.lblMsgBoxText.AutoSize = true;
            this.lblMsgBoxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMsgBoxText.Location = new System.Drawing.Point(370, 100);
            this.lblMsgBoxText.Name = "lblMsgBoxText";
            this.lblMsgBoxText.Size = new System.Drawing.Size(0, 31);
            this.lblMsgBoxText.TabIndex = 18;
            this.lblMsgBoxText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(700, 211);
            this.Controls.Add(this.lblMsgBoxText);
            this.Controls.Add(this.pnlPicBox);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormMessageBox";
            this.Text = "MessageBox";
            this.Load += new System.EventHandler(this.FormMessageBox_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.pnlPicBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblMsgBoxType;
        internal FontAwesome.Sharp.IconButton btExit;
        private System.Windows.Forms.Panel panel1;
        internal FontAwesome.Sharp.IconButton MsgButtonOK;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlPicBox;
        private System.Windows.Forms.Label lblMsgBoxText;
    }
}