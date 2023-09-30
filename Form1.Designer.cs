namespace WinForms_components
{
    partial class Form1
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
            this.txtBox1 = new Controls.TxtBox();
            this.txtBox2 = new Controls.TxtBox();
            this.tgButton1 = new Controls.TgButton();
            this.cboBox1 = new Controls.CboBox();
            this.tgButton2 = new Controls.TgButton();
            this.btButton1 = new Controls.BtButton();
            this.btButton2 = new Controls.BtButton();
            this.SuspendLayout();
            // 
            // txtBox1
            // 
            this.txtBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtBox1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtBox1.BorderFocusColor = System.Drawing.Color.MediumBlue;
            this.txtBox1.BorderRadius = 0;
            this.txtBox1.BorderSize = 2;
            this.txtBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBox1.Location = new System.Drawing.Point(73, 81);
            this.txtBox1.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox1.MaxLength = 32767;
            this.txtBox1.Multiline = false;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBox1.PasswordChar = false;
            this.txtBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBox1.PlaceholderTxt = "";
            this.txtBox1.ReadOnly = false;
            this.txtBox1.Size = new System.Drawing.Size(200, 35);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.TextAligment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox1.Txt = "";
            this.txtBox1.UnderlinedStyle = true;
            // 
            // txtBox2
            // 
            this.txtBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtBox2.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtBox2.BorderFocusColor = System.Drawing.Color.MediumBlue;
            this.txtBox2.BorderRadius = 0;
            this.txtBox2.BorderSize = 2;
            this.txtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBox2.Location = new System.Drawing.Point(73, 167);
            this.txtBox2.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox2.MaxLength = 32767;
            this.txtBox2.Multiline = false;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBox2.PasswordChar = false;
            this.txtBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBox2.PlaceholderTxt = "place holder txt";
            this.txtBox2.ReadOnly = false;
            this.txtBox2.Size = new System.Drawing.Size(200, 35);
            this.txtBox2.TabIndex = 1;
            this.txtBox2.TextAligment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox2.Txt = "";
            this.txtBox2.UnderlinedStyle = true;
            // 
            // tgButton1
            // 
            this.tgButton1.AutoSize = true;
            this.tgButton1.Location = new System.Drawing.Point(364, 94);
            this.tgButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.tgButton1.Name = "tgButton1";
            this.tgButton1.OffBackColor = System.Drawing.Color.Gray;
            this.tgButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgButton1.OnBackColor = System.Drawing.Color.DeepSkyBlue;
            this.tgButton1.OnToggleColor = System.Drawing.Color.MediumBlue;
            this.tgButton1.Size = new System.Drawing.Size(45, 22);
            this.tgButton1.TabIndex = 2;
            this.tgButton1.UseVisualStyleBackColor = true;
            // 
            // cboBox1
            // 
            this.cboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.cboBox1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.cboBox1.BorderSize = 2;
            this.cboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.cboBox1.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.cboBox1.Items.AddRange(new object[] {
            "Option 1",
            "Option 2",
            "Option 3",
            "Option 4"});
            this.cboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.cboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.cboBox1.Location = new System.Drawing.Point(332, 172);
            this.cboBox1.MinimumSize = new System.Drawing.Size(100, 30);
            this.cboBox1.Name = "cboBox1";
            this.cboBox1.Padding = new System.Windows.Forms.Padding(2);
            this.cboBox1.Size = new System.Drawing.Size(200, 30);
            this.cboBox1.TabIndex = 3;
            this.cboBox1.Txt = "Select item:";
            // 
            // tgButton2
            // 
            this.tgButton2.AutoSize = true;
            this.tgButton2.Checked = true;
            this.tgButton2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgButton2.Location = new System.Drawing.Point(466, 93);
            this.tgButton2.MinimumSize = new System.Drawing.Size(45, 22);
            this.tgButton2.Name = "tgButton2";
            this.tgButton2.OffBackColor = System.Drawing.Color.Gray;
            this.tgButton2.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgButton2.OnBackColor = System.Drawing.Color.DeepSkyBlue;
            this.tgButton2.OnToggleColor = System.Drawing.Color.MediumBlue;
            this.tgButton2.Size = new System.Drawing.Size(45, 22);
            this.tgButton2.TabIndex = 4;
            this.tgButton2.UseVisualStyleBackColor = true;
            // 
            // btButton1
            // 
            this.btButton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btButton1.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btButton1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btButton1.BorderRadius = 20;
            this.btButton1.BorderSize = 0;
            this.btButton1.FlatAppearance.BorderSize = 0;
            this.btButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btButton1.ForeColor = System.Drawing.Color.White;
            this.btButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btButton1.IconColor = System.Drawing.Color.Black;
            this.btButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btButton1.Location = new System.Drawing.Point(242, 243);
            this.btButton1.Name = "btButton1";
            this.btButton1.Size = new System.Drawing.Size(150, 40);
            this.btButton1.TabIndex = 5;
            this.btButton1.Text = "Standard";
            this.btButton1.TextColor = System.Drawing.Color.White;
            this.btButton1.UseVisualStyleBackColor = false;
            // 
            // btButton2
            // 
            this.btButton2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btButton2.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btButton2.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btButton2.BorderRadius = 20;
            this.btButton2.BorderSize = 0;
            this.btButton2.FlatAppearance.BorderSize = 0;
            this.btButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btButton2.ForeColor = System.Drawing.Color.White;
            this.btButton2.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btButton2.IconColor = System.Drawing.Color.White;
            this.btButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btButton2.IconSize = 38;
            this.btButton2.Location = new System.Drawing.Point(242, 304);
            this.btButton2.Name = "btButton2";
            this.btButton2.Size = new System.Drawing.Size(150, 40);
            this.btButton2.TabIndex = 6;
            this.btButton2.Text = "Search";
            this.btButton2.TextColor = System.Drawing.Color.White;
            this.btButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btButton2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btButton2);
            this.Controls.Add(this.btButton1);
            this.Controls.Add(this.tgButton2);
            this.Controls.Add(this.cboBox1);
            this.Controls.Add(this.tgButton1);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.TxtBox txtBox1;
        private Controls.TxtBox txtBox2;
        private Controls.TgButton tgButton1;
        private Controls.CboBox cboBox1;
        private Controls.TgButton tgButton2;
        private Controls.BtButton btButton1;
        private Controls.BtButton btButton2;
    }
}

