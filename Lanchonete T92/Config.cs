/*
    Na POO existem 04 pilares:
        - Encapsulamento
            - Proteção dos dados na aplicação (acesso)
            - private é visível apenas na classe (arquivo)
            - public é visível de qualquer outra classe

        - Abstração
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

*/

using System.Windows.Forms;

namespace Lanchonete_T92
{

    public static class Config
    {
        // Atributos - variáveis da classe é visível de qualquer membro da classe
        
        // armazena o tema atual 0 claro / 1 escuro
        public static int tema = 0;

        // ler o tamanho do monitor do usuário
        public static int[] tamanhoTela =
            { Screen.PrimaryScreen.Bounds.Width, 
            Screen.PrimaryScreen.Bounds.Height };
    }
}