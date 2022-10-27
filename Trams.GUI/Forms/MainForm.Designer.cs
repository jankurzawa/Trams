namespace Trams.GUI.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsllVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsllDataBase = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnTrams = new System.Windows.Forms.Button();
            this.btnRoutes = new System.Windows.Forms.Button();
            this.btnStops = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox2.Location = new System.Drawing.Point(0, -8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(984, 90);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 226);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(982, 491);
            this.mainPanel.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsllVersion,
            this.tsllDataBase});
            this.statusStrip1.Location = new System.Drawing.Point(0, 728);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(982, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsllVersion
            // 
            this.tsllVersion.Name = "tsllVersion";
            this.tsllVersion.Size = new System.Drawing.Size(91, 20);
            this.tsllVersion.Text = "Version 1.0.0";
            // 
            // tsllDataBase
            // 
            this.tsllDataBase.Image = ((System.Drawing.Image)(resources.GetObject("tsllDataBase.Image")));
            this.tsllDataBase.Name = "tsllDataBase";
            this.tsllDataBase.Size = new System.Drawing.Size(138, 20);
            this.tsllDataBase.Text = "DataBase: Trams";
            // 
            // btnTrams
            // 
            this.btnTrams.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTrams.BackColor = System.Drawing.Color.White;
            this.btnTrams.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTrams.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTrams.Image = ((System.Drawing.Image)(resources.GetObject("btnTrams.Image")));
            this.btnTrams.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrams.Location = new System.Drawing.Point(331, 83);
            this.btnTrams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTrams.Name = "btnTrams";
            this.btnTrams.Size = new System.Drawing.Size(323, 142);
            this.btnTrams.TabIndex = 3;
            this.btnTrams.Text = "Trams";
            this.btnTrams.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrams.UseVisualStyleBackColor = false;
            this.btnTrams.Click += new System.EventHandler(this.btnTrams_Click);
            // 
            // btnRoutes
            // 
            this.btnRoutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRoutes.BackColor = System.Drawing.Color.White;
            this.btnRoutes.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRoutes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRoutes.Image = ((System.Drawing.Image)(resources.GetObject("btnRoutes.Image")));
            this.btnRoutes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoutes.Location = new System.Drawing.Point(660, 83);
            this.btnRoutes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRoutes.Name = "btnRoutes";
            this.btnRoutes.Size = new System.Drawing.Size(320, 142);
            this.btnRoutes.TabIndex = 5;
            this.btnRoutes.Text = "Routes";
            this.btnRoutes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRoutes.UseVisualStyleBackColor = false;
            this.btnRoutes.Click += new System.EventHandler(this.btnRoutes_Click);
            // 
            // btnStops
            // 
            this.btnStops.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStops.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStops.BackColor = System.Drawing.Color.White;
            this.btnStops.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStops.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStops.Image = ((System.Drawing.Image)(resources.GetObject("btnStops.Image")));
            this.btnStops.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStops.Location = new System.Drawing.Point(12, 83);
            this.btnStops.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStops.Name = "btnStops";
            this.btnStops.Size = new System.Drawing.Size(313, 142);
            this.btnStops.TabIndex = 5;
            this.btnStops.Text = "Stops";
            this.btnStops.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStops.UseVisualStyleBackColor = false;
            this.btnStops.Click += new System.EventHandler(this.btnStops_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 754);
            this.Controls.Add(this.btnRoutes);
            this.Controls.Add(this.btnStops);
            this.Controls.Add(this.btnTrams);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Trams Krakow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsllVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsllDataBase;
        private System.Windows.Forms.Button btnTrams;
        private System.Windows.Forms.Button btnRoutes;
        private System.Windows.Forms.Button btnStops;
    }
}

