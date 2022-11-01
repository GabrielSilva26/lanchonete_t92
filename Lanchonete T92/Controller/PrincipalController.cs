using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete_T92
{
    class PrincipalController
    {
        private Form form;
        public PrincipalController( Form form )
        {
            this.form = form;

            FormataTela();
            CriaPainelLateral();
                
        }
        
        void FormataTela()
        {
            // inicia a tela em tela cheia
            form.WindowState = FormWindowState.Maximized;

            // Removendo a barra de título Win
            form.FormBorderStyle = FormBorderStyle.None;

            // Colocando a cor de fundo 
            form.BackColor = Color.FromArgb(Config.corFundo[Config.tema, Config.tema], Config.corFundo[Config.tema, 1], Config.corFundo[Config.tema, 2] );
        }

        void CriaPainelLateral()
        {

            int largImagem = Convert.ToInt32 ( Config.tamanhoTela[0] * 0.3f );

            PictureBox imagemLateral = new PictureBox();// cria o objeto (componente
            imagemLateral.Size = new Size( largImagem, Config.tamanhoTela[1]);// tamanho
            imagemLateral.BackgroundImage = Image.FromFile(Path.Combine( Config.CaminhosImagens("lateral")) ); // carrega imagem de fundo

            imagemLateral.BackgroundImageLayout = ImageLayout.Zoom;

            imagemLateral.BackColor = Color.Transparent;// cor de fundo
            imagemLateral.Location = new Point(0, 0); // posição

            // Instanciá-lo na tela (colocar)
            form.Controls.Add( imagemLateral );
        }

    }
}
