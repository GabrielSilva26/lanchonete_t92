using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private int largImagem;

        public PrincipalController(Form form)
        {
            this.form = form;

            FormataTela();
            CriaPainelLateral();
            CriaLogo();
            CriaBotoes();

        }

        void FormataTela()
        {
            // inicia a tela em tela cheia
            form.WindowState = FormWindowState.Maximized;

            // Removendo a barra de título Win
            form.FormBorderStyle = FormBorderStyle.None;

            // Colocando a cor de fundo 
            form.BackColor = Color.FromArgb(Config.corFundo[Config.tema, Config.tema], Config.corFundo[Config.tema, 1], Config.corFundo[Config.tema, 2]);
        }

        void CriaPainelLateral()
        {

            this.largImagem = Convert.ToInt32(Config.tamanhoTela[0] * 0.3f);

            PictureBox imagemLateral = new PictureBox();// cria o objeto (componente
            imagemLateral.Size = new Size(largImagem, Config.tamanhoTela[1]);// tamanho
            imagemLateral.BackgroundImage = Image.FromFile(Path.Combine(Config.CaminhosImagens("lateral"))); // carrega imagem de fundo

            imagemLateral.BackgroundImageLayout = ImageLayout.Zoom;

            imagemLateral.BackColor = Color.Transparent;// cor de fundo
            imagemLateral.Location = new Point(0, 0); // posição

            // Instanciá-lo na tela (colocar)
            form.Controls.Add(imagemLateral);

        }

        void CriaLogo()
        {
            int largLogo = Convert.ToInt32(Config.tamanhoTela[0] * 0.2f);

            int elementos = largImagem + largLogo;

            int posX = Convert.ToInt32(Config.tamanhoTela[0] * 0.7f - largLogo);
            int posY = Convert.ToInt32((Config.tamanhoTela[1] / 2) - (largLogo / 2));

            Debug.WriteLine(elementos);

            PictureBox logoImg = new PictureBox();
            logoImg.Size = new Size(largLogo, largLogo);
            logoImg.BackgroundImage = Image.FromFile(Config.CaminhosImagens("logo"));
            logoImg.BackgroundImageLayout = ImageLayout.Zoom;

            logoImg.BackColor = Color.Transparent;
            logoImg.Location = new Point(posX, posY);

            form.Controls.Add(logoImg);
        }

        void CriaBotoes()
        {
            Button configBtn = new Button();
            Button sairBtn = new Button();

            int tamanhoBtn = Convert.ToInt32(Config.tamanhoTela[0] * 0.02f);
            int posX = Convert.ToInt32(Config.tamanhoTela[0] * 0.97f);

            configBtn.Size = new Size(tamanhoBtn, tamanhoBtn);
            configBtn.BackgroundImage = Image.FromFile(Config.CaminhosImagens("config"));
            configBtn.BackgroundImageLayout = ImageLayout.Zoom;
            configBtn.FlatAppearance.BorderSize = 0;
            configBtn.FlatStyle = FlatStyle.Flat;
            configBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            configBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            configBtn.BackColor = Color.Transparent;
            configBtn.Cursor = Cursors.Hand;
            configBtn.Location = new Point(posX - 35, 10);
            form.Controls.Add(configBtn);

            int exitBtn = Convert.ToInt32(Config.tamanhoTela[0] * 0.02f);
            sairBtn.Size = new Size(exitBtn, exitBtn);
            sairBtn.BackgroundImage = Image.FromFile(Config.CaminhosImagens("sair"));
            sairBtn.BackgroundImageLayout = ImageLayout.Zoom;
            sairBtn.FlatAppearance.BorderSize = 0;
            sairBtn.FlatStyle = FlatStyle.Flat;
            sairBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            sairBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            sairBtn.BackColor = Color.Transparent;
            sairBtn.Cursor = Cursors.Hand;
            sairBtn.Location = new Point(posX, 10);
            form.Controls.Add(sairBtn);
        }
    }
}
