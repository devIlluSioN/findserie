namespace FindSerie
{
    partial class MovieDbSelectSerie
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
            this.TB_Search = new System.Windows.Forms.TextBox();
            this.img_Serie = new System.Windows.Forms.PictureBox();
            this.label_NameSerie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Sysnopsis = new System.Windows.Forms.Label();
            this.label_Resallisateur = new System.Windows.Forms.Label();
            this.label_Year = new System.Windows.Forms.Label();
            this.label_nbSeason = new System.Windows.Forms.Label();
            this.TB_Synopsis = new System.Windows.Forms.TextBox();
            this.CB_Result = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Validation = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.img_Serie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Search
            // 
            this.TB_Search.Location = new System.Drawing.Point(253, 66);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(1236, 31);
            this.TB_Search.TabIndex = 0;
            // 
            // img_Serie
            // 
            this.img_Serie.Location = new System.Drawing.Point(81, 438);
            this.img_Serie.Name = "img_Serie";
            this.img_Serie.Size = new System.Drawing.Size(500, 750);
            this.img_Serie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img_Serie.TabIndex = 1;
            this.img_Serie.TabStop = false;
            // 
            // label_NameSerie
            // 
            this.label_NameSerie.AutoSize = true;
            this.label_NameSerie.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NameSerie.Location = new System.Drawing.Point(769, 428);
            this.label_NameSerie.Name = "label_NameSerie";
            this.label_NameSerie.Size = new System.Drawing.Size(213, 44);
            this.label_NameSerie.TabIndex = 2;
            this.label_NameSerie.Text = "NameSerie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1101, 729);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label_Sysnopsis
            // 
            this.label_Sysnopsis.AutoSize = true;
            this.label_Sysnopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sysnopsis.Location = new System.Drawing.Point(771, 897);
            this.label_Sysnopsis.Name = "label_Sysnopsis";
            this.label_Sysnopsis.Size = new System.Drawing.Size(150, 31);
            this.label_Sysnopsis.TabIndex = 4;
            this.label_Sysnopsis.Text = "Synopsis :";
            // 
            // label_Resallisateur
            // 
            this.label_Resallisateur.AutoSize = true;
            this.label_Resallisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Resallisateur.Location = new System.Drawing.Point(771, 563);
            this.label_Resallisateur.Name = "label_Resallisateur";
            this.label_Resallisateur.Size = new System.Drawing.Size(192, 33);
            this.label_Resallisateur.TabIndex = 5;
            this.label_Resallisateur.Text = "Realisateur :";
            // 
            // label_Year
            // 
            this.label_Year.AutoSize = true;
            this.label_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Year.Location = new System.Drawing.Point(771, 472);
            this.label_Year.Name = "label_Year";
            this.label_Year.Size = new System.Drawing.Size(130, 33);
            this.label_Year.TabIndex = 6;
            this.label_Year.Text = "Annee : ";
            // 
            // label_nbSeason
            // 
            this.label_nbSeason.AutoSize = true;
            this.label_nbSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nbSeason.Location = new System.Drawing.Point(771, 518);
            this.label_nbSeason.Name = "label_nbSeason";
            this.label_nbSeason.Size = new System.Drawing.Size(306, 33);
            this.label_nbSeason.TabIndex = 7;
            this.label_nbSeason.Text = "Nombres de Saison :";
            // 
            // TB_Synopsis
            // 
            this.TB_Synopsis.Location = new System.Drawing.Point(790, 944);
            this.TB_Synopsis.Multiline = true;
            this.TB_Synopsis.Name = "TB_Synopsis";
            this.TB_Synopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Synopsis.Size = new System.Drawing.Size(1194, 269);
            this.TB_Synopsis.TabIndex = 8;
            // 
            // CB_Result
            // 
            this.CB_Result.FormattingEnabled = true;
            this.CB_Result.Location = new System.Drawing.Point(253, 144);
            this.CB_Result.Name = "CB_Result";
            this.CB_Result.Size = new System.Drawing.Size(648, 33);
            this.CB_Result.TabIndex = 9;
            this.CB_Result.SelectedIndexChanged += new System.EventHandler(this.CB_Result_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Resultat(s) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Recherche :";
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImage = global::FindSerie.Properties.Resources.icons8_chercher_26;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.Location = new System.Drawing.Point(1511, 59);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(58, 38);
            this.btn_Search.TabIndex = 12;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Validation
            // 
            this.btn_Validation.Location = new System.Drawing.Point(522, 1362);
            this.btn_Validation.Name = "btn_Validation";
            this.btn_Validation.Size = new System.Drawing.Size(379, 73);
            this.btn_Validation.TabIndex = 13;
            this.btn_Validation.Text = "Valider";
            this.btn_Validation.UseVisualStyleBackColor = true;
            this.btn_Validation.Click += new System.EventHandler(this.btn_Validation_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(1106, 1362);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(369, 73);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Annuler";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MovieDbSelectSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2272, 1482);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Validation);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Result);
            this.Controls.Add(this.TB_Synopsis);
            this.Controls.Add(this.label_nbSeason);
            this.Controls.Add(this.label_Year);
            this.Controls.Add(this.label_Resallisateur);
            this.Controls.Add(this.label_Sysnopsis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_NameSerie);
            this.Controls.Add(this.img_Serie);
            this.Controls.Add(this.TB_Search);
            this.Name = "MovieDbSelectSerie";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.img_Serie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Search;
        private System.Windows.Forms.PictureBox img_Serie;
        private System.Windows.Forms.Label label_NameSerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Sysnopsis;
        private System.Windows.Forms.Label label_Year;
        private System.Windows.Forms.Label label_nbSeason;
        private System.Windows.Forms.TextBox TB_Synopsis;
        private System.Windows.Forms.ComboBox CB_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_Resallisateur;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Validation;
        private System.Windows.Forms.Button btn_cancel;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}