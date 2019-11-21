namespace CinemaSeans.UI
{
    partial class FormSeanceAdd
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
            this.lblSeanceAdd = new System.Windows.Forms.Label();
            this.lblstartTime = new System.Windows.Forms.Label();
            this.lblFinishTime = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblfinishhourminute = new System.Windows.Forms.Label();
            this.lblstarthourminute = new System.Windows.Forms.Label();
            this.cmbStartMinute = new System.Windows.Forms.ComboBox();
            this.cmbFinishMinute = new System.Windows.Forms.ComboBox();
            this.cmbFinishHour = new System.Windows.Forms.ComboBox();
            this.cmbStartHour = new System.Windows.Forms.ComboBox();
            this.lblMovie = new System.Windows.Forms.Label();
            this.cmbMovie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblSeanceAdd
            // 
            this.lblSeanceAdd.AutoSize = true;
            this.lblSeanceAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeanceAdd.Location = new System.Drawing.Point(109, 7);
            this.lblSeanceAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeanceAdd.Name = "lblSeanceAdd";
            this.lblSeanceAdd.Size = new System.Drawing.Size(83, 18);
            this.lblSeanceAdd.TabIndex = 1;
            this.lblSeanceAdd.Text = "Seans Ekle";
            // 
            // lblstartTime
            // 
            this.lblstartTime.AutoSize = true;
            this.lblstartTime.Location = new System.Drawing.Point(9, 86);
            this.lblstartTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstartTime.Name = "lblstartTime";
            this.lblstartTime.Size = new System.Drawing.Size(83, 13);
            this.lblstartTime.TabIndex = 3;
            this.lblstartTime.Text = "Başlangıç Saati:";
            // 
            // lblFinishTime
            // 
            this.lblFinishTime.AutoSize = true;
            this.lblFinishTime.Location = new System.Drawing.Point(9, 127);
            this.lblFinishTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinishTime.Name = "lblFinishTime";
            this.lblFinishTime.Size = new System.Drawing.Size(56, 13);
            this.lblFinishTime.TabIndex = 5;
            this.lblFinishTime.Text = "Bitiş Saati:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(216, 164);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 28);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblfinishhourminute
            // 
            this.lblfinishhourminute.AutoSize = true;
            this.lblfinishhourminute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfinishhourminute.Location = new System.Drawing.Point(193, 120);
            this.lblfinishhourminute.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfinishhourminute.Name = "lblfinishhourminute";
            this.lblfinishhourminute.Size = new System.Drawing.Size(14, 20);
            this.lblfinishhourminute.TabIndex = 21;
            this.lblfinishhourminute.Text = ":";
            // 
            // lblstarthourminute
            // 
            this.lblstarthourminute.AutoSize = true;
            this.lblstarthourminute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblstarthourminute.Location = new System.Drawing.Point(193, 80);
            this.lblstarthourminute.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstarthourminute.Name = "lblstarthourminute";
            this.lblstarthourminute.Size = new System.Drawing.Size(14, 20);
            this.lblstarthourminute.TabIndex = 20;
            this.lblstarthourminute.Text = ":";
            // 
            // cmbStartMinute
            // 
            this.cmbStartMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartMinute.FormattingEnabled = true;
            this.cmbStartMinute.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.cmbStartMinute.Location = new System.Drawing.Point(219, 80);
            this.cmbStartMinute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStartMinute.Name = "cmbStartMinute";
            this.cmbStartMinute.Size = new System.Drawing.Size(72, 21);
            this.cmbStartMinute.TabIndex = 19;
            // 
            // cmbFinishMinute
            // 
            this.cmbFinishMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinishMinute.FormattingEnabled = true;
            this.cmbFinishMinute.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.cmbFinishMinute.Location = new System.Drawing.Point(219, 121);
            this.cmbFinishMinute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFinishMinute.Name = "cmbFinishMinute";
            this.cmbFinishMinute.Size = new System.Drawing.Size(72, 21);
            this.cmbFinishMinute.TabIndex = 18;
            // 
            // cmbFinishHour
            // 
            this.cmbFinishHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinishHour.FormattingEnabled = true;
            this.cmbFinishHour.Items.AddRange(new object[] {
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "00",
            "01",
            "02",
            "03"});
            this.cmbFinishHour.Location = new System.Drawing.Point(112, 120);
            this.cmbFinishHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFinishHour.Name = "cmbFinishHour";
            this.cmbFinishHour.Size = new System.Drawing.Size(71, 21);
            this.cmbFinishHour.TabIndex = 17;
            // 
            // cmbStartHour
            // 
            this.cmbStartHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartHour.FormattingEnabled = true;
            this.cmbStartHour.Items.AddRange(new object[] {
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "00",
            "01",
            "02",
            "03"});
            this.cmbStartHour.Location = new System.Drawing.Point(112, 80);
            this.cmbStartHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStartHour.Name = "cmbStartHour";
            this.cmbStartHour.Size = new System.Drawing.Size(71, 21);
            this.cmbStartHour.TabIndex = 16;
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Location = new System.Drawing.Point(9, 49);
            this.lblMovie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(28, 13);
            this.lblMovie.TabIndex = 23;
            this.lblMovie.Text = "Film:";
            // 
            // cmbMovie
            // 
            this.cmbMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovie.FormattingEnabled = true;
            this.cmbMovie.Location = new System.Drawing.Point(112, 43);
            this.cmbMovie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMovie.Name = "cmbMovie";
            this.cmbMovie.Size = new System.Drawing.Size(180, 21);
            this.cmbMovie.TabIndex = 22;
            // 
            // FormSeanceAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 210);
            this.Controls.Add(this.lblMovie);
            this.Controls.Add(this.cmbMovie);
            this.Controls.Add(this.lblfinishhourminute);
            this.Controls.Add(this.lblstarthourminute);
            this.Controls.Add(this.cmbStartMinute);
            this.Controls.Add(this.cmbFinishMinute);
            this.Controls.Add(this.cmbFinishHour);
            this.Controls.Add(this.cmbStartHour);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblFinishTime);
            this.Controls.Add(this.lblstartTime);
            this.Controls.Add(this.lblSeanceAdd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSeanceAdd";
            this.Text = "Seans Ekleme";
            this.Load += new System.EventHandler(this.FormSeansMovieAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeanceAdd;
        private System.Windows.Forms.Label lblstartTime;
        private System.Windows.Forms.Label lblFinishTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblfinishhourminute;
        private System.Windows.Forms.Label lblstarthourminute;
        private System.Windows.Forms.ComboBox cmbStartMinute;
        private System.Windows.Forms.ComboBox cmbFinishMinute;
        private System.Windows.Forms.ComboBox cmbFinishHour;
        private System.Windows.Forms.ComboBox cmbStartHour;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.ComboBox cmbMovie;
    }
}