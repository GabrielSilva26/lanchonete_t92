using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete_T92
{
    class UsuariosController
    {
        // criar atributos/propriedade
        Form form;

        // criar o construtor da classe

        public UsuariosController( Form form )
        {
            this.form = form;

            // ouvinte no botão
            form.Controls.Find("cadastrarBtn", true)[0].Click += ChamaCadastro;
        }

        void ChamaCadastro( object objeto, EventArgs evento)
        {
            string usuario = form.Controls.Find("usuarioTxt", true)[0].Text;
            string senha = form.Controls.Find("senhaTxt", true)[0].Text;

            // Instanciamos a classe do DB
            DB db = new DB();

            if (db.InsereDados(usuario, senha) == true )
            {
                MessageBox.Show("Dado Inserido com Sucesso");
            }
            else
            {
                MessageBox.Show("Usuário já cadastrado!");
            }
        }
    }
}
