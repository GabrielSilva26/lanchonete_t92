
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
            this.continuarBtn = new System.Windows.Forms.Button();
            this.logoImg = new System.Windows.Forms.PictureBox();
            this.imagemLateral = new System.Windows.Forms.PictureBox();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.voltarBtn = new System.Windows.Forms.Button();
            this.senhaTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.entraBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemLateral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // continuarBtn
            // 
            this.continuarBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.continuarBtn.BackColor = System.Drawing.SystemColors.Control;
            this.continuarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("continuarBtn.BackgroundImage")));
            this.continuarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.continuarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continuarBtn.FlatAppearance.BorderSize = 0;
            this.continuarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.continuarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.continuarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continuarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuarBtn.ForeColor = System.Drawing.Color.White;
            this.continuarBtn.Location = new System.Drawing.Point(135, 116);
            this.continuarBtn.Name = "continuarBtn";
            this.continuarBtn.Size = new System.Drawing.Size(130, 50);
            this.continuarBtn.TabIndex = 2;
            this.continuarBtn.Text = "Continuar";
            this.continuarBtn.UseVisualStyleBackColor = false;
            this.continuarBtn.Click += new System.EventHandler(this.entrarBtn_Click);
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
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.usuarioTxt);
            this.panel1.Controls.Add(this.usuarioLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.continuarBtn);
            this.panel1.Location = new System.Drawing.Point(356, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 202);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.voltarBtn);
            this.panel2.Controls.Add(this.senhaTxt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.entraBtn);
            this.panel2.Location = new System.Drawing.Point(356, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 202);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // voltarBtn
            // 
            this.voltarBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.voltarBtn.BackColor = System.Drawing.SystemColors.Control;
            this.voltarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltarBtn.BackgroundImage")));
            this.voltarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.voltarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltarBtn.FlatAppearance.BorderSize = 0;
            this.voltarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.voltarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.voltarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarBtn.ForeColor = System.Drawing.Color.White;
            this.voltarBtn.Location = new System.Drawing.Point(71, 128);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(130, 50);
            this.voltarBtn.TabIndex = 5;
            this.voltarBtn.Text = "Voltar";
            this.voltarBtn.UseVisualStyleBackColor = false;
            this.voltarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // senhaTxt
            // 
            this.senhaTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.senhaTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(229)))), ((int)(((byte)(210)))));
            this.senhaTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senhaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTxt.Location = new System.Drawing.Point(67, 75);
            this.senhaTxt.MaxLength = 255;
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.PasswordChar = '*';
            this.senhaTxt.Size = new System.Drawing.Size(270, 17);
            this.senhaTxt.TabIndex = 1;
            this.senhaTxt.Text = "Informe sua senha!";
            this.senhaTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Location = new System.Drawing.Point(74, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Senha:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(62, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 78);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // entraBtn
            // 
            this.entraBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.entraBtn.BackColor = System.Drawing.SystemColors.Control;
            this.entraBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entraBtn.BackgroundImage")));
            this.entraBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.entraBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entraBtn.FlatAppearance.BorderSize = 0;
            this.entraBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.entraBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.entraBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entraBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entraBtn.ForeColor = System.Drawing.Color.White;
            this.entraBtn.Location = new System.Drawing.Point(207, 128);
            this.entraBtn.Name = "entraBtn";
            this.entraBtn.Size = new System.Drawing.Size(130, 50);
            this.entraBtn.TabIndex = 2;
            this.entraBtn.Text = "Acessar o Sistema";
            this.entraBtn.UseVisualStyleBackColor = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.logoImg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imagemLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemLateral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button continuarBtn;
        private System.Windows.Forms.PictureBox logoImg;
        private System.Windows.Forms.PictureBox imagemLateral;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox senhaTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button entraBtn;
        private System.Windows.Forms.Button voltarBtn;
    }
}

