using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;// importação dos componentes de tela win
using MySql.Data; // importa as bibliotecas de acesso ao Mysql
using MySql.Data.MySqlClient;

namespace Lanchonete_T92
{

    class UsuariosController
    {
        Form form;// propriedade que armazena a tela UsuariosView
        DataGridView tab;

        MySqlConnection conexao = null;// armazena a conexão com o BD

        // método construtor, executado automaticamente 
        public UsuariosController(Form form)
        {
            this.form = form;

            //MessageBoxButtons botoes = MessageBoxButtons.YesNoCancel;

            //MostraMensagem(" texto exibido ", " título da caixinha", botoes );

            // ConectaBanco();

            PosicionaCampos(); // posiciona os TextBoxes

        }

        void MostraMensagem(string mensagem, string titulo, MessageBoxButtons botoes)
        {

            MessageBox.Show(mensagem, titulo, botoes);
        }

        // conectar ao banco de dados
        void ConectaBanco()
        {
            // Quando nosso código pode gerar erro, por exemplo, por problemas de infra (internet, servidor fora do ar) temos que tratar o erro, impedindo que o programa feche usando o try/catch

            try
            {
                // objeto da classe de conexão com mysql
                MySqlConnection conexao = new MySqlConnection(" server=localhost;port=3306;database=lanchonete_t92;uid=root;password=");

                // Abre a conexao com o banco
                conexao.Open();

                // enviamos a conexão para a propriedade da classe, assim outros métodos podem usar a mesma conexão sem abrir uma nova.
                this.conexao = conexao;

            }
            catch (Exception erro)
            {
                MessageBox.Show(" Erro ao se conectar ao Banco de Dados. O erro foi: " + erro.ToString());
            }

        }

        void PosicionaCampos()
        {
            float margemTopoLinha1 = 0.0915f;
            float margemTopoLinha2 = 0.042f;

            // manda criar o componente
            CriaTextBox("nomeTxt", 0.025f, margemTopoLinha1, 0.178f, "flowLayoutPanel1");
            CriaTextBox("sobreNomeTxt", 0.021f, margemTopoLinha1, 0.178f, "flowLayoutPanel1");
            CriaTextBox("cpfTxt", 0.021f, margemTopoLinha1, 0.115f, "flowLayoutPanel1");
            CriaTextBox("nascimentoTxt", 0.021f, margemTopoLinha1, 0.115f, "flowLayoutPanel1");

            CriaTextBox("cepTxt", 0.025f, margemTopoLinha2, 0.097f, "flowLayoutPanel1");
            CriaTextBox("logradouroTxt", 0.022f, margemTopoLinha2, 0.195f, "flowLayoutPanel1");
            CriaTextBox("numeroTxt", 0.022f, margemTopoLinha2, 0.066f, "flowLayoutPanel1");
            CriaTextBox("complementoTxt", 0.022f, margemTopoLinha2, 0.083f, "flowLayoutPanel1");
            CriaTextBox("bairroTxt", 0.022f, margemTopoLinha2, 0.083f, "flowLayoutPanel1");

            CriaBotao("maisEnderecoBtn", 0.02f, 0.02f, 0.02f, 0.04f, "flowLayoutPanel1");

            CriaTextBox("tipoTxt", 0.025f, margemTopoLinha2, 0.095f, "flowLayoutPanel1");
            CriaTextBox("telefoneTxt", 0.022f, margemTopoLinha2, 0.195f, "flowLayoutPanel1");

            CriaBotao("maisFoneBtn", 0.02f, 0.02f, 0.02f, 0.04f, "flowLayoutPanel1");

            OrganizaCampos();// cria a caixa organiza

            CriaTextBox("tipo2Txt", 0.025f, 0.042f, 0.095f, "organiza");
            CriaTextBox("emailTxt", 0.022f, 0.042f, 0.195f, "organiza");
            CriaBotao("maisEmailBtn", 0.02f, 0.02f, 0.02f, 0.039f, "organiza");

            CriaFoto("foto", 0.09f, 0.125f, 0.044f, 0.0f, "organiza");

            CriaBotao("adicionaFoto", 0.09f, 0.125f, 0.025f, 0.0f, "organiza");

            CriaTabela();

            // larg 0.075f / alt 0.075f / esq 0.026f / topo 0.05f
            CriaBotao("salvaCadastro", 0.075f, 0.026f, 0.24f, 0.05f, "flowLayoutPanel1");

            // larg 0.09f / alt 0.026f /esq 0.04f / topo 0.05f
            CriaBotao("cancelaCadastro", 0.09f, 0.026f, 0.04f, 0.05f, "flowLayoutPanel1");

            // Colocando os Ouvintes (LISTENERS) dos botões 
            form.Controls.Find("salvaCadastro", true)[0].Click += InsereDados;

        }

