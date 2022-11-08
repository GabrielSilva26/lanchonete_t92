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
            CriaBotoes();
            CriaPainelLateral();
            CriaLogo();
            ComponentePanel();






            // Listeners (ouvintes) dos botões da tela
            // O objeto deve ter um .Name para poder ser programado
            // .Click - clique sobre o elemento
            // .MouseHover - mouse sobre o elemento
            // .MouseLeave - mouse sair de cima do elemento
            // .MouseMove - quando o mouse se movimenta sobre o elemento
            // .DoubleClick - clique duplo sobre o elemento
            // .MouseDown - mouse pressionado sobre o elemento
            form.Controls.Find("sairBtn", true)[0].Click += FazerLogOff;
            form.Controls.Find("menuBtn", true)[0].Click += CarregaTelas;

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
            int posX = Convert.ToInt32(Config.tamanhoTela[0] * 0.97f);
            int posX2 = Convert.ToInt32(Config.tamanhoTela[0] * 0.94f);



            Button configBtn = new Button();
            PadronizaBotoes(configBtn);
            configBtn.Location = new Point(posX2, 10);
            configBtn.BackgroundImage = Image.FromFile(Config.CaminhosImagens("config"));
            configBtn.Name = "configBtn"; // aplica um Name ao objeto
            form.Controls.Add(configBtn);



            Button sairBtn = new Button();
            PadronizaBotoes(sairBtn);
            sairBtn.Location = new Point(posX, 10);
            sairBtn.BackgroundImage = Image.FromFile(Config.CaminhosImagens("sair"));
            sairBtn.Name = "sairBtn";
            form.Controls.Add(sairBtn);



            Button menuBtn = new Button();
            PadronizaBotoes(menuBtn);
            menuBtn.Location = new Point(10, 10);
            menuBtn.BackgroundImage = Image.FromFile(Config.CaminhosImagens("menu"));
            menuBtn.Name = "menuBtn";
            form.Controls.Add(menuBtn);
        }



        void PadronizaBotoes(Button botao)
        {
            int tamanhoBtn = Convert.ToInt32(Config.tamanhoTela[0] * 0.02f);



            botao.Size = new Size(tamanhoBtn, tamanhoBtn);
            botao.BackgroundImageLayout = ImageLayout.Zoom;
            botao.FlatAppearance.BorderSize = 0;
            botao.FlatStyle = FlatStyle.Flat;
            botao.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botao.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botao.BackColor = Color.Transparent;
            botao.Cursor = Cursors.Hand;


        }

        void FazerLogOff(object disparador, EventArgs evento)
        {
            // ocultar a tela atual
            form.Hide();

            // Abrimos a tela de Login
            LoginView loginV = new LoginView(); // criando o bjeto da tela de login
            loginV.Show(); // exibe a tela criada 

            //form.Close(); // encerra a tela e se for a única aberta encerra a aplicação
        }

        void ComponentePanel()
        {
            Panel componente = new Panel();
            int largComponente = Convert.ToInt32(Config.tamanhoTela[0] * 0.7f);
            int PosX = Convert.ToInt32(Config.tamanhoTela[0] * 0.3f);

            componente.Size = new Size(largComponente, Config.tamanhoTela[1]);
            componente.BackColor = Color.Transparent;
            componente.Cursor = Cursors.Hand;

            componente.Location = new Point(PosX, 0);
            componente.Name = "tela";
            componente.BringToFront();

            form.Controls.Add(componente);
        }

        /// <summary>
        /// Método que carrega as telas internas dentro do componente Panel nomeado como tela na PrincipalView.cs
        /// </summary>
        void CarregaTelas( object disparador, EventArgs evento )
        {
            // criar um objeto (instanciar)
            // Tipos Básicos(variável/propriedade/atributo/parâmetros): int (valores inteiros), string (texto), bool(verdadeiro ou falso), char(apenas uma letra), enum, float, decimal

            UsuariosView telaUsuarios = new UsuariosView(); // objeto

            // Pegando o componente da tela
            Panel tela = (Panel) form.Controls.Find("tela", true)[0];

            // definimos para que a janela não suba na hierarquia do Win
            telaUsuarios.TopLevel = false;

            // puxamos a nova tela para a frente(empilhamento)
            tela.BringToFront();

            // carregando a tela no componente
            tela.Controls.Add(telaUsuarios);

            telaUsuarios.Show(); // exibe a tela
        }
    }
}