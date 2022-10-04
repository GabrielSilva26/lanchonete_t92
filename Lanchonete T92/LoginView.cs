// Importações de bibliotecas (classes)
using System; // classe de sistema do Win
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            InitializeComponent();

            // chamando o método que está no Model desta tela
            // Instanciar a classe como um objetivo utilizável
            LayoutModel login = new LayoutModel();

            login.MontaLogin( this );

        }


    }
}
