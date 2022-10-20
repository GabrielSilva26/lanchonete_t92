/*
    Classe que aplica as alterações, chamadas e controles da tela de Login (LoginView.cs)
    
    Propriedades / Atributos / Variáveis / Parâmetros
    - Propriedade/Atributo - está dentro da classe
    - Variável dentro do método/função
    - Parâmetro dentro do parêntese do método

    atributo =
    método ()

    *.Width / *.Height - atributo - dimensões do elemento
    *.Size () método que altera larg e alt usando new Size ( larg, alt )
    *.Parent - atributo - pega o "pai" do elemento ( que o contém )
    *.Position - atributo - posição para o elemento new Point( x, y )
    
    Convert. - Método de conversão de tipo de dados da classe System
             ToInt32() - converte para inteiros
             ToFloat() - converte para decimal float
             ToBool()  - converte para lógico
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Lanchonete_T92
{
    public class LoginController
    {
        private Form form;

        // Método Construtor - é executado automaticamente ao criar um objeto da classe
        public LoginController( Form form )
        {
            // envia o form para o atributo da classe
            this.form = form;
            TamanhoTela();
        }

    private void TamanhoTela()
    {
        // form.Width lê o tamanho da tela
        // form.Width = 100 define o tamanho da largura da tela
        // form.Width = Convert.ToInt32(Config.tamanhoTela[0] * 0.6f);
        // form.Height = Convert.ToInt32(Config.tamanhoTela[0] * 0.6f * 0.56f);

            // Tamanho da imagem lateral
            MudaTamanhos( PegaComponente("imagemLateral"), 0.35f, 1.53f );

            // Tamanho e posição do logo
            MudaTamanhos( PegaComponente("logoImg"), 0.5f, 0.5f);
            MudaPosicao( PegaComponente("logoImg"), 0.4f, 0.02f );


            // Tamanho e posição dos paineis
            MudaTamanhos( PegaComponente("panel1"), 0.5f, 0.5f);

           // PegaComponente("panel1").BackColor = Color.Transparent;

          /*------------------------------------------------------------------------------------
           */ 

            // int largLateral = Convert.ToInt32(form.Width * 0.35f);
            // int altLateral = Convert.ToInt32(form.Height * 1.54f);

            // form.Controls.Find("imagemLateral", true)[0].Size = new Size(largLateral, altLateral);

            // tamanho do logotipo
            //int largLogo = Convert.ToInt32(form.Width * 0.20f);

           // form.Controls.Find("logoImg", true)[0].Size = new Size(largLogo, largLogo);
        }

        void MudaTamanhos(Control componente, float fatorLarg, float fatorAlt)
        {
            int larguraNova = Convert.ToInt32( componente.Parent.Width * fatorLarg );
            int alturaNova = Convert.ToInt32( componente.Parent.Height * fatorAlt );

            // Alterando o tamanho do componente
            componente.Size = new Size( larguraNova, alturaNova );

            Debug.WriteLine(componente.Parent.Width);


        }
        void MudaPosicao( Control componente, float x, float y )
        {
            int posX = Convert.ToInt32(componente.Parent.Width * x);
            int posY = Convert.ToInt32(componente.Parent.Width * y);

            componente.Location = new Point(posX, posY); // posição do elemento
        }

        Control PegaComponente(string quem)
        {
            return form.Controls.Find(quem, true)[0];
        }

        /// <summary>
        /// Remove cor de fundo e padroniza todos os componentes da tela
        /// </summary>
        void FormatacaoGeral()
        {
            // Para cada item encontrada repita o código abaixo
            foreach (Control itens in form.Controls)
            {
                if (itens is PictureBox)
                {
                    PictureBox imagem = (PictureBox) itens;
                    MessageBox.Show("Foram encontrados " + itens.Name + "itens");
                }
            }

        }

    }  
}