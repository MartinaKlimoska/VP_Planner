
namespace Planner
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
            this.menupanel = new System.Windows.Forms.Panel();
            this.datelabel = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.dayofweeklabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelD = new System.Windows.Forms.Panel();
            this.rightLabel = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.leftLabel = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menupanel.SuspendLayout();
            this.panelD.SuspendLayout();
            this.SuspendLayout();
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(219)))), ((int)(((byte)(224)))));
            this.menupanel.Controls.Add(this.datelabel);
            this.menupanel.Controls.Add(this.timelabel);
            this.menupanel.Controls.Add(this.dayofweeklabel);
            this.menupanel.Controls.Add(this.button4);
            this.menupanel.Controls.Add(this.button2);
            this.menupanel.Controls.Add(this.button1);
            this.menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menupanel.Location = new System.Drawing.Point(0, 0);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(200, 518);
            this.menupanel.TabIndex = 0;
            // 
            // datelabel
            // 
            this.datelabel.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.Location = new System.Drawing.Point(5, 19);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(190, 35);
            this.datelabel.TabIndex = 6;
            this.datelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timelabel
            // 
            this.timelabel.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel.Location = new System.Drawing.Point(4, 108);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(190, 40);
            this.timelabel.TabIndex = 5;
            this.timelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayofweeklabel
            // 
            this.dayofweeklabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayofweeklabel.Location = new System.Drawing.Point(5, 60);
            this.dayofweeklabel.Name = "dayofweeklabel";
            this.dayofweeklabel.Size = new System.Drawing.Size(190, 41);
            this.dayofweeklabel.TabIndex = 4;
            this.dayofweeklabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(219)))), ((int)(((byte)(224)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(4, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 56);
            this.button4.TabIndex = 3;
            this.button4.Text = "About";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(4, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "All Tasks";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "All Events";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelD
            // 
            this.panelD.BackColor = System.Drawing.Color.White;
            this.panelD.Controls.Add(this.rightLabel);
            this.panelD.Controls.Add(this.rightPanel);
            this.panelD.Controls.Add(this.button6);
            this.panelD.Controls.Add(this.button5);
            this.panelD.Controls.Add(this.leftLabel);
            this.panelD.Controls.Add(this.leftPanel);
            this.panelD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelD.Location = new System.Drawing.Point(200, 0);
            this.panelD.Name = "panelD";
            this.panelD.Size = new System.Drawing.Size(655, 518);
            this.panelD.TabIndex = 1;
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLabel.Location = new System.Drawing.Point(354, 16);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(46, 17);
            this.rightLabel.TabIndex = 7;
            this.rightLabel.Text = "Tasks";
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanel.AutoScroll = true;
            this.rightPanel.Location = new System.Drawing.Point(338, 77);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(297, 426);
            this.rightPanel.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(219)))), ((int)(((byte)(224)))));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(21, 46);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(280, 30);
            this.button6.TabIndex = 5;
            this.button6.Text = "Add new Event";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(219)))), ((int)(((byte)(224)))));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(338, 46);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(280, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "Add new Task";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftLabel.Location = new System.Drawing.Point(36, 16);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(51, 17);
            this.leftLabel.TabIndex = 3;
            this.leftLabel.Text = "Events";
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftPanel.AutoScroll = true;
            this.leftPanel.Location = new System.Drawing.Point(21, 77);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(297, 426);
            this.leftPanel.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 518);
            this.Controls.Add(this.panelD);
            this.Controls.Add(this.menupanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Planner";
            this.menupanel.ResumeLayout(false);
            this.panelD.ResumeLayout(false);
            this.panelD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.Panel panelD;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label dayofweeklabel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Timer timer1;
    }
}