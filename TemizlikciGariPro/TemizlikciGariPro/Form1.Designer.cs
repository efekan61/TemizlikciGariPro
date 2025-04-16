namespace TemizlikciGariPro
{
    partial class Form1
    {
        /// <summary>
        /// Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Temizlik işlemini başlatacak buton
        /// </summary>
        private System.Windows.Forms.Button btnTemizle;

        /// <summary>
        /// Form başlatıcısı
        /// </summary>
        /// <param name="disposing">Yönetilen kaynaklar serbest bırakılacak mı?</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer tarafından oluşturulan kod

        /// <summary>
        /// Tasarımcı tarafından kullanılan metot - Form öğelerini başlatır
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(189, 189);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(255, 40);
            this.btnTemizle.TabIndex = 0;
            this.btnTemizle.Text = "Temizlemeye Başla";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDurum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDurum.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.Color.DimGray;
            this.lblDurum.Location = new System.Drawing.Point(189, 125);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(255, 23);
            this.lblDurum.TabIndex = 3;
            this.lblDurum.Text = "Hazır";
            this.lblDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(645, 378);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnTemizle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDurum;
    }
}
