namespace Trams.GUI.Forms
{
    partial class RoutesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoutesForm));
            this.lblRoutesStatic = new System.Windows.Forms.Label();
            this.routesList = new System.Windows.Forms.ListBox();
            this.lblDetilsStatic = new System.Windows.Forms.Label();
            this.lblNameStatic = new System.Windows.Forms.Label();
            this.lblTimeStatic = new System.Windows.Forms.Label();
            this.lblFirstStopStatic = new System.Windows.Forms.Label();
            this.lblLastStopStatic = new System.Windows.Forms.Label();
            this.lblVehicleStatic = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblFirstStop = new System.Windows.Forms.Label();
            this.lblLastStop = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.cBoxFirstStop = new System.Windows.Forms.ComboBox();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblAddNewRouteStatic = new System.Windows.Forms.Label();
            this.lblNameInNewRouteStatic = new System.Windows.Forms.Label();
            this.lblFirstStopInNewRouteStatic = new System.Windows.Forms.Label();
            this.lblFLastStopInNewRouteStatic = new System.Windows.Forms.Label();
            this.cBoxLastStop = new System.Windows.Forms.ComboBox();
            this.lblVahicleInNewRouteStatic = new System.Windows.Forms.Label();
            this.cBoxVehicle = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblCostStatic = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddRoute = new System.Windows.Forms.Button();
            this.btnRemoveSelectedRoute = new System.Windows.Forms.Button();
            this.lblTimeInNewRoute = new System.Windows.Forms.Label();
            this.lblCostInNewRoute = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRoutesStatic
            // 
            this.lblRoutesStatic.AutoSize = true;
            this.lblRoutesStatic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoutesStatic.Location = new System.Drawing.Point(12, 9);
            this.lblRoutesStatic.Name = "lblRoutesStatic";
            this.lblRoutesStatic.Size = new System.Drawing.Size(119, 28);
            this.lblRoutesStatic.TabIndex = 0;
            this.lblRoutesStatic.Text = "YourRoutes";
            // 
            // routesList
            // 
            this.routesList.FormattingEnabled = true;
            this.routesList.ItemHeight = 20;
            this.routesList.Location = new System.Drawing.Point(12, 40);
            this.routesList.Name = "routesList";
            this.routesList.Size = new System.Drawing.Size(204, 404);
            this.routesList.TabIndex = 1;
            this.routesList.SelectedIndexChanged += new System.EventHandler(this.routesList_SelectedIndexChanged);
            // 
            // lblDetilsStatic
            // 
            this.lblDetilsStatic.AutoSize = true;
            this.lblDetilsStatic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDetilsStatic.Location = new System.Drawing.Point(240, 9);
            this.lblDetilsStatic.Name = "lblDetilsStatic";
            this.lblDetilsStatic.Size = new System.Drawing.Size(78, 28);
            this.lblDetilsStatic.TabIndex = 2;
            this.lblDetilsStatic.Text = "Detalis";
            // 
            // lblNameStatic
            // 
            this.lblNameStatic.AutoSize = true;
            this.lblNameStatic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameStatic.Location = new System.Drawing.Point(240, 54);
            this.lblNameStatic.Name = "lblNameStatic";
            this.lblNameStatic.Size = new System.Drawing.Size(51, 20);
            this.lblNameStatic.TabIndex = 3;
            this.lblNameStatic.Text = "Name";
            // 
            // lblTimeStatic
            // 
            this.lblTimeStatic.AutoSize = true;
            this.lblTimeStatic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimeStatic.Location = new System.Drawing.Point(240, 91);
            this.lblTimeStatic.Name = "lblTimeStatic";
            this.lblTimeStatic.Size = new System.Drawing.Size(44, 20);
            this.lblTimeStatic.TabIndex = 4;
            this.lblTimeStatic.Text = "Time";
            // 
            // lblFirstStopStatic
            // 
            this.lblFirstStopStatic.AutoSize = true;
            this.lblFirstStopStatic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstStopStatic.Location = new System.Drawing.Point(497, 54);
            this.lblFirstStopStatic.Name = "lblFirstStopStatic";
            this.lblFirstStopStatic.Size = new System.Drawing.Size(76, 20);
            this.lblFirstStopStatic.TabIndex = 5;
            this.lblFirstStopStatic.Text = "First Stop";
            // 
            // lblLastStopStatic
            // 
            this.lblLastStopStatic.AutoSize = true;
            this.lblLastStopStatic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastStopStatic.Location = new System.Drawing.Point(499, 91);
            this.lblLastStopStatic.Name = "lblLastStopStatic";
            this.lblLastStopStatic.Size = new System.Drawing.Size(74, 20);
            this.lblLastStopStatic.TabIndex = 6;
            this.lblLastStopStatic.Text = "Last Stop";
            // 
            // lblVehicleStatic
            // 
            this.lblVehicleStatic.AutoSize = true;
            this.lblVehicleStatic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVehicleStatic.Location = new System.Drawing.Point(240, 131);
            this.lblVehicleStatic.Name = "lblVehicleStatic";
            this.lblVehicleStatic.Size = new System.Drawing.Size(58, 20);
            this.lblVehicleStatic.TabIndex = 7;
            this.lblVehicleStatic.Text = "Vehicle";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(318, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 20);
            this.lblName.TabIndex = 8;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(318, 91);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 20);
            this.lblTime.TabIndex = 9;
            // 
            // lblFirstStop
            // 
            this.lblFirstStop.AutoSize = true;
            this.lblFirstStop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstStop.Location = new System.Drawing.Point(594, 54);
            this.lblFirstStop.Name = "lblFirstStop";
            this.lblFirstStop.Size = new System.Drawing.Size(0, 20);
            this.lblFirstStop.TabIndex = 10;
            // 
            // lblLastStop
            // 
            this.lblLastStop.AutoSize = true;
            this.lblLastStop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastStop.Location = new System.Drawing.Point(594, 91);
            this.lblLastStop.Name = "lblLastStop";
            this.lblLastStop.Size = new System.Drawing.Size(0, 20);
            this.lblLastStop.TabIndex = 11;
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVehicle.Location = new System.Drawing.Point(318, 131);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(0, 20);
            this.lblVehicle.TabIndex = 12;
            // 
            // cBoxFirstStop
            // 
            this.cBoxFirstStop.FormattingEnabled = true;
            this.cBoxFirstStop.Location = new System.Drawing.Point(374, 318);
            this.cBoxFirstStop.Name = "cBoxFirstStop";
            this.cBoxFirstStop.Size = new System.Drawing.Size(199, 28);
            this.cBoxFirstStop.TabIndex = 13;
            this.cBoxFirstStop.SelectedIndexChanged += new System.EventHandler(this.cBoxFirstStop_SelectedIndexChanged);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(240, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 10);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(240, 474);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(730, 10);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox3.Location = new System.Drawing.Point(240, 183);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 296);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox4.Location = new System.Drawing.Point(960, 225);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 254);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // lblAddNewRouteStatic
            // 
            this.lblAddNewRouteStatic.AutoSize = true;
            this.lblAddNewRouteStatic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddNewRouteStatic.Location = new System.Drawing.Point(256, 194);
            this.lblAddNewRouteStatic.Name = "lblAddNewRouteStatic";
            this.lblAddNewRouteStatic.Size = new System.Drawing.Size(152, 28);
            this.lblAddNewRouteStatic.TabIndex = 18;
            this.lblAddNewRouteStatic.Text = "Add new route";
            // 
            // lblNameInNewRouteStatic
            // 
            this.lblNameInNewRouteStatic.AutoSize = true;
            this.lblNameInNewRouteStatic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameInNewRouteStatic.Location = new System.Drawing.Point(297, 276);
            this.lblNameInNewRouteStatic.Name = "lblNameInNewRouteStatic";
            this.lblNameInNewRouteStatic.Size = new System.Drawing.Size(68, 28);
            this.lblNameInNewRouteStatic.TabIndex = 19;
            this.lblNameInNewRouteStatic.Text = "Name";
            // 
            // lblFirstStopInNewRouteStatic
            // 
            this.lblFirstStopInNewRouteStatic.AutoSize = true;
            this.lblFirstStopInNewRouteStatic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstStopInNewRouteStatic.Location = new System.Drawing.Point(263, 318);
            this.lblFirstStopInNewRouteStatic.Name = "lblFirstStopInNewRouteStatic";
            this.lblFirstStopInNewRouteStatic.Size = new System.Drawing.Size(102, 28);
            this.lblFirstStopInNewRouteStatic.TabIndex = 20;
            this.lblFirstStopInNewRouteStatic.Text = "First Stop";
            // 
            // lblFLastStopInNewRouteStatic
            // 
            this.lblFLastStopInNewRouteStatic.AutoSize = true;
            this.lblFLastStopInNewRouteStatic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFLastStopInNewRouteStatic.Location = new System.Drawing.Point(266, 357);
            this.lblFLastStopInNewRouteStatic.Name = "lblFLastStopInNewRouteStatic";
            this.lblFLastStopInNewRouteStatic.Size = new System.Drawing.Size(99, 28);
            this.lblFLastStopInNewRouteStatic.TabIndex = 21;
            this.lblFLastStopInNewRouteStatic.Text = "Last Stop";
            // 
            // cBoxLastStop
            // 
            this.cBoxLastStop.FormattingEnabled = true;
            this.cBoxLastStop.Location = new System.Drawing.Point(374, 357);
            this.cBoxLastStop.Name = "cBoxLastStop";
            this.cBoxLastStop.Size = new System.Drawing.Size(199, 28);
            this.cBoxLastStop.TabIndex = 22;
            this.cBoxLastStop.SelectedIndexChanged += new System.EventHandler(this.cBoxLastStop_SelectedIndexChanged);
            // 
            // lblVahicleInNewRouteStatic
            // 
            this.lblVahicleInNewRouteStatic.AutoSize = true;
            this.lblVahicleInNewRouteStatic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVahicleInNewRouteStatic.Location = new System.Drawing.Point(285, 403);
            this.lblVahicleInNewRouteStatic.Name = "lblVahicleInNewRouteStatic";
            this.lblVahicleInNewRouteStatic.Size = new System.Drawing.Size(80, 28);
            this.lblVahicleInNewRouteStatic.TabIndex = 23;
            this.lblVahicleInNewRouteStatic.Text = "Vehicle";
            // 
            // cBoxVehicle
            // 
            this.cBoxVehicle.FormattingEnabled = true;
            this.cBoxVehicle.Location = new System.Drawing.Point(374, 403);
            this.cBoxVehicle.Name = "cBoxVehicle";
            this.cBoxVehicle.Size = new System.Drawing.Size(199, 28);
            this.cBoxVehicle.TabIndex = 24;
            this.cBoxVehicle.SelectedIndexChanged += new System.EventHandler(this.cBoxVehicle_SelectedIndexChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(374, 277);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(199, 27);
            this.tbName.TabIndex = 26;
            // 
            // lblCostStatic
            // 
            this.lblCostStatic.AutoSize = true;
            this.lblCostStatic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostStatic.Location = new System.Drawing.Point(499, 131);
            this.lblCostStatic.Name = "lblCostStatic";
            this.lblCostStatic.Size = new System.Drawing.Size(40, 20);
            this.lblCostStatic.TabIndex = 27;
            this.lblCostStatic.Text = "Cost";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCost.Location = new System.Drawing.Point(594, 131);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(0, 20);
            this.lblCost.TabIndex = 28;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox5.Location = new System.Drawing.Point(414, 183);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 52);
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox6.Location = new System.Drawing.Point(240, 183);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(184, 10);
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(648, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 28);
            this.label6.TabIndex = 31;
            this.label6.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(654, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 28);
            this.label7.TabIndex = 32;
            this.label7.Text = "Cost";
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddRoute.Location = new System.Drawing.Point(653, 357);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(269, 74);
            this.btnAddRoute.TabIndex = 33;
            this.btnAddRoute.Text = "Add route";
            this.btnAddRoute.UseVisualStyleBackColor = true;
            this.btnAddRoute.Click += new System.EventHandler(this.btnAddRoute_Click);
            // 
            // btnRemoveSelectedRoute
            // 
            this.btnRemoveSelectedRoute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveSelectedRoute.Location = new System.Drawing.Point(12, 450);
            this.btnRemoveSelectedRoute.Name = "btnRemoveSelectedRoute";
            this.btnRemoveSelectedRoute.Size = new System.Drawing.Size(204, 36);
            this.btnRemoveSelectedRoute.TabIndex = 34;
            this.btnRemoveSelectedRoute.Text = "Remove Selected Route";
            this.btnRemoveSelectedRoute.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedRoute.Click += new System.EventHandler(this.btnRemoveSelectedRoute_Click);
            // 
            // lblTimeInNewRoute
            // 
            this.lblTimeInNewRoute.AutoSize = true;
            this.lblTimeInNewRoute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimeInNewRoute.Location = new System.Drawing.Point(720, 277);
            this.lblTimeInNewRoute.Name = "lblTimeInNewRoute";
            this.lblTimeInNewRoute.Size = new System.Drawing.Size(0, 28);
            this.lblTimeInNewRoute.TabIndex = 35;
            // 
            // lblCostInNewRoute
            // 
            this.lblCostInNewRoute.AutoSize = true;
            this.lblCostInNewRoute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostInNewRoute.Location = new System.Drawing.Point(720, 314);
            this.lblCostInNewRoute.Name = "lblCostInNewRoute";
            this.lblCostInNewRoute.Size = new System.Drawing.Size(0, 28);
            this.lblCostInNewRoute.TabIndex = 36;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(765, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(210, 207);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 37;
            this.pictureBox7.TabStop = false;
            // 
            // RoutesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 491);
            this.ControlBox = false;
            this.Controls.Add(this.lblCostInNewRoute);
            this.Controls.Add(this.lblTimeInNewRoute);
            this.Controls.Add(this.btnRemoveSelectedRoute);
            this.Controls.Add(this.btnAddRoute);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblCostStatic);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cBoxVehicle);
            this.Controls.Add(this.lblVahicleInNewRouteStatic);
            this.Controls.Add(this.cBoxLastStop);
            this.Controls.Add(this.lblFLastStopInNewRouteStatic);
            this.Controls.Add(this.lblFirstStopInNewRouteStatic);
            this.Controls.Add(this.lblNameInNewRouteStatic);
            this.Controls.Add(this.lblAddNewRouteStatic);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cBoxFirstStop);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.lblLastStop);
            this.Controls.Add(this.lblFirstStop);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblVehicleStatic);
            this.Controls.Add(this.lblLastStopStatic);
            this.Controls.Add(this.lblFirstStopStatic);
            this.Controls.Add(this.lblTimeStatic);
            this.Controls.Add(this.lblNameStatic);
            this.Controls.Add(this.lblDetilsStatic);
            this.Controls.Add(this.routesList);
            this.Controls.Add(this.lblRoutesStatic);
            this.Controls.Add(this.pictureBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "RoutesForm";
            this.Load += new System.EventHandler(this.RoutesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRoutesStatic;
        private ListBox routesList;
        private Label lblDetilsStatic;
        private Label lblNameStatic;
        private Label lblTimeStatic;
        private Label lblFirstStopStatic;
        private Label lblLastStopStatic;
        private Label lblVehicleStatic;
        private Label lblName;
        private Label lblTime;
        private Label lblFirstStop;
        private Label lblLastStop;
        private Label lblVehicle;
        private ComboBox cBoxFirstStop;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label lblAddNewRouteStatic;
        private Label lblNameInNewRouteStatic;
        private Label lblFirstStopInNewRouteStatic;
        private Label lblFLastStopInNewRouteStatic;
        private ComboBox cBoxLastStop;
        private Label lblVahicleInNewRouteStatic;
        private ComboBox cBoxVehicle;
        private TextBox tbName;
        private Label lblCostStatic;
        private Label lblCost;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label6;
        private Label label7;
        private Button btnAddRoute;
        private Button btnRemoveSelectedRoute;
        private Label lblTimeInNewRoute;
        private Label lblCostInNewRoute;
        private PictureBox pictureBox7;
    }
}