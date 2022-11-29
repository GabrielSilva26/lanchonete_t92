using System;
using System.Drawing;
using System.Windows.Forms; // importação dos componentes de tela win
using MySql.Data; // importa as bibliotecas de acesso ao MySql
using MySql.Data.MySqlClient;

namespace Lanchonete_T92
{
    class UsuariosController
    {
        Form form; // propriedade que armazena a tela UsuariosView
        private MySqlConnection conexao = null; // armazena a conexão com o BD

        // método construtor, executando automaticamente
        public UsuariosController(Form form)
        {
            this.form = form;

            //MessageBoxButtons botoes = MessageBoxButtons.YesNoCancel;

            //MostraMensagem("texto exibido", "título da caixinha", botoes);

            //ConectaBanco();

            PosicionaCampos(); // posiciona os TextBoxes
        }

        void MostraMensagem(string mensagem, string titulo, MessageBoxButtons botoes)
        {
            MessageBox.Show(mensagem, titulo, botoes);
        }

        void ConectaBanco()
        {
            // Quando nosso código pode gerar erro, por exemplo, por poroblemas de infra (internet, servidor fora do ar) temos que tratar o erro, impedindo que o programa feche usando o try/catch

            try
            {

                // objeto da classe de conexão com o MySQL
                MySqlConnection conexao = new MySqlConnection
                    ("server=localhost;port=3306;database=lanchonete_t92;uid=root;passoword=");


                // Abre a conexão com o banco
                conexao.Open();

                // enviamos a conexão para a propriedade da classe, assim outros métodos podem usar a mesma conexão sem abrir uma nova.
                this.conexao = conexao;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao ser conectar com o Banco de Dados. O erro foi: " + erro.ToString());
            }
        }
            void PosicionaCampos()
            {
            float margemTopoLinha1 = 0.092f;
            float margemTopoLinha2 = 0.045f;
            float margemTopoLinha4 = 0.0f;

            // manda criar o componente
            CriaTextBox("nomeTxt", 0.025f, margemTopoLinha1, 0.178f);
            CriaTextBox("sobrenomeTxt", 0.021f, margemTopoLinha1, 0.178f);
            CriaTextBox("cpfTxt", 0.021f, margemTopoLinha1, 0.116f);
            CriaTextBox("nascimentoTxt", 0.020f, margemTopoLinha1, 0.115f);
            CriaTextBox("cepTxt", 0.025f, margemTopoLinha2, 0.099f);
            CriaTextBox("logradouroTxt", 0.020f, margemTopoLinha2, 0.195f);
            CriaTextBox("númeroTxt", 0.021f, margemTopoLinha2, 0.066f);
            CriaTextBox("complementoTxt", 0.021f, margemTopoLinha2, 0.082f);
            CriaTextBox("bairroTxt", 0.023f, margemTopoLinha2, 0.094f);


            CriaBotao("maisEnderecoBtn", 0.014f, 0.04f, 0.02f, 0.02f);


            CriaTextBox("tipoTxt", 0.024f, margemTopoLinha2, 0.098f);
            CriaTextBox("telefoneTxt", 0.022f, margemTopoLinha2, 0.195f);

            CriaBotao("maisFoneBtn", 0.018f, 0.04f, 0.02f, 0.02f);

            CriaFoto("foto", 0.045f, 0.05f, 0.1f, 0.13f);

            CriaBotao("adicionaFoto", 0.09f, 0.05f, 0.025f, 0.125f);

            CriaTextBox("tipo2Txt", 0.024f, margemTopoLinha4, 0.099f);
            CriaTextBox("emailTxt", 0.020f, margemTopoLinha4, 0.196f);

            CriaBotao("maisEmailBtn", 0.015f, 0f, 0.02f, 0.02f);

            CriaTabela();

        }
        
        int CalculaTamanho (float tamanho)
        {
            int novoTamanho = Convert.ToInt32 (Config.tamanhoTela[0] * tamanho);

            return novoTamanho;
        }

