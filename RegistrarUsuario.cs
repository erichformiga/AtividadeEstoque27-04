using System;
using System.Drawing;
using System.Windows.Forms;
using LoginProduto;

namespace RegistrarUsuario
{
    public partial class FrmRegUsuario : Form
    {
        private Label nameLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox nameTextBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button registerButton;

        public FrmRegUsuario()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Configurações da janela do formulário
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Text = "Registro de Usuário";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Configurações do rótulo de nome
            nameLabel = new Label();
            nameLabel.Text = "Nome:";
            nameLabel.Location = new Point(20, 30);
            nameLabel.Size = new Size(80, 20);
            this.Controls.Add(nameLabel);

            // Configurações do campo de texto de nome
            nameTextBox = new TextBox();
            nameTextBox.Location = new Point(100, 30);
            nameTextBox.Size = new Size(150, 20);
            this.Controls.Add(nameTextBox);

            // Configurações do rótulo de nome de usuário
            usernameLabel = new Label();
            usernameLabel.Text = "Usuário:";
            usernameLabel.Location = new Point(20, 60);
            usernameLabel.Size = new Size(80, 20);
            this.Controls.Add(usernameLabel);

            // Configurações do campo de texto de nome de usuário
            usernameTextBox = new TextBox();
            usernameTextBox.Location = new Point(100, 60);
            usernameTextBox.Size = new Size(150, 20);
            this.Controls.Add(usernameTextBox);

            // Configurações do rótulo de senha
            passwordLabel = new Label();
            passwordLabel.Text = "Senha:";
            passwordLabel.Location = new Point(20, 90);
            passwordLabel.Size = new Size(80, 20);
            this.Controls.Add(passwordLabel);

            // Configurações do campo de texto de senha
            passwordTextBox = new TextBox();
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Location = new Point(100, 90);
            passwordTextBox.Size = new Size(150, 20);
            this.Controls.Add(passwordTextBox);

            // Configurações do botão de registro
            registerButton = new Button();
            registerButton.Text = "Registrar";
            registerButton.Location = new Point(110, 130);
            registerButton.Size = new Size(80, 30);
            registerButton.Click += new EventHandler(RegisterButton_Click);
            this.Controls.Add(registerButton);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Criar instância da tela de registro
            FrmRegUsuario registerForm = new FrmRegUsuario();

            // Exibir a tela de registro
            registerForm.Show();

            // Esconder a tela de login (opcional)
            this.Hide();

            MessageBox.Show("Mensagem do botao registrar!");
        }
    }
}
//