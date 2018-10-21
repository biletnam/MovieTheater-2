namespace BookTicket
{
    partial class BookTicket
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnOrderBySchedule = new System.Windows.Forms.Button();
            this.btnOrderByMovie = new System.Windows.Forms.Button();
            this.btnLoadScreen = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMovie = new System.Windows.Forms.DataGridView();
            this.cIDMovie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameMovie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvScreen = new System.Windows.Forms.DataGridView();
            this.cIDLoadScreen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNextStep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(693, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(95, 33);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnOrderBySchedule
            // 
            this.btnOrderBySchedule.Location = new System.Drawing.Point(24, 96);
            this.btnOrderBySchedule.Name = "btnOrderBySchedule";
            this.btnOrderBySchedule.Size = new System.Drawing.Size(170, 23);
            this.btnOrderBySchedule.TabIndex = 1;
            this.btnOrderBySchedule.Text = "Order By Schedule";
            this.btnOrderBySchedule.UseVisualStyleBackColor = true;
            // 
            // btnOrderByMovie
            // 
            this.btnOrderByMovie.Location = new System.Drawing.Point(254, 96);
            this.btnOrderByMovie.Name = "btnOrderByMovie";
            this.btnOrderByMovie.Size = new System.Drawing.Size(361, 23);
            this.btnOrderByMovie.TabIndex = 2;
            this.btnOrderByMovie.Text = "Order By Movie";
            this.btnOrderByMovie.UseVisualStyleBackColor = true;
            // 
            // btnLoadScreen
            // 
            this.btnLoadScreen.Location = new System.Drawing.Point(638, 96);
            this.btnLoadScreen.Name = "btnLoadScreen";
            this.btnLoadScreen.Size = new System.Drawing.Size(150, 23);
            this.btnLoadScreen.TabIndex = 3;
            this.btnLoadScreen.Text = "Load Screen";
            this.btnLoadScreen.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(693, 42);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 33);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cTime});
            this.dgvSchedule.Location = new System.Drawing.Point(12, 131);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.Size = new System.Drawing.Size(197, 365);
            this.dgvSchedule.TabIndex = 5;
            // 
            // cID
            // 
            this.cID.HeaderText = "ID";
            this.cID.Name = "cID";
            this.cID.Width = 85;
            // 
            // cTime
            // 
            this.cTime.HeaderText = "Time";
            this.cTime.Name = "cTime";
            this.cTime.Width = 85;
            // 
            // dgvMovie
            // 
            this.dgvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDMovie,
            this.cNameMovie});
            this.dgvMovie.Location = new System.Drawing.Point(254, 131);
            this.dgvMovie.Name = "dgvMovie";
            this.dgvMovie.Size = new System.Drawing.Size(361, 365);
            this.dgvMovie.TabIndex = 6;
            // 
            // cIDMovie
            // 
            this.cIDMovie.HeaderText = "ID";
            this.cIDMovie.Name = "cIDMovie";
            this.cIDMovie.Width = 175;
            // 
            // cNameMovie
            // 
            this.cNameMovie.HeaderText = "Name";
            this.cNameMovie.Name = "cNameMovie";
            this.cNameMovie.Width = 175;
            // 
            // dgvScreen
            // 
            this.dgvScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScreen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDLoadScreen});
            this.dgvScreen.Location = new System.Drawing.Point(638, 131);
            this.dgvScreen.Name = "dgvScreen";
            this.dgvScreen.Size = new System.Drawing.Size(150, 365);
            this.dgvScreen.TabIndex = 7;
            // 
            // cIDLoadScreen
            // 
            this.cIDLoadScreen.HeaderText = "ID";
            this.cIDLoadScreen.Name = "cIDLoadScreen";
            // 
            // btnNextStep
            // 
            this.btnNextStep.Location = new System.Drawing.Point(12, 502);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(775, 23);
            this.btnNextStep.TabIndex = 8;
            this.btnNextStep.Text = "Next Step";
            this.btnNextStep.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 551);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.dgvScreen);
            this.Controls.Add(this.dgvMovie);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnLoadScreen);
            this.Controls.Add(this.btnOrderByMovie);
            this.Controls.Add(this.btnOrderBySchedule);
            this.Controls.Add(this.btnLogout);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnOrderBySchedule;
        private System.Windows.Forms.Button btnOrderByMovie;
        private System.Windows.Forms.Button btnLoadScreen;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTime;
        private System.Windows.Forms.DataGridView dgvMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameMovie;
        private System.Windows.Forms.DataGridView dgvScreen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDLoadScreen;
        private System.Windows.Forms.Button btnNextStep;
    }
}

