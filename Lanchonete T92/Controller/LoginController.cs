/*
    Classe que aplica as alterações, chamadas e controles da tela de Login (LoginView.cs)
*/

using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Lanchonete_T92
{
    public class LoginController
    {
        // Método Construtor - é executado automaticamente ao criar um objeto da classe

        public LoginController()
        {
            Debug.WriteLine("O objeto foi criado e o construtor disparado");

            // mudando a cor da tela LoginView
            Application.OpenForms["LoginView"].BackColor = Color.FromArgb(255, 0, 0);
        }
    }
}