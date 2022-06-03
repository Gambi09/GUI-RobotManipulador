using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace ControlRobotMnipuldor.Resources.RJControllers.RJButton
{
    class RJButton : Button
    {
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color borderColor = Color.PaleVioletRed;
        private int imageWidht = 60;
        private int imageHeight= 60;
        private Image _AutoScaleImage;
        public Image AutoScaleImage
        {
            get { return _AutoScaleImage; }
            set
            {
                _AutoScaleImage = value;
                if (value != null)
                    this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        [Category("RJ Code Advance")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        [Category("RJ Code Advance")]
        public int ImageWidht { get => imageWidht; set => imageWidht = value; }
        [Category("RJ Code Advance")]
        public int ImageHeight { get => imageHeight; set => imageHeight = value; }
        
        
        public RJButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
            this.Image = Properties.Resources.CD;
        }

        

        
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }


        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void DrawResizeImage(Graphics g) 
        {
            if (_AutoScaleImage == null)
                return;
            int iB = borderRadius;
            int iOff = 0;
            Rectangle rectLoc = default(Rectangle);
            Rectangle rectSrc = default(Rectangle);

            Size sizeDst = new Size(Math.Max(0, this.Width - 2 * iB),
                  Math.Max(0, this.Height - 2 * iB));
            Size sizeSrc = new Size(_AutoScaleImage.Width,
                  _AutoScaleImage.Height);
            double ratioDst = sizeDst.Height / sizeDst.Width;
            double ratioSrc = sizeSrc.Height / sizeSrc.Width;

            rectSrc = new Rectangle(0, 0, sizeSrc.Width, sizeSrc.Height);

            if (ratioDst < ratioSrc)
            {
                iOff = (sizeDst.Width -
                  (sizeDst.Height * sizeSrc.Width / sizeSrc.Height)) / 2;
                rectLoc = new Rectangle(iB + iOff,
                      iB,
                      sizeDst.Height * sizeSrc.Width / sizeSrc.Height,
                      sizeDst.Height);
            }
            else
            {
                iOff = (sizeDst.Height - (sizeDst.Width * sizeSrc.Height / sizeSrc.Width)) / 2;
                rectLoc = new Rectangle(iB,
                      iB + iOff,
                      sizeDst.Width,
                      sizeDst.Width * sizeSrc.Height / sizeSrc.Width);
            }

            g.DrawImage(_AutoScaleImage, rectLoc, rectSrc, GraphicsUnit.Pixel);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;
            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
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
                this.Region = new Region(rectSurface);
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
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

    }
}
