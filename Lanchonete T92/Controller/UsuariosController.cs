using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            form.WindowState = FormWindowState.Maximized;

            MessageBox.Show( form.Width.ToString() );
            MessageBox.Show( form.Height.ToString() );
        }

        void ChamaCadastro( object objeto, EventArgs evento)
        {
            string usuario = form.Controls.Find("usuarioTxt", true)[0].Text;
            string senha = form.Controls.Find("senhaTxt", true)[0].Text;
            
            // Instanciamos a classe do DB
            DB db = new DB();


            // Criptogafamos a senha informada
            MySqlCommand senhaCriptografada = db.CriptografaSenha(senha);

            Debug.WriteLine(senhaCriptografada.ToString());

            string campos = "login, senha";
            string valores = " '"+ usuario +"', '"+ senha +"' ";
            string tabela = "usuarios";

            db.InsereDados(campos, valores, tabela);

        }
    }
}
