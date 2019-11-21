namespace Cinema.WinUI
{
    partial class FormMovieUpdate
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
            this.lblDirectorAdd = new System.Windows.Forms.Label();
            this.lblCastAdd = new System.Windows.Forms.Label();
            this.lstAllDirectors = new System.Windows.Forms.ListBox();
            this.lstAllCasts = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chb3D = new System.Windows.Forms.CheckBox();
            this.nudMovieTime = new System.Windows.Forms.NumericUpDown();
            this.cmbMovieType = new System.Windows.Forms.ComboBox();
            this.lblMovieYear = new System.Windows.Forms.Label();
            this.lblMovieTime = new System.Windows.Forms.Label();
            this.lblMovieType = new System.Windows.Forms.Label();
            this.txtMovieYear = new System.Windows.Forms.TextBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lstMovieCasts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMovieDirectors = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCastAdd = new System.Windows.Forms.Button();
            this.btnDirectorAdd = new System.Windows.Forms.Button();
            this.btnRemoveCast = new System.Windows.Forms.Button();
            this.btnRemoveDirector = new System.Windows.Forms.Button();
            this.chbIsActive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMovieTime)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDirectorAdd
            // 
            this.lblDirectorAdd.AutoSize = true;
            this.lblDirectorAdd.Location = new System.Drawing.Point(324, 209);
            this.lblDirectorAdd.Name = "lblDirectorAdd";
            this.lblDirectorAdd.Size = new System.Drawing.Size(90, 13);
            this.lblDirectorAdd.TabIndex = 37;
            this.lblDirectorAdd.Text = "Tüm Yönetmenler";
            // 
            // lblCastAdd
            // 
            this.lblCastAdd.AutoSize = true;
            this.lblCastAdd.Location = new System.Drawing.Point(324, 51);
            this.lblCastAdd.Name = "lblCastAdd";
            this.lblCastAdd.Size = new System.Drawing.Size(79, 13);
            this.lblCastAdd.TabIndex = 38;
            this.lblCastAdd.Text = "Tüm Oyuncular";
            // 
            // lstAllDirectors
            // 
            this.lstAllDirectors.FormattingEnabled = true;
            this.lstAllDirectors.Location = new System.Drawing.Point(327, 232);
            this.lstAllDirectors.Margin = new System.Windows.Forms.Padding(2);
            this.lstAllDirectors.MultiColumn = true;
            this.lstAllDirectors.Name = "lstAllDirectors";
            this.lstAllDirectors.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstAllDirectors.Size = new System.Drawing.Size(203, 95);
            this.lstAllDirectors.TabIndex = 35;
            // 
            // lstAllCasts
            // 
            this.lstAllCasts.FormattingEnabled = true;
            this.lstAllCasts.Location = new System.Drawing.Point(327, 74);
            this.lstAllCasts.Margin = new System.Windows.Forms.Padding(2);
            this.lstAllCasts.MultiColumn = true;
            this.lstAllCasts.Name = "lstAllCasts";
            this.lstAllCasts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstAllCasts.Size = new System.Drawing.Size(203, 95);
            this.lstAllCasts.TabIndex = 36;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(711, 373);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 30);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Guncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // chb3D
            // 
            this.chb3D.AutoSize = true;
            this.chb3D.Location = new System.Drawing.Point(48, 310);
            this.chb3D.Margin = new System.Windows.Forms.Padding(2);
            this.chb3D.Name = "chb3D";
            this.chb3D.Size = new System.Drawing.Size(40, 17);
            this.chb3D.TabIndex = 33;
            this.chb3D.Text = "3D";
            this.chb3D.UseVisualStyleBackColor = true;
            // 
            // nudMovieTime
            // 
            this.nudMovieTime.Location = new System.Drawing.Point(123, 190);
            this.nudMovieTime.Margin = new System.Windows.Forms.Padding(2);
            this.nudMovieTime.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudMovieTime.Name = "nudMovieTime";
            this.nudMovieTime.Size = new System.Drawing.Size(157, 20);
            this.nudMovieTime.TabIndex = 32;
            // 
            // cmbMovieType
            // 
            this.cmbMovieType.FormattingEnabled = true;
            this.cmbMovieType.Location = new System.Drawing.Point(123, 131);
            this.cmbMovieType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMovieType.Name = "cmbMovieType";
            this.cmbMovieType.Size = new System.Drawing.Size(158, 21);
            this.cmbMovieType.TabIndex = 31;
            // 
            // lblMovieYear
            // 
            this.lblMovieYear.AutoSize = true;
            this.lblMovieYear.Location = new System.Drawing.Point(45, 252);
            this.lblMovieYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieYear.Name = "lblMovieYear";
            this.lblMovieYear.Size = new System.Drawing.Size(41, 13);
            this.lblMovieYear.TabIndex = 30;
            this.lblMovieYear.Text = "Film Yılı";
            // 
            // lblMovieTime
            // 
            this.lblMovieTime.AutoSize = true;
            this.lblMovieTime.Location = new System.Drawing.Point(45, 191);
            this.lblMovieTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieTime.Name = "lblMovieTime";
            this.lblMovieTime.Size = new System.Drawing.Size(57, 13);
            this.lblMovieTime.TabIndex = 29;
            this.lblMovieTime.Text = "Film Süresi";
            // 
            // lblMovieType
            // 
            this.lblMovieType.AutoSize = true;
            this.lblMovieType.Location = new System.Drawing.Point(45, 134);
            this.lblMovieType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieType.Name = "lblMovieType";
            this.lblMovieType.Size = new System.Drawing.Size(50, 13);
            this.lblMovieType.TabIndex = 28;
            this.lblMovieType.Text = "Film Türü";
            // 
            // txtMovieYear
            // 
            this.txtMovieYear.Location = new System.Drawing.Point(123, 249);
            this.txtMovieYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtMovieYear.Name = "txtMovieYear";
            this.txtMovieYear.Size = new System.Drawing.Size(158, 20);
            this.txtMovieYear.TabIndex = 26;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(123, 71);
            this.txtMovieName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMovieName.MaxLength = 30;
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(158, 20);
            this.txtMovieName.TabIndex = 27;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(45, 74);
            this.lblMovieName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(43, 13);
            this.lblMovieName.TabIndex = 25;
            this.lblMovieName.Text = "Film Adı";
            // 
            // lstMovieCasts
            // 
            this.lstMovieCasts.FormattingEnabled = true;
            this.lstMovieCasts.Location = new System.Drawing.Point(651, 74);
            this.lstMovieCasts.Margin = new System.Windows.Forms.Padding(2);
            this.lstMovieCasts.MultiColumn = true;
            this.lstMovieCasts.Name = "lstMovieCasts";
            this.lstMovieCasts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstMovieCasts.Size = new System.Drawing.Size(203, 95);
            this.lstMovieCasts.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Film Oyuncuları";
            // 
            // lstMovieDirectors
            // 
            this.lstMovieDirectors.FormattingEnabled = true;
            this.lstMovieDirectors.Location = new System.Drawing.Point(651, 232);
            this.lstMovieDirectors.Margin = new System.Windows.Forms.Padding(2);
            this.lstMovieDirectors.MultiColumn = true;
            this.lstMovieDirectors.Name = "lstMovieDirectors";
            this.lstMovieDirectors.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstMovieDirectors.Size = new System.Drawing.Size(203, 95);
            this.lstMovieDirectors.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Film Yönetmenleri";
            // 
            // btnCastAdd
            // 
            this.btnCastAdd.Location = new System.Drawing.Point(534, 139);
            this.btnCastAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnCastAdd.Name = "btnCastAdd";
            this.btnCastAdd.Size = new System.Drawing.Size(113, 30);
            this.btnCastAdd.TabIndex = 34;
            this.btnCastAdd.Text = "Ekle >>";
            this.btnCastAdd.UseVisualStyleBackColor = true;
            this.btnCastAdd.Click += new System.EventHandler(this.BtnCastAdd_Click);
            // 
            // btnDirectorAdd
            // 
            this.btnDirectorAdd.Location = new System.Drawing.Point(534, 297);
            this.btnDirectorAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnDirectorAdd.Name = "btnDirectorAdd";
            this.btnDirectorAdd.Size = new System.Drawing.Size(113, 30);
            this.btnDirectorAdd.TabIndex = 34;
            this.btnDirectorAdd.Text = "Ekle >>";
            this.btnDirectorAdd.UseVisualStyleBackColor = true;
            this.btnDirectorAdd.Click += new System.EventHandler(this.BtnDirectorAdd_Click);
            // 
            // btnRemoveCast
            // 
            this.btnRemoveCast.Location = new System.Drawing.Point(868, 139);
            this.btnRemoveCast.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveCast.Name = "btnRemoveCast";
            this.btnRemoveCast.Size = new System.Drawing.Size(71, 30);
            this.btnRemoveCast.TabIndex = 34;
            this.btnRemoveCast.Text = "Çıkar <<";
            this.btnRemoveCast.UseVisualStyleBackColor = true;
            this.btnRemoveCast.Click += new System.EventHandler(this.BtnRemoveCast_Click);
            // 
            // btnRemoveDirector
            // 
            this.btnRemoveDirector.Location = new System.Drawing.Point(868, 297);
            this.btnRemoveDirector.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveDirector.Name = "btnRemoveDirector";
            this.btnRemoveDirector.Size = new System.Drawing.Size(71, 30);
            this.btnRemoveDirector.TabIndex = 34;
            this.btnRemoveDirector.Text = "Çıkar <<";
            this.btnRemoveDirector.UseVisualStyleBackColor = true;
            this.btnRemoveDirector.Click += new System.EventHandler(this.BtnRemoveDirector_Click);
            // 
            // chbIsActive
            // 
            this.chbIsActive.AutoSize = true;
            this.chbIsActive.Location = new System.Drawing.Point(48, 386);
            this.chbIsActive.Name = "chbIsActive";
            this.chbIsActive.Size = new System.Drawing.Size(47, 17);
            this.chbIsActive.TabIndex = 39;
            this.chbIsActive.Text = "Aktif";
            this.chbIsActive.UseVisualStyleBackColor = true;
            // 
            // FormMovieUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.chbIsActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDirectorAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCastAdd);
            this.Controls.Add(this.lstMovieDirectors);
            this.Controls.Add(this.lstAllDirectors);
            this.Controls.Add(this.lstMovieCasts);
            this.Controls.Add(this.lstAllCasts);
            this.Controls.Add(this.btnDirectorAdd);
            this.Controls.Add(this.btnRemoveDirector);
            this.Controls.Add(this.btnRemoveCast);
            this.Controls.Add(this.btnCastAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.chb3D);
            this.Controls.Add(this.nudMovieTime);
            this.Controls.Add(this.cmbMovieType);
            this.Controls.Add(this.lblMovieYear);
            this.Controls.Add(this.lblMovieTime);
            this.Controls.Add(this.lblMovieType);
            this.Controls.Add(this.txtMovieYear);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.lblMovieName);
            this.Name = "FormMovieUpdate";
            this.Text = "FormMovieUpdate";
            this.Load += new System.EventHandler(this.FormMovieUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMovieTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDirectorAdd;
        private System.Windows.Forms.Label lblCastAdd;
        private System.Windows.Forms.ListBox lstAllDirectors;
        private System.Windows.Forms.ListBox lstAllCasts;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chb3D;
        private System.Windows.Forms.NumericUpDown nudMovieTime;
        private System.Windows.Forms.ComboBox cmbMovieType;
        private System.Windows.Forms.Label lblMovieYear;
        private System.Windows.Forms.Label lblMovieTime;
        private System.Windows.Forms.Label lblMovieType;
        private System.Windows.Forms.TextBox txtMovieYear;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.ListBox lstMovieCasts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstMovieDirectors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCastAdd;
        private System.Windows.Forms.Button btnDirectorAdd;
        private System.Windows.Forms.Button btnRemoveCast;
        private System.Windows.Forms.Button btnRemoveDirector;
        private System.Windows.Forms.CheckBox chbIsActive;
    }
}