        void CriaTextBox(string name, float esq, float topo, float larg )
        {
            TextBox campo = new TextBox();
            campo.BackColor = Color.Red; //Color.FromArgb(254, 239, 227);
            campo.Name = name;
            campo.Font = new Font(FontFamily.GenericSansSerif, 14);
            campo.BorderStyle = BorderStyle.None;
            

            form.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(campo);

            // esquerda, cima, direita, embaixo
            form.Controls.Find(name, true)[0].Margin = new Padding(CalculaTamanho(esq), CalculaTamanho(topo), 0, 0);
            form.Controls.Find(name, true)[0].Width = CalculaTamanho(larg);

        }

        void CriaBotao( string name, float esq, float topo, float larg, float alt )
        {
            Button botao = new Button();
            botao.Name = name;
            botao.Size = new Size(CalculaTamanho(larg), CalculaTamanho(alt) );
            botao.Margin = new Padding(CalculaTamanho(esq), CalculaTamanho(topo), 0, 0);

            form.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(botao);
            //form.Controls.Find(name, true)[0].Margin = new Padding(CalculaTamanho(esq), CalculaTamanho(topo), 0, 0);
            //form.Controls.Find(name, true)[0].Size = new Size( CalculaTamanho(larg), CalculaTamanho(alt));
        }

        void CriaFoto(string name, float esq, float topo, float larg, float alt)
        {
            PictureBox foto = new PictureBox();
            foto.Name = name;
            foto.Size = new Size(CalculaTamanho(larg), CalculaTamanho(alt));
            foto.Margin = new Padding(CalculaTamanho(esq), CalculaTamanho(topo), 0, 0);

            form.Controls.Find("FlowLayoutPanel1", true)[0].Controls.Add(foto);
            foto.BackColor = Color.Red;
        }
        void CriaTabela()
        {
            /* DatagridView é um componente que serve para mostrar dados em formato tabular.
             
             É uma matriz, ou seja, um vetor multidimensional.

             string[] nomes = { "nome1"; "nome2" };// vetor tem apenas uma dimensão - nomes [0] - nome1
             string[,] nomes = { "nome1", "nome2" }, {"nome3", "nome4"} } }; // nomes[1,0] - nome3

             */
            DataGridView tabela = new DataGridView();
            tabela.Name = "tabelaUsuarios";
            tabela.Width = CalculaTamanho(0.5f);

            // A tabela é alimentada por um vetor
            string[] nomes = { "nome1", "nome2", "nome3", "nome4" };

            // adicionando a coluna
            tabela.Columns.Add("nome", "Nomes Funcionários");

            // Colocando as colunas na ordem desejada
            tabela.Columns[0].DisplayIndex = 0;

            // fazendo a SELECT no Banco
            string SQL = "SELECT * FROM usuarios";

            // para rodar o comando se a conexão existe é criada
            if(conexao == null)
            {
                ConectaBanco();
            }
            try
            {
                // monta o comando SQL
                MySqlCommand roda = new MySqlCommand(SQL, conexao);
                // roda o comando montado
                // roda.ExecuteNonQuery();// executa sem trazer dados do BD (INSERT, UPDATE, DELETE)

                // para extrairmos os dados da busca usamos os métodos:
                // .GetString() - para retornar string
                // .GetInt() - inteiro
                // .GetBool() - verdadeiro/falso
                // .GetFloat() - traz um decimal

                // cria um objeto adaptador para o retorno do banco e a tabela
                MySqlDataAdapter adaptador = new MySqlDataAdapter(); 

                MessageBox.Show(roda.ExecuteReader().ToString()); // executa as Selects
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao buscar os dados");
            }

            // adicionando a linhas com os dados
            tabela.Rows.Add(nomes);

            // Adicionando um DataSource - os dados de um Select do BD
            //tabela.DataSource = nomes;

            // nomeando as colunas do DataGridView
            //tabela.Columns[0].Name = "Nome";

            form.Controls.Find("FlowLayoutPanel1", true)[0].Controls.Add(tabela);
        }
    }
}