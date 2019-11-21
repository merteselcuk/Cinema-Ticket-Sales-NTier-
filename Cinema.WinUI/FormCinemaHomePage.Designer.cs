namespace CinemaSeans.UI
{
    partial class FormCinemaHomePage
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
            this.lstMovies = new System.Windows.Forms.ListBox();
            this.lblMovies = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbCast = new System.Windows.Forms.ComboBox();
            this.cmbDirector = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCast = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstMovies
            // 
            this.lstMovies.FormattingEnabled = true;
            this.lstMovies.Location = new System.Drawing.Point(39, 43);
            this.lstMovies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstMovies.Name = "lstMovies";
            this.lstMovies.Size = new System.Drawing.Size(207, 342);
            this.lstMovies.TabIndex = 0;
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.Location = new System.Drawing.Point(37, 15);
            this.lblMovies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(36, 13);
            this.lblMovies.TabIndex = 1;
            this.lblMovies.Text = "Filmler";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(163, 13);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Film Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(256, 43);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(116, 21);
            this.cmbType.TabIndex = 3;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // cmbCast
            // 
            this.cmbCast.FormattingEnabled = true;
            this.cmbCast.Location = new System.Drawing.Point(386, 43);
            this.cmbCast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCast.Name = "cmbCast";
            this.cmbCast.Size = new System.Drawing.Size(116, 21);
            this.cmbCast.TabIndex = 4;
            this.cmbCast.SelectedIndexChanged += new System.EventHandler(this.cmbCast_SelectedIndexChanged);
            // 
            // cmbDirector
            // 
            this.cmbDirector.FormattingEnabled = true;
            this.cmbDirector.Location = new System.Drawing.Point(530, 43);
            this.cmbDirector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDirector.Name = "cmbDirector";
            this.cmbDirector.Size = new System.Drawing.Size(116, 21);
            this.cmbDirector.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(288, 19);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(55, 13);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Türe Göre";
            // 
            // lblCast
            // 
            this.lblCast.AutoSize = true;
            this.lblCast.Location = new System.Drawing.Point(408, 19);
            this.lblCast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCast.Name = "lblCast";
            this.lblCast.Size = new System.Drawing.Size(81, 13);
            this.lblCast.TabIndex = 7;
            this.lblCast.Text = "Oyuncuya Göre";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(550, 19);
            this.lblDirector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(87, 13);
            this.lblDirector.TabIndex = 8;
            this.lblDirector.Text = "Yönetmene Göre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(430, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Film Detayları";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Boş Seanslar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 357);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(348, 173);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // FormCinemaHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 398);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblCast);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbDirector);
            this.Controls.Add(this.cmbCast);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblMovies);
            this.Controls.Add(this.lstMovies);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCinemaHomePage";
            this.Text = "FormCinemaHomePage";
            this.Load += new System.EventHandler(this.FormCinemaHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMovies;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbCast;
        private System.Windows.Forms.ComboBox cmbDirector;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCast;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}