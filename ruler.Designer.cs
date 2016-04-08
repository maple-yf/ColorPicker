namespace 拾色器
{
    partial class ruler
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemAlwaysForward = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItempixel = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemcm = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemexit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NowWidth = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAlwaysForward,
            this.ToolStripMenuItempixel,
            this.ToolStripMenuItemcm,
            this.ToolStripMenuItemexit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(125, 92);
            // 
            // ToolStripMenuItemAlwaysForward
            // 
            this.ToolStripMenuItemAlwaysForward.Checked = true;
            this.ToolStripMenuItemAlwaysForward.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripMenuItemAlwaysForward.Name = "ToolStripMenuItemAlwaysForward";
            this.ToolStripMenuItemAlwaysForward.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItemAlwaysForward.Text = "总在最前";
            this.ToolStripMenuItemAlwaysForward.Click += new System.EventHandler(this.ToolStripMenuItemAlwaysForward_Click);
            // 
            // ToolStripMenuItempixel
            // 
            this.ToolStripMenuItempixel.Checked = true;
            this.ToolStripMenuItempixel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripMenuItempixel.Name = "ToolStripMenuItempixel";
            this.ToolStripMenuItempixel.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItempixel.Text = "像素";
            // 
            // ToolStripMenuItemcm
            // 
            this.ToolStripMenuItemcm.Name = "ToolStripMenuItemcm";
            this.ToolStripMenuItemcm.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItemcm.Text = "厘米";
            // 
            // ToolStripMenuItemexit
            // 
            this.ToolStripMenuItemexit.Name = "ToolStripMenuItemexit";
            this.ToolStripMenuItemexit.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItemexit.Text = "退出";
            this.ToolStripMenuItemexit.Click += new System.EventHandler(this.ToolStripMenuItemexit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 48);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.ruler_Paint);
            // 
            // NowWidth
            // 
            this.NowWidth.AutoSize = true;
            this.NowWidth.Location = new System.Drawing.Point(539, 4);
            this.NowWidth.Name = "NowWidth";
            this.NowWidth.Size = new System.Drawing.Size(0, 12);
            this.NowWidth.TabIndex = 3;
            // 
            // ruler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(584, 84);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.NowWidth);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ruler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ruler";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ruler_Load);
            this.SizeChanged += new System.EventHandler(this.ruler_SizeChanged);
            this.DoubleClick += new System.EventHandler(this.ruler_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ruler_KeyDown);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAlwaysForward;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItempixel;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemcm;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemexit;
        private System.Windows.Forms.Label NowWidth;
    }
}