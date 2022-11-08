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

        // criar o construtor da classe

        public UsuariosController( Form form )
        {
            // Instanciamos a classe do DB
            DB db = new DB();

            // chamamos a conexão com o banco
            db.ConectaBanco();

            // passando um texto para o label que está na tela
            form.Controls.Find("label1", true)[0].Text = "Conectado ao Banco";
        }
    }
}
