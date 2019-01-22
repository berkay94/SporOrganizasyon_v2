namespace SporOrganizasyon
{
    partial class AnaEkran
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
            this.labelHg = new System.Windows.Forms.Label();
            this.buttonEtkinlik = new System.Windows.Forms.Button();
            this.buttonKatil = new System.Windows.Forms.Button();
            this.buttonMekan = new System.Windows.Forms.Button();
            this.labelGiris = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHg
            // 
            this.labelHg.AutoSize = true;
            this.labelHg.BackColor = System.Drawing.Color.Transparent;
            this.labelHg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHg.Location = new System.Drawing.Point(3, 13);
            this.labelHg.Name = "labelHg";
            this.labelHg.Size = new System.Drawing.Size(73, 16);
            this.labelHg.TabIndex = 3;
            this.labelHg.Text = "Hosgeldin:";
            // 
            // buttonEtkinlik
            // 
            this.buttonEtkinlik.BackColor = System.Drawing.Color.Transparent;
            this.buttonEtkinlik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEtkinlik.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEtkinlik.Location = new System.Drawing.Point(59, 64);
            this.buttonEtkinlik.Name = "buttonEtkinlik";
            this.buttonEtkinlik.Size = new System.Drawing.Size(145, 40);
            this.buttonEtkinlik.TabIndex = 4;
            this.buttonEtkinlik.Text = "Etkinlik Oluştur";
            this.buttonEtkinlik.UseVisualStyleBackColor = false;
            this.buttonEtkinlik.Click += new System.EventHandler(this.buttonEtkinlik_Click);
            // 
            // buttonKatil
            // 
            this.buttonKatil.BackColor = System.Drawing.Color.Transparent;
            this.buttonKatil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKatil.Location = new System.Drawing.Point(371, 35);
            this.buttonKatil.Name = "buttonKatil";
            this.buttonKatil.Size = new System.Drawing.Size(145, 40);
            this.buttonKatil.TabIndex = 5;
            this.buttonKatil.Text = "Etkinliğe Katıl";
            this.buttonKatil.UseVisualStyleBackColor = false;
            this.buttonKatil.Visible = false;
            this.buttonKatil.Click += new System.EventHandler(this.buttonKatil_Click);
            // 
            // buttonMekan
            // 
            this.buttonMekan.BackColor = System.Drawing.Color.Transparent;
            this.buttonMekan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMekan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMekan.Location = new System.Drawing.Point(666, 64);
            this.buttonMekan.Name = "buttonMekan";
            this.buttonMekan.Size = new System.Drawing.Size(145, 40);
            this.buttonMekan.TabIndex = 6;
            this.buttonMekan.Text = "Mekan Ekle";
            this.buttonMekan.UseVisualStyleBackColor = false;
            this.buttonMekan.Click += new System.EventHandler(this.buttonMekan_Click);
            // 
            // labelGiris
            // 
            this.labelGiris.AutoSize = true;
            this.labelGiris.BackColor = System.Drawing.Color.Transparent;
            this.labelGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGiris.Location = new System.Drawing.Point(70, 13);
            this.labelGiris.Name = "labelGiris";
            this.labelGiris.Size = new System.Drawing.Size(45, 16);
            this.labelGiris.TabIndex = 9;
            this.labelGiris.Text = "label1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(842, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "AŞAĞIDA AKTİF OLAN ETKİNLİKLERDEN BİRİNİ SEÇEBİLİRSİNİZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 496);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(839, 141);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SporOrganizasyon.Properties.Resources.en_iyi_spor_dallari_758x379;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(853, 638);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGiris);
            this.Controls.Add(this.buttonMekan);
            this.Controls.Add(this.buttonKatil);
            this.Controls.Add(this.buttonEtkinlik);
            this.Controls.Add(this.labelHg);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaEkran";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHg;
        private System.Windows.Forms.Button buttonEtkinlik;
        private System.Windows.Forms.Button buttonKatil;
        private System.Windows.Forms.Button buttonMekan;
        private System.Windows.Forms.Label labelGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}