using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace 拾色器
{
    public partial class Form1 : Form
    {
        int value_mid = 0;
        bool T1 = false, T = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			//this.ReFresh();
            int value;  
            value =Convert.ToInt32( this.textBox1.Text);
            Color color = Color.FromArgb(value);
            this.panel1.BackColor = color;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int value_r = 0, value_g = 0, value_b = 0;
            string text_value = "", text_value_changed = "";
            text_value = textBox1.Text;

            //MessageBox.Show("1 "+text_value);
            if (text_value.Substring(0, 1) == "#")//在此处把 "#" 剔除
            {
                text_value = text_value.Substring(1, text_value.Length - 1);
                //MessageBox.Show("2 " + text_value);
            }
            if (text_value.Length < 6)
            {
                for (int i = 6 - text_value.Length; i > 0; i--)
                {
                    text_value += "0";
                }
                textBox1.Text = "#" + text_value;
                //MessageBox.Show("3 " + text_value);

            }
            if (text_value.Length > 6)
            {
                text_value = text_value.Substring(0, 6);
                textBox1.Text = "#"+text_value;
            }
            for (int i = 0; i < 6; i++)
            {
                char mid_char = text_value[i];
                Hex hex = new Hex();
                if (!hex.Text_string(mid_char))
                {
                    MessageBox.Show("非法字符！");
                    textBox1.Text = textBox1.Text.Substring(0, i);
                    textBox1.Select(textBox1.Text.Length, 0);//光标锁定在字符串最右端
                    return;
                }
                if (i % 2 == 0)
                {
                    value_mid = (hex.H_to_D(mid_char) * 16);
                }
                else
                {
                    value_mid += hex.H_to_D(mid_char);
                    switch (i)
                    {
                        case 1: value_r = value_mid; break;
                        case 3: value_g = value_mid; break;
                        case 5: value_b = value_mid; break;
                    }
                }
                //if (text_value_changed.Length > 9) text_value_changed = text_value_changed.Substring(0, 9);
            }
            Color color = Color.FromArgb(255, value_r, value_g, value_b);
            this.panel1.BackColor = color;

            text_value = ""; text_value_changed = "";

            /*
            if (!T1)
            {
                int value_r = 0, value_g = 0, value_b = 0;
                // int value=0;
                string text_value = "", text_value_changed = "";
                text_value = textBox1.Text;
                
                 //在此处把 "#" 剔除
                 
                text_value = text_value.Substring(1, text_value.Length - 1);
                if (text_value.Length < 6)
                {
                    for (int i = 6 - text_value.Length; i > 0; i--)
                        text_value += "0";
                }
                if (text_value.Length > 6)
                {
                    text_value = text_value.Substring(0, 6);
                    textBox1.Text = text_value;
                }
                //MessageBox.Show(text_value);
                for (int i = 0; i < 6; i++)
                {
                    char mid_char = text_value[i];
                    Hex hex = new Hex();
                    if (!hex.Text_string(mid_char))
                    {
                        MessageBox.Show("非法字符！");
                        textBox1.Text = textBox1.Text.Substring(0, i);
                        textBox1.Select(textBox1.Text.Length, 0);//光标锁定在字符串最右端
                        return;
                    }
                    if (i % 2 == 0)
                    {
                        value_mid = (hex.H_to_D(mid_char) * 16);
                    }
                    else
                    {
                        value_mid += hex.H_to_D(mid_char);
                        switch (i)
                        {
                            case 1: value_r = value_mid; break;
                            case 3: value_g = value_mid; break;
                            case 5: value_b = value_mid; break;
                        }
                        Red_textBox.Text = value_r.ToString();
                        Green_textBox.Text = value_g.ToString();
                        Blue_textBox.Text = value_b.ToString();
                       // MessageBox.Show(value_g.ToString());
                    }
                    //MessageBox.Show(value_mid.ToString()+":"+"r"+value_r.ToString());
                    //MessageBox.Show(hex.H_to_D(mid_char).ToString());
                    if (text_value_changed.Length > 9) text_value_changed = text_value_changed.Substring(0, 9);
                }
                // MessageBox.Show(text_value_changed);
                //value = Convert.ToInt32(text_value_changed);

                Color color = Color.FromArgb(255, value_r, value_g, value_b);
                //MessageBox.Show(color.ToString());
                this.panel1.BackColor = color;

                text_value = ""; text_value_changed = "";
                T = true;
                //MessageBox.Show(T.ToString());
            }
            else T1 = false;*/
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            //if ((textBox1.Text.Length==6||textBox1.Text.Length==0))
            //{
                string mid_string = "";
                Hex hex = new Hex();
                TextBox mid_text_box = (TextBox)sender;
                if (mid_text_box.Text == "")
                {
                   mid_text_box.Text = "0";
                    MessageBox.Show("非法");
                }
                if (Convert.ToInt32(mid_text_box.Text) > 255 || Convert.ToInt32(mid_text_box.Text) < 0)
                {
                    mid_text_box.Text = "0";
                    MessageBox.Show("数值不在正常范围！");
                }
                /*mid_string = hex.D_to_H(Red_textBox.Text);
                mid_string += hex.D_to_H(Green_textBox.Text);
                mid_string += hex.D_to_H(Blue_textBox.Text);*/
                //MessageBox.Show("T"+T.ToString());
                //MessageBox.Show(mid_string);
                this.panel1.BackColor = Color.FromArgb(255,Convert.ToInt32(Red_textBox.Text),Convert.ToInt32(Green_textBox.Text),Convert.ToInt32(Blue_textBox.Text));
                //textBox1.Text = mid_string;
                mid_string = "";
                
           // }
        }

        [DllImport("user32.dll", EntryPoint = "GetCursorPos")]//获取鼠标坐标
        public static extern int GetCursorPos(
            ref POINTAPI lpPoint
        );

        [StructLayout(LayoutKind.Sequential)]//定义与API相兼容结构体，实际上是一种内存转换
        public struct POINTAPI
        {
            public int X;
            public int Y;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            POINTAPI point = new POINTAPI();//非托管内存坐标结构体
            int r = GetCursorPos(ref point);//获取坐标
            using (Bitmap myBitmap = GetTopColor.GetDesktop())//将桌面保存到myBitmap中去，其实有点类似桌面截图了，当然仍旧对DirectX没有办法
            {
                Color myColor = myBitmap.GetPixel(
                    point.X, point.Y);//取指定坐标点的颜色
                //this.textBox1.Text = point.X.ToString() + " : " + point.Y.ToString();
                //textBox1.Text = myColor.ToArgb().ToString();
                //textBox2.Text = myColor.ToArgb().ToString();


                Red_textBox.Text = myColor.R + "";
                trackBarRed.Value = myColor.R;

                Green_textBox.Text = myColor.G + "";
                trackBarGreen.Value = myColor.G;

                Blue_textBox.Text = myColor.B + "";
                trackBarBlue.Value = myColor.B;

                Hex h=new Hex();
                textBox1.Text ="#"+h.D_to_H(myColor.R.ToString()) + 
                    h.D_to_H(myColor.G.ToString()) + h.D_to_H(myColor.B.ToString());

                panel1.BackColor = myColor;
                //this.textBox1.Text = panel1.BackColor.ToArgb().ToString();

            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if((Keys)(e.KeyChar)==Keys.Enter)
            {
                if(timer1.Enabled)
                {
                    timer1.Enabled = false;
                    textBox1.ReadOnly = false;
                }
                else
                {
                    timer1.Enabled = true;
                    textBox1.ReadOnly = true;
                }

            }

           
        }

        private void alltop_CheckedChanged_1(object sender, EventArgs e)
        {
            if (alltop.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void opencolordialog_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog=new ColorDialog();

            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.AnyColor = true;
            colorDialog.ShowHelp = true;
            colorDialog.SolidColorOnly = false;

            colorDialog.ShowDialog();
            colorDialog.Color.ToString();
            panel1.BackColor = colorDialog.Color;

            Color myColor = colorDialog.Color;
            Red_textBox.Text = myColor.R + "";
            Green_textBox.Text = myColor.G + "";
            Blue_textBox.Text = myColor.B + "";
            Hex h = new Hex();
            textBox1.Text = "#" + h.D_to_H(myColor.R.ToString()) +
                h.D_to_H(myColor.G.ToString()) + h.D_to_H(myColor.B.ToString());
            textBox1.Focus();

        }

        private void panel1_BackColorChanged(object sender, EventArgs e)
        {
            Color theColor = panel1.BackColor;

            Red_textBox.Text = theColor.R + "";
            Green_textBox.Text = theColor.G + "";
            Blue_textBox.Text = theColor.B + "";

            Hex h = new Hex();

            textBox1.Text = "#" + h.D_to_H(theColor.R.ToString()) +
               h.D_to_H(theColor.G.ToString()) + h.D_to_H(theColor.B.ToString());
            textBox1.Focus();

            trackBarBlue.Value=Convert.ToInt32(Blue_textBox.Text);
            trackBarRed.Value = Convert.ToInt32(Red_textBox.Text);
            trackBarGreen.Value = Convert.ToInt32(Green_textBox.Text);

        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            Red_textBox.Text = trackBarRed.Value.ToString();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            Green_textBox.Text = trackBarGreen.Value.ToString();
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            Blue_textBox.Text = trackBarBlue.Value.ToString();
        }

        private void OpenRuler_Click(object sender, EventArgs e)
        {
            ruler ruler=new ruler();
            ruler.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Red_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (trackBarRed.Value > 0 && trackBarRed.Value < 255)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        trackBarRed.Value += 1;
                        break;
                    case Keys.Down:
                        trackBarRed.Value -= 1;
                        break;
                    case Keys.Left:
                        trackBarRed.Value -= 1;
                        break;
                    case Keys.Right:
                        trackBarRed.Value += 1;
                        break;

                }
            }
            Red_textBox.Text = trackBarRed.Value.ToString();
            Red_textBox.Focus();
        }

        private void Green_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (trackBarGreen.Value > 0 && trackBarGreen.Value < 255)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        trackBarGreen.Value += 1;
                        break;
                    case Keys.Down:
                        trackBarGreen.Value -= 1;
                        break;
                    case Keys.Left:
                        trackBarGreen.Value -= 1;
                        break;
                    case Keys.Right:
                        trackBarGreen.Value += 1;
                        break;

                }
            }
            Green_textBox.Text = trackBarGreen.Value.ToString();
            Green_textBox.Focus();
        }

        private void Blue_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (trackBarBlue.Value > 0 && trackBarBlue.Value < 255)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        trackBarBlue.Value += 1;
                        break;
                    case Keys.Down:
                        trackBarBlue.Value -= 1;
                        break;
                    case Keys.Left:
                        trackBarBlue.Value -= 1;
                        break;
                    case Keys.Right:
                        trackBarBlue.Value += 1;
                        break;

                }
            }
            Blue_textBox.Text = trackBarBlue.Value.ToString();
            Blue_textBox.Focus();
        }
    }
}
