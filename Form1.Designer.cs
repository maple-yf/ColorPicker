namespace 拾色器
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Blue_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Green_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Red_textBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.opencolordialog = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.alltop = new System.Windows.Forms.CheckBox();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.OpenRuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 181);
            this.panel1.TabIndex = 0;
            this.panel1.BackColorChanged += new System.EventHandler(this.panel1_BackColorChanged);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(372, 175);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 35);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Blue_textBox
            // 
            this.Blue_textBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Blue_textBox.Location = new System.Drawing.Point(371, 305);
            this.Blue_textBox.MaxLength = 3;
            this.Blue_textBox.Name = "Blue_textBox";
            this.Blue_textBox.ReadOnly = true;
            this.Blue_textBox.Size = new System.Drawing.Size(71, 33);
            this.Blue_textBox.TabIndex = 4;
            this.Blue_textBox.Text = "0";
            this.Blue_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Blue_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Blue_textBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(450, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(448, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "G";
            // 
            // Green_textBox
            // 
            this.Green_textBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Green_textBox.Location = new System.Drawing.Point(371, 266);
            this.Green_textBox.MaxLength = 3;
            this.Green_textBox.Name = "Green_textBox";
            this.Green_textBox.ReadOnly = true;
            this.Green_textBox.Size = new System.Drawing.Size(71, 33);
            this.Green_textBox.TabIndex = 3;
            this.Green_textBox.Text = "0";
            this.Green_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Green_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Green_textBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(450, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "R";
            // 
            // Red_textBox
            // 
            this.Red_textBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Red_textBox.Location = new System.Drawing.Point(371, 227);
            this.Red_textBox.MaxLength = 3;
            this.Red_textBox.Name = "Red_textBox";
            this.Red_textBox.ReadOnly = true;
            this.Red_textBox.Size = new System.Drawing.Size(71, 33);
            this.Red_textBox.TabIndex = 2;
            this.Red_textBox.Text = "0";
            this.Red_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Red_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Red_textBox_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "\"Enter\"键开始和退出“拾色”";
            // 
            // opencolordialog
            // 
            this.opencolordialog.Location = new System.Drawing.Point(372, 134);
            this.opencolordialog.Name = "opencolordialog";
            this.opencolordialog.Size = new System.Drawing.Size(104, 35);
            this.opencolordialog.TabIndex = 10;
            this.opencolordialog.Text = "配色器";
            this.opencolordialog.UseVisualStyleBackColor = true;
            this.opencolordialog.Click += new System.EventHandler(this.opencolordialog_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(374, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Made by maplecumt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(406, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "2012.09";
            // 
            // alltop
            // 
            this.alltop.AutoSize = true;
            this.alltop.Location = new System.Drawing.Point(380, 61);
            this.alltop.Name = "alltop";
            this.alltop.Size = new System.Drawing.Size(96, 16);
            this.alltop.TabIndex = 13;
            this.alltop.Text = "始终最前显示";
            this.alltop.UseVisualStyleBackColor = true;
            this.alltop.CheckedChanged += new System.EventHandler(this.alltop_CheckedChanged_1);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(43, 236);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(320, 45);
            this.trackBarRed.TabIndex = 14;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            this.trackBarRed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Red_textBox_KeyDown);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(43, 271);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(320, 45);
            this.trackBarGreen.TabIndex = 15;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            this.trackBarGreen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Green_textBox_KeyDown);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(43, 305);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(320, 45);
            this.trackBarBlue.TabIndex = 16;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            this.trackBarBlue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Blue_textBox_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(9, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "R";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(7, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "G";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(7, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 28);
            this.label9.TabIndex = 17;
            this.label9.Text = "B";
            // 
            // OpenRuler
            // 
            this.OpenRuler.Location = new System.Drawing.Point(372, 92);
            this.OpenRuler.Name = "OpenRuler";
            this.OpenRuler.Size = new System.Drawing.Size(104, 35);
            this.OpenRuler.TabIndex = 20;
            this.OpenRuler.Text = "打开尺子";
            this.OpenRuler.UseVisualStyleBackColor = true;
            this.OpenRuler.Click += new System.EventHandler(this.OpenRuler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 354);
            this.Controls.Add(this.OpenRuler);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.alltop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.opencolordialog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Red_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Green_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Blue_textBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "拾色器";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Blue_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Green_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Red_textBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button opencolordialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox alltop;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button OpenRuler;
    }
}

