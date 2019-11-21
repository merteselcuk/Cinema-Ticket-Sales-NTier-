namespace Cinema.WinUI
{
    partial class FormSessionUpdate
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
            this.lblShowDate = new System.Windows.Forms.Label();
            this.dtpShowDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblSeance = new System.Windows.Forms.Label();
            this.lblTheater = new System.Windows.Forms.Label();
            this.lblMovie = new System.Windows.Forms.Label();
            this.cmbTheater = new System.Windows.Forms.ComboBox();
            this.cmbSeance = new System.Windows.Forms.ComboBox();
            this.cmbMovie = new System.Windows.Forms.ComboBox();
            this.lblSessionUpdate = new System.Windows.Forms.Label();
            this.chbIsActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblShowDate
            // 
            this.lblShowDate.AutoSize = true;
            this.lblShowDate.Location = new System.Drawing.Point(23, 284);
            this.lblShowDate.Name = "lblShowDate";
            this.lblShowDate.Size = new System.Drawing.Size(45, 17);
            this.lblShowDate.TabIndex = 19;
            this.lblShowDate.Text = "Tarih:";
            // 
            // dtpShowDate
            // 
            this.dtpShowDate.CustomFormat = "yyyy/MM/dd";
            this.dtpShowDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpShowDate.Location = new System.Drawing.Point(97, 284);
            this.dtpShowDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpShowDate.Name = "dtpShowDate";
            this.dtpShowDate.Size = new System.Drawing.Size(209, 22);
            this.dtpShowDate.TabIndex = 18;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(224, 327);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 30);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblSeance
            // 
            this.lblSeance.AutoSize = true;
            this.lblSeance.Location = new System.Drawing.Point(23, 224);
            this.lblSeance.Name = "lblSeance";
            this.lblSeance.Size = new System.Drawing.Size(52, 17);
            this.lblSeance.TabIndex = 16;
            this.lblSeance.Text = "Seans:";
            // 
            // lblTheater
            // 
            this.lblTheater.AutoSize = true;
            this.lblTheater.Location = new System.Drawing.Point(27, 161);
            this.lblTheater.Name = "lblTheater";
            this.lblTheater.Size = new System.Drawing.Size(48, 17);
            this.lblTheater.TabIndex = 15;
            this.lblTheater.Text = "Salon:";
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Location = new System.Drawing.Point(35, 94);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(37, 17);
            this.lblMovie.TabIndex = 14;
            this.lblMovie.Text = "Film:";
            // 
            // cmbTheater
            // 
            this.cmbTheater.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTheater.FormattingEnabled = true;
            this.cmbTheater.Location = new System.Drawing.Point(97, 158);
            this.cmbTheater.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTheater.Name = "cmbTheater";
            this.cmbTheater.Size = new System.Drawing.Size(209, 24);
            this.cmbTheater.TabIndex = 13;
            // 
            // cmbSeance
            // 
            this.cmbSeance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeance.FormattingEnabled = true;
            this.cmbSeance.Location = new System.Drawing.Point(97, 224);
            this.cmbSeance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSeance.Name = "cmbSeance";
            this.cmbSeance.Size = new System.Drawing.Size(209, 24);
            this.cmbSeance.TabIndex = 12;
            // 
            // cmbMovie
            // 
            this.cmbMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovie.FormattingEnabled = true;
            this.cmbMovie.Location = new System.Drawing.Point(97, 94);
            this.cmbMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMovie.Name = "cmbMovie";
            this.cmbMovie.Size = new System.Drawing.Size(209, 24);
            this.cmbMovie.TabIndex = 11;
            this.cmbMovie.SelectedIndexChanged += new System.EventHandler(this.cmbMovie_SelectedIndexChanged);
            // 
            // lblSessionUpdate
            // 
            this.lblSessionUpdate.AutoSize = true;
            this.lblSessionUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSessionUpdate.Location = new System.Drawing.Point(92, 31);
            this.lblSessionUpdate.Name = "lblSessionUpdate";
            this.lblSessionUpdate.Size = new System.Drawing.Size(209, 29);
            this.lblSessionUpdate.TabIndex = 10;
            this.lblSessionUpdate.Text = "Oturum Güncelle";
            // 
            // chbIsActive
            // 
            this.chbIsActive.AutoSize = true;
            this.chbIsActive.Location = new System.Drawing.Point(26, 336);
            this.chbIsActive.Name = "chbIsActive";
            this.chbIsActive.Size = new System.Drawing.Size(98, 21);
            this.chbIsActive.TabIndex = 20;
            this.chbIsActive.Text = "checkBox1";
            this.chbIsActive.UseVisualStyleBackColor = true;
            // 
            // FormSessionUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 391);
            this.Controls.Add(this.chbIsActive);
            this.Controls.Add(this.lblShowDate);
            this.Controls.Add(this.dtpShowDate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblSeance);
            this.Controls.Add(this.lblTheater);
            this.Controls.Add(this.lblMovie);
            this.Controls.Add(this.cmbTheater);
            this.Controls.Add(this.cmbSeance);
            this.Controls.Add(this.cmbMovie);
            this.Controls.Add(this.lblSessionUpdate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSessionUpdate";
            this.Text = "Oturum Güncelle";
            this.Load += new System.EventHandler(this.FormSessionUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowDate;
        private System.Windows.Forms.DateTimePicker dtpShowDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblSeance;
        private System.Windows.Forms.Label lblTheater;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.ComboBox cmbTheater;
        private System.Windows.Forms.ComboBox cmbSeance;
        private System.Windows.Forms.ComboBox cmbMovie;
        private System.Windows.Forms.Label lblSessionUpdate;
        private System.Windows.Forms.CheckBox chbIsActive;
    }
}