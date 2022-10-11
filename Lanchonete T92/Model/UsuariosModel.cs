/*
 
Classe que cria as funcionalidades (atributos e métodos) para os usuários do nosso sistema.

Paradigmas de Programação

    - Estruturada - repetindo várias vezes uma linha de código

    POO - cria classes que representam o que os elementos do sistema podem fazer.

Princípios da Programação Orientadas à Objetos - POO / OOP

    - Abstração - você pode usar um item sem saber como ele foi escrito.

*/

namespace Lanchonete_T92
{
    public class UsuarioModel
    {
        // Atributos/Variáveis
        public int idUsuario;
        public int nivelAcesso;

        // Métodos/Funções
        public void ManutencaoUsuarios()
        {

        }
        public string[] PegaDadosUsuario()
        {
            string[] dadosUsuario = { "" };
            return dadosUsuario;
        }
    }
}