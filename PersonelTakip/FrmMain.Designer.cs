
namespace PersonelTakip
{
    partial class FrmMain
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
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnIs = new System.Windows.Forms.Button();
            this.btnMaas = new System.Windows.Forms.Button();
            this.btnIzin = new System.Windows.Forms.Button();
            this.btnDepartman = new System.Windows.Forms.Button();
            this.btnPozisyon = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonel
            // 
            this.btnPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPersonel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPersonel.Location = new System.Drawing.Point(12, 12);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(126, 116);
            this.btnPersonel.TabIndex = 0;
            this.btnPersonel.Text = "Personel İslemleri";
            this.btnPersonel.UseVisualStyleBackColor = false;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnIs
            // 
            this.btnIs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIs.Location = new System.Drawing.Point(144, 12);
            this.btnIs.Name = "btnIs";
            this.btnIs.Size = new System.Drawing.Size(126, 116);
            this.btnIs.TabIndex = 1;
            this.btnIs.Text = "İşler";
            this.btnIs.UseVisualStyleBackColor = false;
            this.btnIs.Click += new System.EventHandler(this.btnIs_Click);
            // 
            // btnMaas
            // 
            this.btnMaas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMaas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMaas.Location = new System.Drawing.Point(276, 12);
            this.btnMaas.Name = "btnMaas";
            this.btnMaas.Size = new System.Drawing.Size(126, 116);
            this.btnMaas.TabIndex = 2;
            this.btnMaas.Text = "Maaş";
            this.btnMaas.UseVisualStyleBackColor = false;
            this.btnMaas.Click += new System.EventHandler(this.btnMaas_Click);
            // 
            // btnIzin
            // 
            this.btnIzin.BackColor = System.Drawing.Color.Teal;
            this.btnIzin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIzin.Location = new System.Drawing.Point(12, 134);
            this.btnIzin.Name = "btnIzin";
            this.btnIzin.Size = new System.Drawing.Size(126, 116);
            this.btnIzin.TabIndex = 3;
            this.btnIzin.Text = "İzin İşlemleri";
            this.btnIzin.UseVisualStyleBackColor = false;
            this.btnIzin.Click += new System.EventHandler(this.btnIzin_Click);
            // 
            // btnDepartman
            // 
            this.btnDepartman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDepartman.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDepartman.Location = new System.Drawing.Point(144, 134);
            this.btnDepartman.Name = "btnDepartman";
            this.btnDepartman.Size = new System.Drawing.Size(126, 116);
            this.btnDepartman.TabIndex = 4;
            this.btnDepartman.Text = "Departman İşlemleri";
            this.btnDepartman.UseVisualStyleBackColor = false;
            this.btnDepartman.Click += new System.EventHandler(this.btnDepartman_Click);
            // 
            // btnPozisyon
            // 
            this.btnPozisyon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPozisyon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPozisyon.Location = new System.Drawing.Point(276, 134);
            this.btnPozisyon.Name = "btnPozisyon";
            this.btnPozisyon.Size = new System.Drawing.Size(126, 116);
            this.btnPozisyon.TabIndex = 5;
            this.btnPozisyon.Text = "Pozisyon İşlemleri";
            this.btnPozisyon.UseVisualStyleBackColor = false;
            this.btnPozisyon.Click += new System.EventHandler(this.btnPozisyon_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.Location = new System.Drawing.Point(76, 256);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(126, 116);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(219, 256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 116);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 406);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnPozisyon);
            this.Controls.Add(this.btnDepartman);
            this.Controls.Add(this.btnIzin);
            this.Controls.Add(this.btnMaas);
            this.Controls.Add(this.btnIs);
            this.Controls.Add(this.btnPersonel);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Takip";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnIs;
        private System.Windows.Forms.Button btnMaas;
        private System.Windows.Forms.Button btnIzin;
        private System.Windows.Forms.Button btnDepartman;
        private System.Windows.Forms.Button btnPozisyon;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnExit;
    }
}