        int CalculaTamanho(float tamanho)
        {
            int novoTamanho = Convert.ToInt32(Config.tamanhoTela[0] * tamanho);

            return novoTamanho;
        }

        void CriaTextBox(string name, float esq, float topo, float larg, string onde)
        {
            TextBox campo = new TextBox();
            campo.BackColor = Color.FromArgb(254, 239, 227);
            campo.Name = name;
            campo.Font = new Font(FontFamily.GenericSansSerif, 14);
            //campo.BorderStyle = BorderStyle.None;

            form.Controls.Find(onde, true)[0].Controls.Add(campo);

            // esquerda, cima, direita, embaixo
            form.Controls.Find(name, true)[0].Margin = new Padding(CalculaTamanho(esq), CalculaTamanho(topo), 0, 0);
            form.Controls.Find(name, true)[0].Width = CalculaTamanho(larg);

        }

        void CriaBotao(string nome, float larg, float alt, float esq, float topo, string onde)
        {
            Button botao = new Button();
            botao.Name = nome;
            botao.Size = new Size(CalculaTamanho(larg), CalculaTamanho(alt));
            botao.Margin = new Padding(CalculaTamanho(esq), CalculaTamanho(topo), 0, 0);

            botao.BackColor = Color.Transparent;
            botao.FlatStyle = FlatStyle.Flat;
            botao.FlatAppearance.BorderSize = 0;
            botao.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botao.FlatAppearance.MouseOverBackColor = Color.Transparent;

            botao.Cursor = Cursors.Hand;

            form.Controls.Find(onde, true)[0].Controls.Add(botao);

        }

        void CriaFoto(string nome, float larg, float alt, float esq, float topo, string onde)
        {
            PictureBox foto = new PictureBox();
            foto.Name = nome;
            foto.Size = new Size(CalculaTamanho(larg), CalculaTamanho(alt));
            foto.Margin = new Padding(CalculaTamanho(esq), CalculaTamanho(topo), 0, 0);
            foto.BackColor = Color.Red;

            form.Controls.Find(onde, true)[0].Controls.Add(foto);
        }

