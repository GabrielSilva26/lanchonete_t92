// Importando as bibliotecas do MySQL instaladas com o NuGet (Projeto > Gerenciar Pacotes do NuGet )
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Lanchonete_T92
{
    class DB
    {
        // Propriedade que armazena nossa conexão com BD
        private MySqlConnection conn;

        public void ConectaBanco()
        {
            try
            {
                //cria um objeto da classe de conexão
                MySqlConnection conexao = new MySqlConnection(
                    "Server=" + Config.servidorBD + " ; " +
                    "Port=" + Config.portaBD + "; " +
                    "Database=" + Config.bancoBD + "; " +
                    "Uid=" + Config.usuarioBD + "; " +
                    "Pwd=" + Config.senhaBD);

                this.conn = conexao;
            }
            catch (Exception erro)
            {
                // passando um texto para o label que está na tela
                Application.OpenForms["UsuariosView"].Controls.Find("label1", true)[0].Text = "Conectado ao Banco";
            }

        }

        void BuscaDados()
        {

        }

        void InsereDados()
        {

        }

        void AtualizaDados()
        {

        }

        void ApagaDados()
        {

        }

    }
}
