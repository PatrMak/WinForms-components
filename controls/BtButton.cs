using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FontAwesome.Sharp;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Controls
{
    public class BtButton : IconButton
    {
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color borderColor = Color.DeepSkyBlue;



        #region Constructor
        public BtButton()
            {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.DeepSkyBlue;
            this.ForeColor = Color.White;
            this.Font = new Font(this.Font.FontFamily, 14);
            this.Resize += new EventHandler(Button_Resize);
        }

        #endregion

        #region Properties

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
                this.Invalidate();
            }
        }

        [Category("CustomProperties")]
        public int BorderRadius
        {
            get
            {
               return borderRadius;
            }
            set
            {
                if (value <= this.Height)
                    borderRadius = value;
                else
                    borderRadius = this.Height;

                this.Invalidate();
            }
        }

        [Category("CustomProperties")]
        public Color BorderColor
        {
            get
            {
              return  borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("CustomProperties")]
        public Color BackgroundColor
        {
            get 
            {
                return this.BackColor;
            }
            set 
            { 
                this.BackColor = value;
            }
        }

        [Category("CustomProperties")]
        public Color TextColor
        {
            get 
            {
                return this.ForeColor;
            }
            set
            {
                this.ForeColor = value;
            }
        }
        #endregion


        #region Override
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle rectangleSurface = this.ClientRectangle;
            Rectangle rectangleBorder = Rectangle.Inflate(rectangleSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;
            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectangleSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectangleBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    //Button border                    
                    if (borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectangleSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

 
        #endregion

        #region Methods
        private GraphicsPath GetFigurePath(Rectangle rectangle, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rectangle.X, rectangle.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rectangle.Right - curveSize, rectangle.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rectangle.Right - curveSize, rectangle.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rectangle.X, rectangle.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if(this.DesignMode)
            this.Invalidate();
        }


        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }
        #endregion
    }
}
