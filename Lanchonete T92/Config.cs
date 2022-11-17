/*
    Na POO existem 04 pilares:
        - Encapsulamento
            - Proteção dos dados na aplicação (acesso)
            - private é visível apenas na classe (arquivo)
            - public é visível de qualquer outra classe

        - Abstração - ao chamaor um método não é necessário conhecer seus detalhes, apenas passar os parâmetros que são obrigatórios.
            
        - Herança
        - Polimorfismo

    Classe Static que armazena as configurações da aplicação
    - Cores
    - Fontes
    - Credenciais BD

    Classes no C#
        Existem:
            - classes "normais" - para usá-la precisa de um objeto
            - classes static - não precisam de objetos (menos seguras)

    No C# tudo é PRIVATE (privado).

    Estruturas de Decisão
    
        if (condição - comparação) {
            // códigos a executar se verdadeiro
        }
        else
        {
            // códigos a executar se a condição for falsa
        }

        switch( variável )
        {
            case "valor" : // código a ser executado se verdadeiro
            break;
          default: // executado caso seja outro valor diferente dos mapeados    
        }

*/

using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Lanchonete_T92
{

    public static class Config
    {
        // Atributos - variáveis da classe é visível de qualquer membro da classe

        // armazena o tema atual 0 claro / 1 escuro
        public static string caminhos; 

        public static int tema = 0;

        // chave de criptografia do banco de dados
        public static string chaveCrypto = "$en@c2022";

        // ler o tamanho do monitor do usuário
        public static int[] tamanhoTela =
            { Screen.PrimaryScreen.Bounds.Width,
            Screen.PrimaryScreen.Bounds.Height };

        // armazena o caminho da instalação
        public static string caminho = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        // armzena nossas cores de fundo
        public static int[,] corFundo = { { 253, 229, 210 }, { 38, 40, 51 } };

        // armazena as imagens de fundo
        private static string[,] imagens = { 
            {
                "login.png", 
                "logo.png", 
                "fundo_form.png",
                "config.png",
                "sair.png",
                "menu.png"
            }, 
            {
                "login_d.png", 
                "logo_d.png", 
                "fundo_form_d.png",
                "config_d.png",
                "sair_d.png",
                "menu_d.png"
            }
        };


        // Credenciais do Banco de Dados
        public static string servidorBD = "localhost";// nome ou IP
        public static string portaBD = "3306"; // porta do servidor
        public static string usuarioBD = "root";
        public static string senhaBD = "";
        public static string bancoBD = "lanchonete_t92";

        public static void MostraMensagem(string texto)
        {
            MessageBox.Show( texto );
        }

        public static string CaminhosImagens( string imagem )
        {
            // estrutura de decisão
            switch ( imagem )
            {
                case "lateral":
                    return caminhos = Path.Combine(caminho, "Imagens\\" + imagens[tema, 0]);
                    break;

                case "logo":
                    return caminhos = Path.Combine(caminho, "Imagens\\" + imagens[tema, 1]);
                    break;

                case "campos":
                    return caminhos = Path.Combine(caminho, "Imagens\\" + imagens[tema, 2]);
                    break;

                case "config":
                    return caminhos = Path.Combine(caminho, "Imagens\\Icones\\" + imagens[tema, 3]);
                    break;

                case "sair":
                    return caminhos = Path.Combine(caminho, "Imagens\\Icones\\" + imagens[tema, 4]);
                    break;

                case "menu":
                    return caminhos = Path.Combine(caminho, "Imagens\\Icones\\" + imagens[tema, 5]);
                    break;

                default: return caminhos = "";
            }

        }
    }
}