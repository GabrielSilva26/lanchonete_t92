
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
            this.imagemLateral = new System.Windows.Forms.PictureBox();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemLateral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // entrarBtn
            // 
            this.entrarBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.entrarBtn.Location = new System.Drawing.Point(135, 116);
            this.entrarBtn.Name = "entrarBtn";
            this.entrarBtn.Size = new System.Drawing.Size(130, 50);
            this.entrarBtn.TabIndex = 2;
            this.entrarBtn.Text = "Clique para Entrar";
            this.entrarBtn.UseVisualStyleBackColor = false;
            this.entrarBtn.Click += new System.EventHandler(this.entrarBtn_Click);
            // 
            // logoImg
            // 
            this.logoImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoImg.BackgroundImage")));
            this.logoImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoImg.Location = new System.Drawing.Point(458, 30);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(200, 200);
            this.logoImg.TabIndex = 0;
            this.logoImg.TabStop = false;
            // 
            // imagemLateral
            // 
            this.imagemLateral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagemLateral.BackgroundImage")));
            this.imagemLateral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagemLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagemLateral.Location = new System.Drawing.Point(0, 0);
            this.imagemLateral.Name = "imagemLateral";
            this.imagemLateral.Size = new System.Drawing.Size(300, 450);
            this.imagemLateral.TabIndex = 2;
            this.imagemLateral.TabStop = false;
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.usuarioLabel.Location = new System.Drawing.Point(74, 37);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(115, 13);
            this.usuarioLabel.TabIndex = 3;
            this.usuarioLabel.Text = "Usuário, E-mail ou CPF";
            this.usuarioLabel.Click += new System.EventHandler(this.usuarioLabel_Click);
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usuarioTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(229)))), ((int)(((byte)(210)))));
            this.usuarioTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuarioTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTxt.Location = new System.Drawing.Point(67, 75);
            this.usuarioTxt.MaxLength = 255;
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(270, 17);
            this.usuarioTxt.TabIndex = 1;
            this.usuarioTxt.Text = "Informe seu usuário, CPF ou E-mail!";
            this.usuarioTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(62, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 78);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.usuarioTxt);
            this.panel1.Controls.Add(this.usuarioLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.entrarBtn);
            this.panel1.Location = new System.Drawing.Point(356, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 202);
            this.panel1.TabIndex = 5;
            // 
            // LoginView
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imagemLateral);
            this.Controls.Add(this.logoImg);
            this.Name = "LoginView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemLateral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button entrarBtn;
        private System.Windows.Forms.PictureBox logoImg;
        private System.Windows.Forms.PictureBox imagemLateral;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

