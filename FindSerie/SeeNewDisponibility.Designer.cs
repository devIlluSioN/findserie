namespace FindSerie
{
    partial class SeeNewDisponibility
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
            this.rnm_btn_actualiser = new System.Windows.Forms.Button();
            this.rnm_btn_parcourir = new System.Windows.Forms.Button();
            this.SND_TB_Directory_Path = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SND_btn_Validation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rnm_btn_actualiser
            // 
            this.rnm_btn_actualiser.Location = new System.Drawing.Point(1446, 35);
            this.rnm_btn_actualiser.Margin = new System.Windows.Forms.Padding(6);
            this.rnm_btn_actualiser.Name = "rnm_btn_actualiser";
            this.rnm_btn_actualiser.Size = new System.Drawing.Size(150, 44);
            this.rnm_btn_actualiser.TabIndex = 28;
            this.rnm_btn_actualiser.Text = "Actualiser";
            this.rnm_btn_actualiser.UseVisualStyleBackColor = true;
            // 
            // rnm_btn_parcourir
            // 
            this.rnm_btn_parcourir.Location = new System.Drawing.Point(1276, 37);
            this.rnm_btn_parcourir.Margin = new System.Windows.Forms.Padding(6);
            this.rnm_btn_parcourir.Name = "rnm_btn_parcourir";
            this.rnm_btn_parcourir.Size = new System.Drawing.Size(158, 42);
            this.rnm_btn_parcourir.TabIndex = 27;
            this.rnm_btn_parcourir.Text = "Parcourir";
            this.rnm_btn_parcourir.UseVisualStyleBackColor = true;
            // 
            // SND_TB_Directory_Path
            // 
            this.SND_TB_Directory_Path.Location = new System.Drawing.Point(104, 42);
            this.SND_TB_Directory_Path.Margin = new System.Windows.Forms.Padding(6);
            this.SND_TB_Directory_Path.Name = "SND_TB_Directory_Path";
            this.SND_TB_Directory_Path.Size = new System.Drawing.Size(1160, 31);
            this.SND_TB_Directory_Path.TabIndex = 26;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(104, 188);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1492, 638);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // SND_btn_Validation
            // 
            this.SND_btn_Validation.Location = new System.Drawing.Point(705, 98);
            this.SND_btn_Validation.Name = "SND_btn_Validation";
            this.SND_btn_Validation.Size = new System.Drawing.Size(190, 68);
            this.SND_btn_Validation.TabIndex = 30;
            this.SND_btn_Validation.Text = "Valider";
            this.SND_btn_Validation.UseVisualStyleBackColor = true;
            this.SND_btn_Validation.Click += new System.EventHandler(this.SND_btn_Validation_Click);
            // 
            // SeeNewDisponibility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1936, 1582);
            this.Controls.Add(this.SND_btn_Validation);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.rnm_btn_actualiser);
            this.Controls.Add(this.rnm_btn_parcourir);
            this.Controls.Add(this.SND_TB_Directory_Path);
            this.Name = "SeeNewDisponibility";
            this.Text = "SeeNewDisponibility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rnm_btn_actualiser;
        public System.Windows.Forms.Button rnm_btn_parcourir;
        public System.Windows.Forms.TextBox SND_TB_Directory_Path;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button SND_btn_Validation;
    }
}