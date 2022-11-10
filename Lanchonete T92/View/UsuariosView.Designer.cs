
namespace Lanchonete_T92
{
    partial class UsuariosView
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
            this.label1 = new System.Windows.Forms.Label();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.senhaTxt = new System.Windows.Forms.TextBox();
            this.cadastrarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manutenção de Usuários do Sistema";
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Location = new System.Drawing.Point(171, 69);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(152, 20);
            this.usuarioTxt.TabIndex = 1;
            // 
            // senhaTxt
            // 
            this.senhaTxt.Location = new System.Drawing.Point(458, 69);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.Size = new System.Drawing.Size(145, 20);
            this.senhaTxt.TabIndex = 2;
            this.senhaTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cadastrarBtn
            // 
            this.cadastrarBtn.Location = new System.Drawing.Point(348, 135);
            this.cadastrarBtn.Name = "cadastrarBtn";
            this.cadastrarBtn.Size = new System.Drawing.Size(75, 23);
            this.cadastrarBtn.TabIndex = 3;
            this.cadastrarBtn.Text = "Cadastrar";
            this.cadastrarBtn.UseVisualStyleBackColor = true;
            // 
            // UsuariosView
            // 
            this.ClientSize = new System.Drawing.Size(796, 419);
            this.Controls.Add(this.cadastrarBtn);
            this.Controls.Add(this.senhaTxt);
            this.Controls.Add(this.usuarioTxt);
            this.Controls.Add(this.label1);
            this.Name = "UsuariosView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.TextBox senhaTxt;
        private System.Windows.Forms.Button cadastrarBtn;
    }
}