        void CriaTabela()
        {
            /* 
              DatagridView é um componente que serve para mostrar dados em formato tabular.
            
              É uma matriz, ou seja, um vetor multidimensional.
              
              string[] nomes = { "nome1", "nome2" };// vetor tem apenas uma dimensão - nomes[0] - nome1
              
            string [,] nomes = { { "nome1", "nome2" }, {"nome3", "nome4"} }; // nomes[1,0] - nome3
            
             */
            DataGridView tabela = new DataGridView();
            tabela.Name = "tabelaUsuarios";
            tabela.Width = CalculaTamanho(0.62f);
            tabela.Margin = new Padding(CalculaTamanho(0.025f), CalculaTamanho(0.037f), 0, 0);

            form.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(tabela);

            // A tabela é alimentada por um vetor
            //string[] nomes = { "Felipe", "nome2", "nome3", "nome4" };

            // adicionando a coluna
            //tabela.Columns.Add("nome", "Nomes Funcionários");

            // Colocando as colunas na ordem desejada
            //tabela.Columns[0].DisplayIndex = 0;

            // adicionando a linhas com os dados
            //tabela.Rows.Add(nomes);

            // fazendo a SELECT no Banco
            string SQL = "SELECT usuarios.id_usuario, usuarios.login, enderecos.logradouro, telefones.telefone, emails.email FROM usuarios INNER JOIN enderecos ON usuarios.id_usuario = enderecos.usuarios_id_usuario INNER JOIN telefones ON usuarios.id_usuario = telefones.usuarios_id_usuario INNER JOIN emails ON usuarios.id_usuario = emails.usuarios_id_usuario ORDER BY id_usuario DESC";

            // para rodar o comando se a conexão não existe é criada
            if (conexao == null)
            {
                ConectaBanco();
            }

            try
            {
                // monta o comando SQL
                //MySqlCommand roda = new MySqlCommand(SQL, conexao);
                // roda o comando montado

                //roda.ExecuteNonQuery();// executa sem trazer dados do BD (INSERT, UPDATE, DELETE)

                // para extrairmos os dados da busca usamos os métodos:
                // .GetString() - para retornar string
                // .GetInt() - inteiros
                // .GetBool() - verdadeiro/falso
                // .GetFloat() - traz um decimal

                // cria um objeto adaptador para o retorno do banco e a tabela
                MySqlDataAdapter adaptador = new MySqlDataAdapter(SQL, conexao);

                // DataSet que aplica o resultado na tabela
                DataSet dados = new DataSet();

                // criando o DataMember
                tabela.DataMember = "funcionarios";

                // executa o comando no banco
                adaptador.Fill(dados, "funcionarios");

                // a tabela monta automaticamente as colunas
                tabela.AutoGenerateColumns = true;

                // colocando os dados na tabela
                tabela.DataSource = dados;

                // retirando apenas o primeiro registro da coluna login
                //MessageBox.Show( dados.Tables[0].Rows[0]["login"].ToString() );

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao buscar os dados." + erro.ToString());
            }

            // Adicionando um DataSource - os dados de um Select do BD
            //tabela.DataSource = nomes;

            // nomeando as colunas do DataGridView
            //tabela.Columns[0].Name = "Nome";


        }

        void OrganizaCampos()
        {
            FlowLayoutPanel organiza = new FlowLayoutPanel();
            organiza.Name = "organiza";
            organiza.FlowDirection = FlowDirection.LeftToRight;

            organiza.Width = CalculaTamanho(0.7f);
            organiza.Height = CalculaTamanho(0.1f);

            organiza.Margin = new Padding(0, CalculaTamanho(0.001f), 0, 0);

            form.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(organiza);
        }

