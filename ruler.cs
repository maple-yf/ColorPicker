using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 拾色器
{
    public partial class ruler : Form
    {
        private string g_state = "long";
        private bool is_double_click = false;
        public ruler()
        {
            InitializeComponent();
        }

        private void ruler_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = panel1.BackColor;
            //label1.BackColor = panel1.BackColor;

           
        }
        private void ruler_Paint(object sender, PaintEventArgs e)
        {
            Graphics dc = panel1.CreateGraphics(); //选择在哪个panel里面添加图画
            Pen pen = new Pen(Color.Black, 1); //定义画笔
            Pen penBold = new Pen(Color.Black, 2); //定义画笔
            Brush brush = new SolidBrush(Color.Black);
           
            dc.Clear(panel1.BackColor);//清空此前画的刻度

            if (g_state == "long")
            {
                for (int i = 0; i < panel1.Width; i++)
                {
                    if (i%10 == 0)
                    {
                        if (i%50 == 0)
                        {
                            dc.DrawLine(penBold, i, 0, i, 35); //画整十的线
                            if (i == 0)
                            {
                                dc.DrawString(i.ToString(), NowWidth.Font, brush, i, 36);
                            }
                            else dc.DrawString(i.ToString(), NowWidth.Font, brush, i - 10, 36);

                        }
                        else
                        {
                            dc.DrawLine(pen, i, 0, i, 25); //画个位是5的线
                        }
                    }
                    if (i%2 == 0)
                    {
                        dc.DrawLine(pen, i, 0, i, 15); //画最小刻度线
                    }
                }
            }
            else
            {
                for (int i = 0; i < panel1.Height; i++)
                {
                    if (i%10 == 0)
                    {
                        if (i%50 == 0)
                        {
                            dc.DrawLine(penBold, 0, i, 35, i); //画整十的线
                            if (i == 0)
                            {
                                dc.DrawString(i.ToString(), NowWidth.Font, brush, 36, i);
                            }
                            else dc.DrawString(i.ToString(), NowWidth.Font, brush, 36, i - 10);

                        }
                        else
                        {
                            dc.DrawLine(pen, 0, i, 25, i); //画个位是5的线
                        }
                    }
                    if (i%2 == 0)
                    {
                        dc.DrawLine(pen, 0, i, 15, i); //画最小刻度线
                    }
                }
            }
        }




        private void ruler_DoubleClick(object sender, EventArgs e)
        {
            is_double_click = true;
            int mid = 0;
            //转换Form的高和宽
            mid = this.Height;
            this.Height = this.Width;
            this.Width = mid;
            if (g_state == "long")
            {
                g_state = "high";
                NowWidth.Text = this.Height.ToString() + "px";
                NowWidth.Left = this.Width - 40;
            }
            else
            {
                g_state = "long";
                
                NowWidth.Text = this.Width.ToString() + "px";
                NowWidth.Left = this.Width - 40;
            }
           
        }

        private void ToolStripMenuItemAlwaysForward_Click(object sender, EventArgs e)
        {
            if(ToolStripMenuItemAlwaysForward.Checked)
            {
                ToolStripMenuItemAlwaysForward.Checked = false;
                this.TopMost = false;
            }
            else
            {
                ToolStripMenuItemAlwaysForward.Checked = true;
                this.TopMost = true;
            }
        }

        private void ToolStripMenuItemexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region 改变窗体大小
        const int WM_NCHITTEST = 0x0084;
        const int HTLEFT = 10;    //左边界
        const int HTRIGHT = 11;   //右边界
        const int HTTOP = 12; //上边界
        const int HTTOPLEFT = 13; //左上角
        const int HTTOPRIGHT = 14;    //右上角
        const int HTBOTTOM = 15;  //下边界
        const int HTBOTTOMLEFT = 0x10;    //左下角
        const int HTBOTTOMRIGHT = 17; //右下角

        protected override void WndProc(ref Message m)
        {
            //移动无框窗体
            if (m.Msg == 0x0201) //鼠标左键按下去的消息
            {
                m.Msg = 0x00A1; //更改消息为非客户区按下鼠标
                m.LParam = IntPtr.Zero; //默认值
                m.WParam = new IntPtr(2); //鼠标放在标题栏内
            }
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    {
                        Point vPoint = new Point((int)m.LParam & 0xFFFF, (int)m.LParam >> 16 & 0xFFFF);
                        vPoint = PointToClient(vPoint);
                        //判断：仅当当前窗体状态不是最大化时，相关鼠标事件生效
                        if (this.WindowState != FormWindowState.Maximized)
                        {
                            if (vPoint.X < 10)
                            {
                                if (vPoint.Y < 10)
                                {
                                    m.Result = (IntPtr)HTTOPLEFT;
                                }
                                else if (vPoint.Y > this.Height - 10)
                                {
                                    m.Result = (IntPtr)HTBOTTOMLEFT;
                                }
                                else
                                {
                                    m.Result = (IntPtr)HTLEFT;
                                }
                            }
                            else if (vPoint.X > this.Width - 10)
                            {
                                if (vPoint.Y < 10)
                                {
                                    m.Result = (IntPtr)HTTOPRIGHT;
                                }
                                else if (vPoint.Y > this.Height - 10)
                                {
                                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                                }
                                else
                                {
                                    m.Result = (IntPtr)HTRIGHT;
                                }
                            }
                            else if (10 < vPoint.X && vPoint.X < this.Width - 10)
                            {
                                if (vPoint.Y < 10)
                                {
                                    m.Result = (IntPtr)HTTOP;
                                }
                                else if (vPoint.Y > this.Height - 10)
                                {
                                    m.Result = (IntPtr)HTBOTTOM;
                                }
                            }
                        }
                        break;
                    }
            }
        }
        #endregion

        private void ruler_SizeChanged(object sender, EventArgs e)
        {
            if (g_state == "long" )
            { 
                NowWidth.Text = this.Width.ToString() + "px";
                NowWidth.Left = this.Width-40;
            }
            else if (g_state == "high" )
            {
                NowWidth.Text = this.Height.ToString() + "px";
                NowWidth.Left = this.Width - 40;    
            }
            is_double_click = false;

            panel1.Width = this.Width ;
            panel1.Height = this.Height - 36;
            if(this.Width<80)
            {
                MessageBox.Show("已经到最小值！");
                this.Width = 80;
                panel1.Width = 80 ;
            }
            if(this.Height<80)
            {
                MessageBox.Show("已经到最小值！");
                this.Height = 80;
                panel1.Height = 80 - 36;
            }
        }

        private void ruler_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: 
                    this.Top -= 1;
                    break;
                case Keys.Down:
                    this.Top += 1;
                    break;
                case Keys.Left:
                    this.Left -= 1;
                    break;
                case Keys.Right:
                    this.Left += 1;
                    break;

            }
            
        }

    }
}
