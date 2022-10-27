namespace Trams.GUI.Forms
{
    partial class StopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopForm));
            this.StopList = new System.Windows.Forms.ListBox();
            this.textBoxToWriteComment = new System.Windows.Forms.TextBox();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.lblDeparturesStatic = new System.Windows.Forms.Label();
            this.lblDescriptionStatic = new System.Windows.Forms.Label();
            this.lblCommentsStatic = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.departuresList = new System.Windows.Forms.ListBox();
            this.CommentsList = new System.Windows.Forms.ListBox();
            this.vehiclesList = new System.Windows.Forms.ListBox();
            this.lblVehicles = new System.Windows.Forms.Label();
            this.lblStopsStatic = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StopList
            // 
            this.StopList.FormattingEnabled = true;
            this.StopList.ItemHeight = 20;
            this.StopList.Location = new System.Drawing.Point(12, 38);
            this.StopList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StopList.Name = "StopList";
            this.StopList.Size = new System.Drawing.Size(186, 444);
            this.StopList.TabIndex = 0;
            this.StopList.SelectedIndexChanged += new System.EventHandler(this.StopList_SelectedIndexChanged);
            // 
            // textBoxToWriteComment
            // 
            this.textBoxToWriteComment.Location = new System.Drawing.Point(222, 455);
            this.textBoxToWriteComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxToWriteComment.Name = "textBoxToWriteComment";
            this.textBoxToWriteComment.Size = new System.Drawing.Size(595, 27);
            this.textBoxToWriteComment.TabIndex = 7;
            this.textBoxToWriteComment.Text = "Write comment";
            this.textBoxToWriteComment.Click += new System.EventHandler(this.TextBoxToWriteComment_Click);
            // 
            // btnAddComment
            // 
            this.btnAddComment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddComment.Location = new System.Drawing.Point(832, 455);
            this.btnAddComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(120, 27);
            this.btnAddComment.TabIndex = 8;
            this.btnAddComment.Text = "Add Comment";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // lblDeparturesStatic
            // 
            this.lblDeparturesStatic.AutoSize = true;
            this.lblDeparturesStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeparturesStatic.Location = new System.Drawing.Point(536, 11);
            this.lblDeparturesStatic.Name = "lblDeparturesStatic";
            this.lblDeparturesStatic.Size = new System.Drawing.Size(108, 25);
            this.lblDeparturesStatic.TabIndex = 9;
            this.lblDeparturesStatic.Text = "Departures";
            // 
            // lblDescriptionStatic
            // 
            this.lblDescriptionStatic.AutoSize = true;
            this.lblDescriptionStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescriptionStatic.Location = new System.Drawing.Point(223, 218);
            this.lblDescriptionStatic.Name = "lblDescriptionStatic";
            this.lblDescriptionStatic.Size = new System.Drawing.Size(109, 25);
            this.lblDescriptionStatic.TabIndex = 10;
            this.lblDescriptionStatic.Text = "Description";
            // 
            // lblCommentsStatic
            // 
            this.lblCommentsStatic.AutoSize = true;
            this.lblCommentsStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCommentsStatic.Location = new System.Drawing.Point(222, 303);
            this.lblCommentsStatic.Name = "lblCommentsStatic";
            this.lblCommentsStatic.Size = new System.Drawing.Size(107, 25);
            this.lblCommentsStatic.TabIndex = 11;
            this.lblCommentsStatic.Text = "Comments";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(223, 253);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 20);
            this.lblDescription.TabIndex = 13;
            // 
            // departuresList
            // 
            this.departuresList.FormattingEnabled = true;
            this.departuresList.ItemHeight = 20;
            this.departuresList.Location = new System.Drawing.Point(536, 39);
            this.departuresList.Name = "departuresList";
            this.departuresList.Size = new System.Drawing.Size(286, 164);
            this.departuresList.TabIndex = 14;
            // 
            // CommentsList
            // 
            this.CommentsList.FormattingEnabled = true;
            this.CommentsList.ItemHeight = 20;
            this.CommentsList.Location = new System.Drawing.Point(223, 331);
            this.CommentsList.Name = "CommentsList";
            this.CommentsList.Size = new System.Drawing.Size(594, 104);
            this.CommentsList.TabIndex = 15;
            // 
            // vehiclesList
            // 
            this.vehiclesList.FormattingEnabled = true;
            this.vehiclesList.ItemHeight = 20;
            this.vehiclesList.Location = new System.Drawing.Point(222, 39);
            this.vehiclesList.Name = "vehiclesList";
            this.vehiclesList.Size = new System.Drawing.Size(286, 164);
            this.vehiclesList.TabIndex = 16;
            // 
            // lblVehicles
            // 
            this.lblVehicles.AutoSize = true;
            this.lblVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVehicles.Location = new System.Drawing.Point(222, 11);
            this.lblVehicles.Name = "lblVehicles";
            this.lblVehicles.Size = new System.Drawing.Size(87, 25);
            this.lblVehicles.TabIndex = 17;
            this.lblVehicles.Text = "Vehicles";
            // 
            // lblStopsStatic
            // 
            this.lblStopsStatic.AutoSize = true;
            this.lblStopsStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStopsStatic.Location = new System.Drawing.Point(12, 11);
            this.lblStopsStatic.Name = "lblStopsStatic";
            this.lblStopsStatic.Size = new System.Drawing.Size(63, 25);
            this.lblStopsStatic.TabIndex = 19;
            this.lblStopsStatic.Text = "Stops";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(875, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // StopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 491);
            this.Controls.Add(this.lblStopsStatic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblVehicles);
            this.Controls.Add(this.vehiclesList);
            this.Controls.Add(this.CommentsList);
            this.Controls.Add(this.departuresList);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCommentsStatic);
            this.Controls.Add(this.lblDescriptionStatic);
            this.Controls.Add(this.lblDeparturesStatic);
            this.Controls.Add(this.btnAddComment);
            this.Controls.Add(this.textBoxToWriteComment);
            this.Controls.Add(this.StopList);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StopForm";
            this.Text = "StopsForm";
            this.Load += new System.EventHandler(this.StopsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox StopList;
        private System.Windows.Forms.TextBox textBoxToWriteComment;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Label lblDeparturesStatic;
        private System.Windows.Forms.Label lblDescriptionStatic;
        private System.Windows.Forms.Label lblCommentsStatic;
        private System.Windows.Forms.Label lblDescription;
        private ListBox departuresList;
        private ListBox CommentsList;
        private ListBox vehiclesList;
        private Label lblVehicles;
        private Label lblStopsStatic;
        private PictureBox pictureBox1;
    }
}