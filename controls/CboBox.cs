using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Xml;
using System.Drawing.Design;

namespace Controls
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public class CboBox:UserControl
    {

        private Color backColor = Color.FromArgb(223, 221, 221);
        private Color iconColor = Color.DeepSkyBlue;
        private Color listBackColor = Color.FromArgb(223, 221, 221); //230, 228, 245
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.DeepSkyBlue;
        private ComboBoxStyle dropDownStyle = ComboBoxStyle.DropDownList;
        private int borderSize = 2;

        private ComboBox cboList;
        private Label lblTxt;
        private Button btIcon;


        public event EventHandler OnSelectedIndexChanged;


        #region Constructor
        public CboBox()
        {
            cboList = new ComboBox();
            lblTxt = new Label();
            btIcon = new Button();
            this.SuspendLayout();
            //ComboBox: Dropdown list
            cboList.BackColor = listBackColor;
            cboList.Font = new Font(this.Font.Name, 10F);
            cboList.ForeColor = listTextColor;
            cboList.DropDownStyle = dropDownStyle;
            cboList.SelectedIndexChanged += new EventHandler(CboBox_SelectedIndexChanged);//Default event
            cboList.TextChanged += new EventHandler(CboBox_TextChanged);//Refresh text
            //Button: Icon
            btIcon.Dock = DockStyle.Right;
            btIcon.FlatStyle = FlatStyle.Flat;
            btIcon.FlatAppearance.BorderSize = 0;
            btIcon.BackColor = backColor;
            btIcon.Size = new Size(30, 30);
            btIcon.Cursor = Cursors.Hand;
            btIcon.Click += new EventHandler(btIcon_Click);//Open dropdown list
            btIcon.Paint += new PaintEventHandler(btIcon_Paint);//Draw icon
            //Label: Text
            lblTxt.Dock = DockStyle.Fill;
            lblTxt.AutoSize = false;
            lblTxt.BackColor = backColor;
            lblTxt.TextAlign = ContentAlignment.MiddleLeft;
            lblTxt.Padding = new Padding(8, 0, 0, 0);
            lblTxt.Font = new Font(this.Font.Name, 10F);
            //->Attach label events to user control event
            lblTxt.Click += new EventHandler(CboBox_Click);//Select combo box
            lblTxt.MouseEnter += new EventHandler(CboBox_MouseEnter);
            lblTxt.MouseLeave += new EventHandler(CboBox_MouseLeave);
            //User Control
            this.Controls.Add(lblTxt);//2
            this.Controls.Add(btIcon);//1
            this.Controls.Add(cboList);//0
            this.MinimumSize = new Size(100, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);//Border Size
            this.Font = new Font(this.Font.Name, 10F);
            base.BackColor = borderColor; //Border Color
            this.ResumeLayout();
            AdjustCboBoxDimensions();

      
        }

        #endregion


        #region Properties

        [Category("CustomProperties")]
        public new Color BackColor
        {
            get
            {
              return  backColor;
            }
            set
            {
                backColor = value;
                lblTxt.BackColor = backColor;
                btIcon.BackColor = backColor;
            }
        }

        [Category("CustomProperties")]
        public Color IconColor
        {
            get
            {
                return iconColor;
            }
            set
            {
                iconColor = value;
                btIcon.Invalidate();
            }
        }

        [Category("CustomProperties")]
        public Color ListBackColor 
        {
            get
            {
                return listBackColor;
            }
            set
            {
                listBackColor = value;
                cboList.BackColor = listBackColor;
            }
        }

        [Category("CustomProperties")]
        public Color ListTextColor
        {
            get
            {
                return listTextColor;
            }
            set
            {
                listTextColor = value;
                cboList.ForeColor = listTextColor;
            }
        }

        [Category("CustomProperties")]
        public Color BorderColor 
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                base.BackColor = borderColor;
            }
        }

        [Category("CustomProperties")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);
                AdjustCboBoxDimensions();
            }
        }

        [Category("CustomProperties")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                lblTxt.ForeColor = value;
            }
        }

        [Category("CustomProperties")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                lblTxt.Font = value;
                cboList.Font = value;//Optional
            }
        }

        [Category("CustomProperties")]
        public string Txt
        {
            get 
            { 
                return lblTxt.Text;
            }
            set
            { 
                lblTxt.Text = value;
            }
        }

        [Category("CustomProperties")]
        public ComboBoxStyle DropDownStyle
        {
            get 
            {
                return cboList.DropDownStyle;
            }
            set
            {
                if (cboList.DropDownStyle != ComboBoxStyle.Simple)
                    cboList.DropDownStyle = value;
            }
        }



        [Category("CustomProperties")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get { return cboList.Items; }
        }

        [Category("CustomProperties")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get
            {
                return cboList.DataSource; 
            }
            set
            {
                cboList.DataSource = value;
            }
        }

        [Category("CustomProperties")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get
            {
                return cboList.AutoCompleteCustomSource; 
            }
            set 
            {
                cboList.AutoCompleteCustomSource = value;
            }
        }

        [Category("CustomProperties")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get 
            {
                return cboList.AutoCompleteSource;
            }
            set
            { 
                cboList.AutoCompleteSource = value;
            }
        }

        [Category("CustomProperties")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get 
            {
                return cboList.AutoCompleteMode;
            }
            set
            {
                cboList.AutoCompleteMode = value;
            }
        }

        [Category("CustomProperties")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get
            {
                return
                    cboList.SelectedItem;
            }
            set
            { 
                cboList.SelectedItem = value;
            }
        }

        [Category("CustomProperties")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get 
            { 
                return cboList.SelectedIndex;
            }
            set
            {
                cboList.SelectedIndex = value;
            }
        }

        [Category("CustomProperties")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string DisplayMember
        {
            get
            {
                return cboList.DisplayMember;
            }
            set 
            { 
                cboList.DisplayMember = value;
            }
        }

        [Category("CustomProperties")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ValueMember
        {
            get 
            {
                return cboList.ValueMember;
            }
            set 
            { 
                cboList.ValueMember = value;
            }
        }
        #endregion

        #region Events
        private void CboBox_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void CboBox_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void CboBox_Click(object sender, EventArgs e)
        {
            //Attach label click to user control click
            this.OnClick(e);
            //Select combo box
            cboList.Select();
            if (cboList.DropDownStyle == ComboBoxStyle.DropDownList)
                cboList.DroppedDown = true;//Open dropdown list
        }

        private void btIcon_Paint(object sender, PaintEventArgs e)
        {
            //Fields
            int iconWidht = 14;
            int iconHeight = 6;
            var recttangleIcon = new Rectangle((btIcon.Width - iconWidht) / 2, (btIcon.Height - iconHeight) / 2, iconWidht, iconHeight);
            Graphics graph = e.Graphics;
            //Draw arrow down icon
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(recttangleIcon.X, recttangleIcon.Y, recttangleIcon.X + (iconWidht / 2), recttangleIcon.Bottom);
                path.AddLine(recttangleIcon.X + (iconWidht / 2), recttangleIcon.Bottom, recttangleIcon.Right, recttangleIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        private void btIcon_Click(object sender, EventArgs e)
        {
            cboList.Select();
            cboList.DroppedDown = true;
        }

        private void CboBox_TextChanged(object sender, EventArgs e)
        {
            //Refresh text
            lblTxt.Text = cboList.Text;
        }

        private void CboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            //Refresh text
            lblTxt.Text = cboList.Text;
        }

        #endregion

        #region Methods
        private void AdjustCboBoxDimensions()
        {
            cboList.Width = lblTxt.Width;
            cboList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cboList.Width,
                Y = lblTxt.Bottom - cboList.Height
            };
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustCboBoxDimensions();
        }
        #endregion
    }
}
