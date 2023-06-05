using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Pet_Management
{
    internal class DotNetBarTabControl : TabControl
    {
        public DotNetBarTabControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(44, 136);
            Alignment = TabAlignment.Left;
            SelectedIndex = 0;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Bitmap b = new Bitmap(Width, Height))
            {
                using (Graphics g = Graphics.FromImage(b))
                {
                    if (!DesignMode)
                        SelectedTab.BackColor = SystemColors.Control;

                    g.Clear(SystemColors.Control);
                    g.FillRectangle(new SolidBrush(Color.FromArgb(246, 248, 252)), new Rectangle(0, 0, ItemSize.Height + 4, Height));
                    g.DrawLine(new Pen(Color.FromArgb(170, 187, 204)), new Point(ItemSize.Height + 3, 0), new Point(ItemSize.Height + 3, 999));
                    g.DrawLine(new Pen(Color.FromArgb(170, 187, 204)), new Point(0, Size.Height - 1), new Point(Width + 3, Size.Height - 1));

                    for (int i = 0; i < TabCount; i++)
                    {
                        Rectangle tabRect = GetTabRect(i);

                        if (i == SelectedIndex)
                        {
                            Rectangle tabBackgroundRect = new Rectangle(tabRect.Location.X - 2, tabRect.Location.Y - 2, tabRect.Width + 3, tabRect.Height - 1);

                            ColorBlend myBlend = new ColorBlend();
                            myBlend.Colors = new Color[] { Color.FromArgb(232, 232, 240), Color.FromArgb(232, 232, 240), Color.FromArgb(232, 232, 240) };
                            myBlend.Positions = new float[] { 0f, 0.5f, 1f };
                            LinearGradientBrush lgBrush = new LinearGradientBrush(tabBackgroundRect, Color.Black, Color.Black, 90f);
                            lgBrush.InterpolationColors = myBlend;

                            g.FillRectangle(lgBrush, tabBackgroundRect);
                            g.DrawRectangle(new Pen(Color.FromArgb(170, 187, 204)), tabBackgroundRect);

                            g.SmoothingMode = SmoothingMode.HighQuality;
                            Point[] arrowPoints =
                            {
                                new Point(ItemSize.Height - 3, tabRect.Location.Y + 20),
                                new Point(ItemSize.Height + 4, tabRect.Location.Y + 14),
                                new Point(ItemSize.Height + 4, tabRect.Location.Y + 27)
                            };
                            g.FillPolygon(SystemBrushes.Control, arrowPoints);
                            g.DrawPolygon(new Pen(Color.FromArgb(170, 187, 204)), arrowPoints);

                            if (ImageList != null && TabPages[i].ImageIndex >= 0 && TabPages[i].ImageIndex < ImageList.Images.Count)
                            {
                                try
                                {
                                    g.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(tabBackgroundRect.Location.X + 8, tabBackgroundRect.Location.Y + 6));
                                    g.DrawString("  " + TabPages[i].Text, Font, Brushes.Black, tabBackgroundRect, new StringFormat
                                    {
                                        LineAlignment = StringAlignment.Center,
                                        Alignment = StringAlignment.Center
                                    });
                                }
                                catch (Exception)
                                {
                                    g.DrawString(TabPages[i].Text, new Font(Font.FontFamily, Font.Size, FontStyle.Bold), Brushes.Black, tabBackgroundRect, new StringFormat
                                    {
                                        LineAlignment = StringAlignment.Center,
                                        Alignment = StringAlignment.Center
                                    });
                                }
                            }
                            else
                            {
                                g.DrawString(TabPages[i].Text, new Font(Font.FontFamily, Font.Size, FontStyle.Bold), Brushes.Black, tabBackgroundRect, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }

                            g.DrawLine(new Pen(Color.FromArgb(200, 200, 250)), new Point(tabBackgroundRect.Location.X - 1, tabBackgroundRect.Location.Y - 1), new Point(tabBackgroundRect.Location.X, tabBackgroundRect.Location.Y));
                            g.DrawLine(new Pen(Color.FromArgb(200, 200, 250)), new Point(tabBackgroundRect.Location.X - 1, tabBackgroundRect.Bottom - 1), new Point(tabBackgroundRect.Location.X, tabBackgroundRect.Bottom));
                        }
                        else
                        {
                            Rectangle tabBackgroundRect = new Rectangle(tabRect.Location.X - 2, tabRect.Location.Y - 2, tabRect.Width + 3, tabRect.Height - 1);

                            g.FillRectangle(new SolidBrush(Color.FromArgb(246, 248, 252)), tabBackgroundRect);
                            g.DrawLine(new Pen(Color.FromArgb(170, 187, 204)), new Point(tabBackgroundRect.Right, tabBackgroundRect.Top), new Point(tabBackgroundRect.Right, tabBackgroundRect.Bottom));

                            if (ImageList != null && TabPages[i].ImageIndex >= 0 && TabPages[i].ImageIndex < ImageList.Images.Count)
                            {
                                try
                                {
                                    g.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(tabBackgroundRect.Location.X + 8, tabBackgroundRect.Location.Y + 6));
                                    g.DrawString("  " + TabPages[i].Text, Font, Brushes.DimGray, tabBackgroundRect, new StringFormat
                                    {
                                        LineAlignment = StringAlignment.Center,
                                        Alignment = StringAlignment.Center
                                    });
                                }
                                catch (Exception)
                                {
                                    g.DrawString(TabPages[i].Text, Font, Brushes.DimGray, tabBackgroundRect, new StringFormat
                                    {
                                        LineAlignment = StringAlignment.Center,
                                        Alignment = StringAlignment.Center
                                    });
                                }
                            }
                            else
                            {
                                g.DrawString(TabPages[i].Text, Font, Brushes.DimGray, tabBackgroundRect, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                        }
                    }

                    e.Graphics.DrawImage(b, new Point(0, 0));
                }
            }
        }
    }
}
