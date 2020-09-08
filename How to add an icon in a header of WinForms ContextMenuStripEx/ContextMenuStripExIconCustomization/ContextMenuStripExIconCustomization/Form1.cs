using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuStripExIconCustomization
{
    public partial class Form1 : MetroForm
    {
        
            //Declaration
            private CustomContextMenuStripEx contextMenuStripEx;
            private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
            private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
            private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
            public Form1()
            {
                InitializeComponent();
               this.StartPosition = FormStartPosition.CenterScreen;
                //Initializing the custom renderer class
                this.contextMenuStripEx = new CustomContextMenuStripEx();
                this.contextMenuStripEx.Text = "Exit";
                this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
                this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
                this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
                //Associate the context menu
                this.toolStripMenuItem1.Image = System.Drawing.Image.FromFile(@"..\..\Images\CopyHS.png");
                this.toolStripMenuItem2.Image = System.Drawing.Image.FromFile(@"..\..\Images\CutHS.png");
                this.toolStripMenuItem3.Image = System.Drawing.Image.FromFile(@"..\..\Images\PasteHS.png");
                this.toolStripMenuItem1.Text = "New";
                this.toolStripMenuItem2.Text = "Copy";
                this.toolStripMenuItem3.Text = "Cut";
                this.contextMenuStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem1, this.toolStripMenuItem2, this.toolStripMenuItem3, });
               //Add the CustomcontextmenustripEx to form ContextMenuStrip
                this.ContextMenuStrip = this.contextMenuStripEx;
                this.Text = "ContextMenuStripex";
            }
        }

        public class CustomContextMenuStripEx
            : ContextMenuStripEx
        {
            public override Rectangle DisplayRectangle
            {
                get
                {
                    Rectangle rc = base.DisplayRectangle;
                    rc.Y += TitleHeight;
                    return rc;
                }
            }

            public override Size GetPreferredSize(Size proposedSize)
            {
                Size szResult = base.GetPreferredSize(proposedSize);
                szResult.Height += TitleHeight;
                return szResult;
            }

            internal int TitleHeight
            {
                get { return 25; }
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                Image image = Image.FromFile(@"..\..\Images\ExitIcon.png");
                e.Graphics.FillRectangle(new SolidBrush(Control.DefaultBackColor), 1, 1, this.Width - 2, TitleHeight);
                Rectangle imgRect = new Rectangle(2, 2, 16, 16);
               //Draw image in header of ContextMenuStripEx
                e.Graphics.DrawImage(image, imgRect);
                Rectangle textRect = new Rectangle(imgRect.Width + 2, 2, this.Width, TitleHeight);
                e.Graphics.DrawString(Text, this.Font, new SolidBrush(Color.Black), textRect);
            }
        }
    }

