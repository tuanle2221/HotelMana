namespace HotelMana
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhatkyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choncongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layout = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbbPort = new System.Windows.Forms.ComboBox();
            this.khachhangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.choncongToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhatkyToolStripMenuItem,
            this.khachhangToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.menuToolStripMenuItem.Image = global::HotelMana.Properties.Resources.Boxm;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // nhatkyToolStripMenuItem
            // 
            this.nhatkyToolStripMenuItem.Image = global::HotelMana.Properties.Resources.Stats;
            this.nhatkyToolStripMenuItem.Name = "nhatkyToolStripMenuItem";
            this.nhatkyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nhatkyToolStripMenuItem.Text = "Nhật ký phòng thuê";
            this.nhatkyToolStripMenuItem.Click += new System.EventHandler(this.nhatkyToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Image = global::HotelMana.Properties.Resources.Shutdown;
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // choncongToolStripMenuItem
            // 
            this.choncongToolStripMenuItem.Image = global::HotelMana.Properties.Resources.Box;
            this.choncongToolStripMenuItem.Name = "choncongToolStripMenuItem";
            this.choncongToolStripMenuItem.Size = new System.Drawing.Size(176, 20);
            this.choncongToolStripMenuItem.Text = "Chọn cổng kết nối thiết bị:";
            // 
            // layout
            // 
            this.layout.AutoScroll = true;
            this.layout.BackColor = System.Drawing.Color.Transparent;
            this.layout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.layout.Location = new System.Drawing.Point(12, 111);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(503, 303);
            this.layout.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelMana.Properties.Resources.bg1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 398);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cbbPort
            // 
            this.cbbPort.BackColor = System.Drawing.Color.DarkGray;
            this.cbbPort.ForeColor = System.Drawing.Color.Fuchsia;
            this.cbbPort.FormattingEnabled = true;
            this.cbbPort.Location = new System.Drawing.Point(239, 2);
            this.cbbPort.Name = "cbbPort";
            this.cbbPort.Size = new System.Drawing.Size(121, 21);
            this.cbbPort.TabIndex = 4;
            this.cbbPort.SelectedIndexChanged += new System.EventHandler(this.cbbPort_SelectedIndexChanged);
            // 
            // khachhangToolStripMenuItem
            // 
            this.khachhangToolStripMenuItem.Name = "khachhangToolStripMenuItem";
            this.khachhangToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.khachhangToolStripMenuItem.Text = "Khachhang";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 421);
            this.Controls.Add(this.cbbPort);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.layout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Tag = " ";
            this.Text = "TEA Solutions - Hotel Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhatkyToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel layout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choncongToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbbPort;
        private System.Windows.Forms.ToolStripMenuItem khachhangToolStripMenuItem;
    }
}

