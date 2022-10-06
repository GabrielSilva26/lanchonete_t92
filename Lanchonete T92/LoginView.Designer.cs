
namespace Lanchonete_T92
{
    partial class LoginView
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.entrarBtn = new System.Windows.Forms.Button();
            this.logoImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // entrarBtn
            // 
            this.entrarBtn.BackColor = System.Drawing.SystemColors.Control;
            this.entrarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entrarBtn.BackgroundImage")));
            this.entrarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.entrarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entrarBtn.FlatAppearance.BorderSize = 0;
            this.entrarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.entrarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.entrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrarBtn.ForeColor = System.Drawing.Color.White;
            this.entrarBtn.Location = new System.Drawing.Point(497, 240);
            this.entrarBtn.Name = "entrarBtn";
            this.entrarBtn.Size = new System.Drawing.Size(128, 43);
            this.entrarBtn.TabIndex = 1;
            this.entrarBtn.Text = "Clique para Entrar";
            this.entrarBtn.UseVisualStyleBackColor = false;
            this.entrarBtn.Click += new System.EventHandler(this.entrarBtn_Click);
            // 
            // logoImg
            // 
            this.logoImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoImg.BackgroundImage")));
            this.logoImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoImg.Location = new System.Drawing.Point(475, 83);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(165, 151);
            this.logoImg.TabIndex = 0;
            this.logoImg.TabStop = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.entrarBtn);
            this.Controls.Add(this.logoImg);
            this.Name = "LoginView";
            this.Text = "Clique para Entrar";
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button entrarBtn;
        private System.Windows.Forms.PictureBox logoImg;
    }
}