        void InsereDados(object objeto, EventArgs evento)
        {
            try
            {
                // campos da tela
                string usuario = form.Controls.Find("emailTxt", true)[0].Text;
                string nome = form.Controls.Find("nomeTxt", true)[0].Text;
                string sobrenome = form.Controls.Find("sobrenomeTxt", true)[0].Text;
                string cpf = form.Controls.Find("cpfTxt", true)[0].Text;
                string nascimento = form.Controls.Find("nascimentoTxt", true)[0].Text;

                string tipo = form.Controls.Find("tipoTxt", true)[0].Text;
                string logradouro= form.Controls.Find("logradouroTxt", true)[0].Text;
                string numero= form.Controls.Find("numeroTxt", true)[0].Text; 
                string cep= form.Controls.Find("cepTxt", true)[0].Text;
                string complemento= form.Controls.Find("complementoTxt", true)[0].Text;

                string pais= "55";
                string ddd = "11";
                string telefone= form.Controls.Find("telefoneTxt", true)[0].Text;

                string email= form.Controls.Find("emailTxt", true)[0].Text;
                string tipo2= form.Controls.Find("tipo2Txt", true)[0].Text;
                string senhaLimpa = GeraSenha();

                // Etapas do CRUD - Inserir, Ler, Atualizar e Apagar - manutenção
                // 1º Conectar ao banco ( ConectaBanco() já fez isso )
                // 2º Escrever o SQL
                string SQL = " INSERT INTO usuarios ( login, senha ) VALUES ( '" + usuario + "', AES_ENCRYPT( '" + senhaLimpa + "', '" + Config.chaveCrypto + "') ) ";

                // traz o último auto incremento criado na tabela usuários que é nossa PK usada como FK nas demais tabelas
                string sqlFK = " SELECT LAST_INSERT_ID()";
                // prepara o sql quando é um SELECT
                MySqlDataAdapter rodaFK = new MySqlDataAdapter(sqlFK, conexao);
                // organizamos o retorno em um DataSet
                DataSet dadosFK = new DataSet();
                // preenchendo o DataSet
                rodaFK.Fill( dadosFK );
                // extraimos o valor encontrado
                string pegaFK = dadosFK.Tables[0].Rows[0].ToString();

                string SQL2 = " INSERT INTO cadastros ( nome, sobrenome, cpf, nascimento, usuarios_id_usuario ) VALUES ( '"+ nome +"', '"+ sobrenome +"', '"+ cpf +"', '"+ nascimento +"', ( SELECT LAST_INSERT_ID() ) )";

                string SQL3 = " INSERT INTO enderecos ( tipo, logradouro, numero, cep, complemento, usuarios_id_usuario ) VALUES ( '1', '" + logradouro +"', '" + numero +"', '" + cep +"', '" + complemento +"', ( SELECT LAST_INSERT_ID() ) )";

                string SQL4 = " INSERT INTO telefones ( pais, ddd, telefone, tipo, usuarios_id_usuario ) VALUES ( '55', '11', '"+ telefone +"', '"+ tipo +"', ( SELECT LAST_INSERT_ID() ) )";

                string SQL5 = " INSERT INTO emails ( email, usuarios_id_usuario ) VALUES ( '"+ email + "', ( SELECT LAST_INSERT_ID() ))";

                // 3º Montar o código
                MySqlCommand roda = new MySqlCommand(SQL, conexao);
                MySqlCommand roda2 = new MySqlCommand(SQL2, conexao);
                MySqlCommand roda3 = new MySqlCommand(SQL3, conexao);
                MySqlCommand roda4 = new MySqlCommand(SQL4, conexao);
                MySqlCommand roda5 = new MySqlCommand(SQL5, conexao);

                //Se o campo está com valor, foi preenchido
                if (usuario != "")
                {
                    // 4ª Executar o código
                    roda.ExecuteNonQuery(); // cadastra o usuário PK
                    // pegue o ID usuáio cadastrado anteriormente FK
                    roda2.ExecuteNonQuery();
                    roda3.ExecuteNonQuery();
                    roda4.ExecuteNonQuery();
                    roda5.ExecuteNonQuery();

                    MessageBox.Show(" Registro Inserido");
                    // envia um email com a senha para o funcionário PHP
                }
                else
                {
                    MessageBox.Show("Preencha os campos obrigatórios");
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar. " + erro.ToString());
            }

        }

        string GeraSenha()
        {
            string senha = null;

            //Objeto que sorteará os valores
            Random valores = new Random();
            Random numeros = new Random();

            string[] palavras = { "Lorem", "ipsum", "dolor", "sit", "amet" };

            string datas = DateTime.Now.ToString();// pega dia e hora atual

            //MessageBox.Show(datas);

            //MessageBox.Show( "" + palavras[ valores.Next( palavras.Length ) ] );

            senha = "Lanchonete" + palavras[valores.Next(palavras.Length)] + numeros.Next(1, 1000);

            //MessageBox.Show(senha);

            return senha;
        }




        void MostraID(object objeto, DataGridViewCellEventArgs evento)
        {
            // pega o id clicado da linha clicada
            int id = evento.RowIndex;

            int idFunc = (int)tab.Rows[id].Cells[0].Value;

            // Editando os botões
            //MessageBoxManager.Cancel = "Cancelar";
            //MessageBoxManager.Yes = "Editar";
            //MessageBoxManager.No = "Apagar";
            //MessageBoxManager.Register();

            DialogResult resposta = MessageBox.Show("O que deseja fazer?", "CRUD", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                MessageBox.Show("Escolheu Editar");
            }

            if (resposta == DialogResult.No)
            {
                MessageBox.Show("Escolheu Apagar");
            }

        }


    }

}