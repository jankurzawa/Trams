namespace Trams.GUI.Forms
{
    partial class TramForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TramForm));
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblNameStatic = new System.Windows.Forms.Label();
            this.lblTypeStatic = new System.Windows.Forms.Label();
            this.lblRouteStatic = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTramsStatic = new System.Windows.Forms.Label();
            this.lblStopsStatic = new System.Windows.Forms.Label();
            this.vehiclesList = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRoute = new System.Windows.Forms.Label();
            this.stopList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInformation.Location = new System.Drawing.Point(610, 9);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(197, 25);
            this.lblInformation.TabIndex = 1;
            this.lblInformation.Text = "Vehicle Information";
            // 
            // lblNameStatic
            // 
            this.lblNameStatic.AutoSize = true;
            this.lblNameStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameStatic.Location = new System.Drawing.Point(529, 65);
            this.lblNameStatic.Name = "lblNameStatic";
            this.lblNameStatic.Size = new System.Drawing.Size(75, 25);
            this.lblNameStatic.TabIndex = 2;
            this.lblNameStatic.Text = "Name:";
            // 
            // lblTypeStatic
            // 
            this.lblTypeStatic.AutoSize = true;
            this.lblTypeStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTypeStatic.Location = new System.Drawing.Point(536, 112);
            this.lblTypeStatic.Name = "lblTypeStatic";
            this.lblTypeStatic.Size = new System.Drawing.Size(68, 25);
            this.lblTypeStatic.TabIndex = 5;
            this.lblTypeStatic.Text = "Type:";
            // 
            // lblRouteStatic
            // 
            this.lblRouteStatic.AutoSize = true;
            this.lblRouteStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRouteStatic.Location = new System.Drawing.Point(528, 160);
            this.lblRouteStatic.Name = "lblRouteStatic";
            this.lblRouteStatic.Size = new System.Drawing.Size(75, 25);
            this.lblRouteStatic.TabIndex = 6;
            this.lblRouteStatic.Text = "Route:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(539, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 230);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblTramsStatic
            // 
            this.lblTramsStatic.AutoSize = true;
            this.lblTramsStatic.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTramsStatic.Location = new System.Drawing.Point(12, 9);
            this.lblTramsStatic.Name = "lblTramsStatic";
            this.lblTramsStatic.Size = new System.Drawing.Size(82, 25);
            this.lblTramsStatic.TabIndex = 9;
            this.lblTramsStatic.Text = "Vehicles";
            // 
            // lblStopsStatic
            // 
            this.lblStopsStatic.AutoSize = true;
            this.lblStopsStatic.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStopsStatic.Location = new System.Drawing.Point(276, 9);
            this.lblStopsStatic.Name = "lblStopsStatic";
            this.lblStopsStatic.Size = new System.Drawing.Size(62, 25);
            this.lblStopsStatic.TabIndex = 10;
            this.lblStopsStatic.Text = "Stops";
            // 
            // vehiclesList
            // 
            this.vehiclesList.FormattingEnabled = true;
            this.vehiclesList.ItemHeight = 20;
            this.vehiclesList.Location = new System.Drawing.Point(12, 37);
            this.vehiclesList.Name = "vehiclesList";
            this.vehiclesList.Size = new System.Drawing.Size(214, 444);
            this.vehiclesList.TabIndex = 11;
            this.vehiclesList.SelectedIndexChanged += new System.EventHandler(this.vehiclesList_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(610, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 25);
            this.lblName.TabIndex = 12;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblType.Location = new System.Drawing.Point(610, 112);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 25);
            this.lblType.TabIndex = 13;
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoute.Location = new System.Drawing.Point(610, 160);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(0, 25);
            this.lblRoute.TabIndex = 14;
            this.lblRoute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stopList
            // 
            this.stopList.FormattingEnabled = true;
            this.stopList.ItemHeight = 20;
            this.stopList.Location = new System.Drawing.Point(276, 37);
            this.stopList.Name = "stopList";
            this.stopList.Size = new System.Drawing.Size(214, 444);
            this.stopList.TabIndex = 15;
            // 
            // TramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 491);
            this.Controls.Add(this.stopList);
            this.Controls.Add(this.lblRoute);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.vehiclesList);
            this.Controls.Add(this.lblStopsStatic);
            this.Controls.Add(this.lblTramsStatic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRouteStatic);
            this.Controls.Add(this.lblTypeStatic);
            this.Controls.Add(this.lblNameStatic);
            this.Controls.Add(this.lblInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TramForm";
            this.Text = "TramForm";
            this.Load += new System.EventHandler(this.TramForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblInformation;
        private Label lblNameStatic;
        private Label lblTypeStatic;
        private Label lblRouteStatic;
        private PictureBox pictureBox1;
        private Label lblTramsStatic;
        private Label lblStopsStatic;
        private ListBox vehiclesList;
        private Label lblName;
        private Label lblType;
        private Label lblRoute;
        private ListBox stopList;
    }
}