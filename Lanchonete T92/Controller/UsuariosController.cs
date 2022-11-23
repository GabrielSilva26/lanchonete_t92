using System.Windows.Forms; // importação dos componentes de tela win
using MySql.Data; // importa as bibliotecas de acesso ao MySql
using MySql.Data.MySqlClient;

namespace Lanchonete_T92
{
    class UsuariosController
    {
        Form form; // propriedade que armazena a tela UsuariosView

        // método construtor, executando automaticamente

        public UsuariosController(Form form)
        {
            this.form = form;

            MessageBoxButtons botoes = MessageBoxButtons.YesNoCancel;

            MostraMensagem("texto exibido", "título da caixinha", botoes);
        }

        void MostraMensagem(string mensagem, string titulo, MessageBoxButtons botoes)
        {
            MessageBox.Show(mensagem, titulo, botoes);
        }

        void ConectaBanco()
        {
            // objeto da classe de conexão com o MySQL
            MySqlConnection conexao = new MySqlConnection
                ("server=localhost;port=3306;database=lanchonete_t92;uid=root;passoword=");


            // Abre a conexão com o banco
            conexao.Open();
        }
    }
}