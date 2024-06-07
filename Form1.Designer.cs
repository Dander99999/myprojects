namespace Japanese_crossword
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolskrit = new System.Windows.Forms.ToolStripButton();
            this.toolplay = new System.Windows.Forms.ToolStripButton();
            this.toolhelp = new System.Windows.Forms.ToolStripButton();
            this.toolend = new System.Windows.Forms.ToolStripButton();
            this.toolstscrit = new System.Windows.Forms.ToolStripButton();
            this.toolstplay = new System.Windows.Forms.ToolStripButton();
            this.toolstbtnhelp = new System.Windows.Forms.ToolStripButton();
            this.toolstbtnend = new System.Windows.Forms.ToolStripButton();
            this.btnstart = new System.Windows.Forms.Button();
            this.lbligra = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.pnlverhyaprov = new System.Windows.Forms.Panel();
            this.pnlslevprov = new System.Windows.Forms.Panel();
            this.pnligra = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnsdatsya = new System.Windows.Forms.Button();
            this.buttonochki = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolskrit,
            this.toolplay,
            this.buttonochki,
            this.toolhelp,
            this.toolend});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1184, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolskrit
            // 
            this.toolskrit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolskrit.Image = ((System.Drawing.Image)(resources.GetObject("toolskrit.Image")));
            this.toolskrit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolskrit.Name = "toolskrit";
            this.toolskrit.Size = new System.Drawing.Size(58, 22);
            this.toolskrit.Text = "Скрыть";
            this.toolskrit.Click += new System.EventHandler(this.toolskrit_Click);
            // 
            // toolplay
            // 
            this.toolplay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolplay.Image = ((System.Drawing.Image)(resources.GetObject("toolplay.Image")));
            this.toolplay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolplay.Name = "toolplay";
            this.toolplay.Size = new System.Drawing.Size(136, 22);
            this.toolplay.Text = "Выбрать сложность";
            this.toolplay.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolhelp
            // 
            this.toolhelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolhelp.Image = ((System.Drawing.Image)(resources.GetObject("toolhelp.Image")));
            this.toolhelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolhelp.Name = "toolhelp";
            this.toolhelp.Size = new System.Drawing.Size(65, 22);
            this.toolhelp.Text = "Помощь";
            this.toolhelp.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolend
            // 
            this.toolend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolend.Image = ((System.Drawing.Image)(resources.GetObject("toolend.Image")));
            this.toolend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolend.Name = "toolend";
            this.toolend.Size = new System.Drawing.Size(52, 22);
            this.toolend.Text = "Выйти";
            this.toolend.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolstscrit
            // 
            this.toolstscrit.Name = "toolstscrit";
            this.toolstscrit.Size = new System.Drawing.Size(23, 23);
            // 
            // toolstplay
            // 
            this.toolstplay.Name = "toolstplay";
            this.toolstplay.Size = new System.Drawing.Size(23, 23);
            // 
            // toolstbtnhelp
            // 
            this.toolstbtnhelp.Name = "toolstbtnhelp";
            this.toolstbtnhelp.Size = new System.Drawing.Size(23, 23);
            // 
            // toolstbtnend
            // 
            this.toolstbtnend.Name = "toolstbtnend";
            this.toolstbtnend.Size = new System.Drawing.Size(23, 23);
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.Red;
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnstart.ForeColor = System.Drawing.Color.Blue;
            this.btnstart.Location = new System.Drawing.Point(1022, 903);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(150, 40);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Visible = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // lbligra
            // 
            this.lbligra.AutoSize = true;
            this.lbligra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbligra.ForeColor = System.Drawing.Color.Red;
            this.lbligra.Location = new System.Drawing.Point(12, 129);
            this.lbligra.Name = "lbligra";
            this.lbligra.Size = new System.Drawing.Size(78, 31);
            this.lbligra.TabIndex = 2;
            this.lbligra.Text = "Игра";
            this.lbligra.Visible = false;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbltime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbltime.Location = new System.Drawing.Point(43, 160);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(103, 31);
            this.lbltime.TabIndex = 3;
            this.lbltime.Text = "00 : 00";
            this.lbltime.Visible = false;
            // 
            // pnlverhyaprov
            // 
            this.pnlverhyaprov.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlverhyaprov.Location = new System.Drawing.Point(178, 51);
            this.pnlverhyaprov.Name = "pnlverhyaprov";
            this.pnlverhyaprov.Size = new System.Drawing.Size(400, 160);
            this.pnlverhyaprov.TabIndex = 4;
            this.pnlverhyaprov.Visible = false;
            // 
            // pnlslevprov
            // 
            this.pnlslevprov.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlslevprov.Location = new System.Drawing.Point(12, 216);
            this.pnlslevprov.Name = "pnlslevprov";
            this.pnlslevprov.Size = new System.Drawing.Size(160, 400);
            this.pnlslevprov.TabIndex = 5;
            this.pnlslevprov.Visible = false;
            // 
            // pnligra
            // 
            this.pnligra.BackColor = System.Drawing.Color.IndianRed;
            this.pnligra.Location = new System.Drawing.Point(178, 217);
            this.pnligra.Name = "pnligra";
            this.pnligra.Size = new System.Drawing.Size(400, 400);
            this.pnligra.TabIndex = 5;
            this.pnligra.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnsdatsya
            // 
            this.btnsdatsya.BackColor = System.Drawing.Color.RosyBrown;
            this.btnsdatsya.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsdatsya.ForeColor = System.Drawing.Color.Red;
            this.btnsdatsya.Location = new System.Drawing.Point(1022, 857);
            this.btnsdatsya.Name = "btnsdatsya";
            this.btnsdatsya.Size = new System.Drawing.Size(150, 40);
            this.btnsdatsya.TabIndex = 6;
            this.btnsdatsya.Text = "Сдаться";
            this.btnsdatsya.UseVisualStyleBackColor = false;
            this.btnsdatsya.Visible = false;
            this.btnsdatsya.Click += new System.EventHandler(this.btnsdatsya_Click);
            // 
            // buttonochki
            // 
            this.buttonochki.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonochki.Image = ((System.Drawing.Image)(resources.GetObject("buttonochki.Image")));
            this.buttonochki.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonochki.Name = "buttonochki";
            this.buttonochki.Size = new System.Drawing.Size(42, 22);
            this.buttonochki.Text = "Очки";
            this.buttonochki.Click += new System.EventHandler(this.buttonochki_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Japanese_crossword.Properties.Resources.SakuraDerevya;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 961);
            this.Controls.Add(this.btnsdatsya);
            this.Controls.Add(this.pnligra);
            this.Controls.Add(this.pnlslevprov);
            this.Controls.Add(this.pnlverhyaprov);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lbligra);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 1000);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Японский кроссворд";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolstplay;
        private System.Windows.Forms.ToolStripButton toolstbtnhelp;
        private System.Windows.Forms.ToolStripButton toolstbtnend;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label lbligra;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.ToolStripButton toolstscrit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnsdatsya;
        private System.Windows.Forms.Panel pnlverhyaprov;
        private System.Windows.Forms.Panel pnlslevprov;
        private System.Windows.Forms.Panel pnligra;
        private System.Windows.Forms.ToolStripButton toolskrit;
        private System.Windows.Forms.ToolStripButton toolplay;
        private System.Windows.Forms.ToolStripButton toolhelp;
        private System.Windows.Forms.ToolStripButton toolend;
        private System.Windows.Forms.ToolStripButton buttonochki;
    }
}

