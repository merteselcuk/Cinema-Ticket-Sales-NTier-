namespace CinemaSeans.UI
{
    partial class FormSeanceUpdate
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblfinishhourminute = new System.Windows.Forms.Label();
            this.lblstarthourminute = new System.Windows.Forms.Label();
            this.cmbStartMinute = new System.Windows.Forms.ComboBox();
            this.cmbFinishMinute = new System.Windows.Forms.ComboBox();
            this.cmbFinishHour = new System.Windows.Forms.ComboBox();
            this.cmbStartHour = new System.Windows.Forms.ComboBox();
            this.lblMovie = new System.Windows.Forms.Label();
            this.cmbMovie = new System.Windows.Forms.ComboBox();
            this.lblSeanceUpdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(221, 158);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 28);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Değiştir";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Bitiş Saati:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Başlangıç Saati:";
            // 
            // lblfinishhourminute
            // 
            this.lblfinishhourminute.AutoSize = true;
            this.lblfinishhourminute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfinishhourminute.Location = new System.Drawing.Point(198, 119);
            this.lblfinishhourminute.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfinishhourminute.Name = "lblfinishhourminute";
            this.lblfinishhourminute.Size = new System.Drawing.Size(14, 20);
            this.lblfinishhourminute.TabIndex = 36;
            this.lblfinishhourminute.Text = ":";
            // 
            // lblstarthourminute
            // 
            this.lblstarthourminute.AutoSize = true;
            this.lblstarthourminute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblstarthourminute.Location = new System.Drawing.Point(198, 78);
            this.lblstarthourminute.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstarthourminute.Name = "lblstarthourminute";
            this.lblstarthourminute.Size = new System.Drawing.Size(14, 20);
            this.lblstarthourminute.TabIndex = 35;
            this.lblstarthourminute.Text = ":";
            // 
            // cmbStartMinute
            // 
            this.cmbStartMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartMinute.FormattingEnabled = true;
            this.cmbStartMinute.Items.AddRange(new object[] {
            "00",
            "5",
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
            this.cmbStartMinute.Location = new System.Drawing.Point(224, 78);
            this.cmbStartMinute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStartMinute.Name = "cmbStartMinute";
            this.cmbStartMinute.Size = new System.Drawing.Size(72, 21);
            this.cmbStartMinute.TabIndex = 34;
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
            this.cmbFinishMinute.Location = new System.Drawing.Point(224, 119);
            this.cmbFinishMinute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFinishMinute.Name = "cmbFinishMinute";
            this.cmbFinishMinute.Size = new System.Drawing.Size(72, 21);
            this.cmbFinishMinute.TabIndex = 33;
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
            "1",
            "2",
            "3"});
            this.cmbFinishHour.Location = new System.Drawing.Point(117, 119);
            this.cmbFinishHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFinishHour.Name = "cmbFinishHour";
            this.cmbFinishHour.Size = new System.Drawing.Size(71, 21);
            this.cmbFinishHour.TabIndex = 32;
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
            "1",
            "2",
            "3"});
            this.cmbStartHour.Location = new System.Drawing.Point(117, 78);
            this.cmbStartHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStartHour.Name = "cmbStartHour";
            this.cmbStartHour.Size = new System.Drawing.Size(71, 21);
            this.cmbStartHour.TabIndex = 31;
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Location = new System.Drawing.Point(20, 45);
            this.lblMovie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(28, 13);
            this.lblMovie.TabIndex = 38;
            this.lblMovie.Text = "Film:";
            // 
            // cmbMovie
            // 
            this.cmbMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovie.FormattingEnabled = true;
            this.cmbMovie.Location = new System.Drawing.Point(117, 39);
            this.cmbMovie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMovie.Name = "cmbMovie";
            this.cmbMovie.Size = new System.Drawing.Size(180, 21);
            this.cmbMovie.TabIndex = 37;
            // 
            // lblSeanceUpdate
            // 
            this.lblSeanceUpdate.AutoSize = true;
            this.lblSeanceUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeanceUpdate.Location = new System.Drawing.Point(115, 7);
            this.lblSeanceUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeanceUpdate.Name = "lblSeanceUpdate";
            this.lblSeanceUpdate.Size = new System.Drawing.Size(126, 18);
            this.lblSeanceUpdate.TabIndex = 39;
            this.lblSeanceUpdate.Text = "Seans Güncelle";
            // 
            // FormSeanceUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 193);
            this.Controls.Add(this.lblSeanceUpdate);
            this.Controls.Add(this.lblMovie);
            this.Controls.Add(this.cmbMovie);
            this.Controls.Add(this.lblfinishhourminute);
            this.Controls.Add(this.lblstarthourminute);
            this.Controls.Add(this.cmbStartMinute);
            this.Controls.Add(this.cmbFinishMinute);
            this.Controls.Add(this.cmbFinishHour);
            this.Controls.Add(this.cmbStartHour);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSeanceUpdate";
            this.Text = "Seans Güncelleme";
            this.Load += new System.EventHandler(this.FormSeansUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblfinishhourminute;
        private System.Windows.Forms.Label lblstarthourminute;
        private System.Windows.Forms.ComboBox cmbStartMinute;
        private System.Windows.Forms.ComboBox cmbFinishMinute;
        private System.Windows.Forms.ComboBox cmbFinishHour;
        private System.Windows.Forms.ComboBox cmbStartHour;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.ComboBox cmbMovie;
        private System.Windows.Forms.Label lblSeanceUpdate;
    }
}