using System;
using System.Drawing;
using System.Windows.Forms;
using ListarProduto;

namespace NovoSaldo
{
    public partial class FrmNovoSaldo : Form
    {
        private Label idLabel;
        private Label nomeprodutoLabel;
        private Label quantidadeprodutoLabel;
        private Label precoprodutoLabel;
        private TextBox idTextBox;
        private TextBox nomeTextBox;
        private TextBox quantidadeprodutoTextBox;
        private TextBox precoprodutoTextBox;
        private Button gravarButton;
        private Button sairButton;

        public FrmNovoSaldo()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Configuração da janela do formulário
            this.ClientSize = new System.Drawing.Size(300,400);
            this.Text = "Novo Produto.";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Configurações do id do produto
            idLabel = new Label();
            idLabel.Text = "Nome: ";
            idLabel.Location = new Point(20, 30);
            idLabel.Size = new Size(80, 20);
            this.Controls.Add(idLabel);

            // Configurações do campo texto de id do produto
            idTextBox = new TextBox();
            idTextBox.Location = new Point(100, 30);
            idTextBox.Size = new Size(150, 20);
            this.Controls.Add(idTextBox);

            // Configurações de rótulo de nome do produto
            nomeprodutoLabel = new Label();
            nomeprodutoLabel.Text = "Preço: ";
            nomeprodutoLabel.Location = new Point(20, 60);
            nomeprodutoLabel.Size = new Size(80, 20);
            this.Controls.Add(nomeprodutoLabel);

            // Configurando o Campo de texto de nome do produto
            nomeTextBox = new TextBox();
            nomeTextBox.Location = new Point(100, 60);
            nomeTextBox.Size = new Size(150, 20);
            this.Controls.Add(nomeTextBox);

            // Configurações do botao gravar
            gravarButton = new Button();
            gravarButton.Text = "Gravar";
            gravarButton.Location = new Point(70, 100);
            gravarButton.Size = new Size(80, 30);
            gravarButton.Click += new EventHandler(gravarButton_Click);
            this.Controls.Add(gravarButton);

            // Configurações do botão sair
            sairButton = new Button();
            sairButton.Text = "Sair";
            sairButton.Location = new Point(160, 100);
            sairButton.Size = new Size(80, 30);
            sairButton.Click += new EventHandler(sairButton_Click);
            this.Controls.Add(sairButton);
        }

         private void gravarButton_Click(object sender, EventArgs e)
        {
            // Autenticar usuário

            MessageBox.Show("Criar a função de Gravar!");
        }

         private void sairButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você realmente deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                //Application.Exit();
            }
        }
    }
}