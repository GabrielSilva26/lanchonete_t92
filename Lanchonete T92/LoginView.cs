// Importações de bibliotecas (classes)
using System; // classe de sistema do Win
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text; // usar textos na tela
using System.Threading.Tasks;
using System.Windows.Forms; // usar componentes

// namespace - agrupa as cliasses (pasta virtual)
namespace Lanchonete_T92
{
    // classe partial - tela
    public partial class LoginView : Form
    {
        // método construtor - é o único método executado automáticamente, sempre com o mesmo nome da classe.
        public LoginView()
        {
            // construtor da tela, executado automaticamente ANTES da tela carregar enquanto está sendo montada.

            // escreve o texto no Console (saida)
            Debug.WriteLine("A tela foi montada.");

            // chamamos a função/método da classe LoginViewController.cs
            // Instanciar um objeto da classe
            LoginController loginC = new LoginController();

            InitializeComponent();

            // chamando o método que está no Model desta tela
            // Instanciar a classe como um objetivo utilizável
            LayoutModel login = new LayoutModel();

            login.MontaLogin( this );

        }



        private void entrarBtn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void usuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        /*
          
            Os códigos abaixo são criados quando clicamos duas vezes em um componente da tela.

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Construtor do pictureBox, só é executado quando o pictureBox é CLICADO.
            Debug.WriteLine("Clicou na imagem.");
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            // Construtor é a função que executa automaticamente no CARREGAMENTO da tela.
            Debug.WriteLine("A tela foi carregada/exibida.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Construtor do botão só é executado quando o botão é CLICADO.
            Debug.WriteLine("Botão Clicado.");
        }
        */
    }
}
