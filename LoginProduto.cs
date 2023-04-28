using System;
using System.Drawing;
using System.Windows.Forms;
using RegistrarUsuario;
using ListarProduto;
using ListarAlx;
using ListarSaldo;

namespace LoginProduto
{
    public partial class FrmLogin : Form
    {
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Button registerButton;
        private Button produtoButton;
        private Button alxButton;
        private Button saldoButton;
        private Button conexaoButton;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Configurações da janela do formulário
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Text = "Login";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Configurações do rótulo de nome de usuário
            usernameLabel = new Label();
            usernameLabel.Text = "Usuário:";
            usernameLabel.Location = new Point(20, 30);
            usernameLabel.Size = new Size(80, 20);
            this.Controls.Add(usernameLabel);

            // Configurações do campo de texto de nome de usuário
            usernameTextBox = new TextBox();
            usernameTextBox.Location = new Point(100, 30);
            usernameTextBox.Size = new Size(150, 20);
            this.Controls.Add(usernameTextBox);

            // Configurações do rótulo de senha
            passwordLabel = new Label();
            passwordLabel.Text = "Senha:";
            passwordLabel.Location = new Point(20, 60);
            passwordLabel.Size = new Size(80, 20);
            this.Controls.Add(passwordLabel);

            // Configurações do campo de texto de senha
            passwordTextBox = new TextBox();
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Location = new Point(100, 60);
            passwordTextBox.Size = new Size(150, 20);
            this.Controls.Add(passwordTextBox);

            // Configurações do botão de login
            loginButton = new Button();
            loginButton.Text = "Login";
            loginButton.Location = new Point(70, 100);
            loginButton.Size = new Size(80, 30);
            loginButton.Click += new EventHandler(LoginButton_Click);
            this.Controls.Add(loginButton);

            // Configurações do botão de registro
            registerButton = new Button();
            registerButton.Text = "Registrar";
            registerButton.Location = new Point(160, 100);
            registerButton.Size = new Size(80, 30);
            registerButton.Click += new EventHandler(RegisterButton_Click);
            this.Controls.Add(registerButton);

            // Configurações do botão Teste para chamar a tela de produtos
            produtoButton = new Button();
            produtoButton.Text = "PRODUTO";
            produtoButton.Location = new Point(110, 150);
            produtoButton.Size = new Size(80, 30);
            produtoButton.Click += new EventHandler(ProdutoButton_Click);
            this.Controls.Add(produtoButton);

            // Configurações do botão Teste para chamar a tela de produtos
            produtoButton = new Button();
            produtoButton.Text = "ALX";
            produtoButton.Location = new Point(110, 180);
            produtoButton.Size = new Size(80, 30);
            produtoButton.Click += new EventHandler(AlxButton_Click);
            this.Controls.Add(produtoButton);

            // Configurações do botão Teste para chamar a tela de produtos
            produtoButton = new Button();
            produtoButton.Text = "SALDO";
            produtoButton.Location = new Point(110, 210);
            produtoButton.Size = new Size(80, 30);
            produtoButton.Click += new EventHandler(SaldoButton_Click);
            this.Controls.Add(produtoButton);

            // Configurações do botão para testar conexao com banco
            produtoButton = new Button();
            produtoButton.Text = "CONEXAO";
            produtoButton.Location = new Point(110, 240);
            produtoButton.Size = new Size(80, 30);
            produtoButton.Click += new EventHandler(Testeconexao_Click);
            this.Controls.Add(produtoButton);
        }
            // Chama Form Listar Produtos
        private void ProdutoButton_Click(object? sender, EventArgs e)
        {
            FrmProdutos produto = new FrmProdutos();
            produto.Show();
            //throw new NotImplementedException();
        }
            // Chama Form Listar Alx
        private void AlxButton_Click(object? sender, EventArgs e)
        {
            FrmAlmoxarifado alx = new FrmAlmoxarifado();
            alx.Show();
            //throw new NotImplementedException();
        }
            // Chama Form Listar Saldos
        private void SaldoButton_Click(object? sender, EventArgs e)
        {
            FrmSaldos saldo = new FrmSaldos();
            saldo.Show();
            //throw new NotImplementedException();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Autenticar usuário

            MessageBox.Show("TESTANDO MSG BOTAO LOGIN!");
        }
        // Chamando o Formulário FrmRegUsuario
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            FrmRegUsuario frmRegUsuario = new FrmRegUsuario();
            frmRegUsuario.Show();
        }
        // Testando conexao com o banco
        private void Testeconexao_Click(object? sender, EventArgs e)
        {

            try
            {
                Conexao conexao = new Conexao();
                if (conexao.Database.CanConnect()) {
                    MessageBox.Show("Conexão bem sucedida!"); // Mostrar mensagem de sucesso

                } else {
                    MessageBox.Show("Conexão mal sucedida!"); // Mostrar mensagem de sucesso
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message); // Mostrar mensagem de erro
            }
        }

    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}