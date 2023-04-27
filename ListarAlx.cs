using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovoAlx;

namespace ListarAlx
{
    public partial class FrmAlmoxarifado : Form
    {
        private Button novoButton;
        private Button alterarButton;
        private Button excluirButton;
        private Button cancelarButton;
        private Button sairButton;
        private DataGridView produtosDataGridView;

        public FrmAlmoxarifado()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Configurações da janela do formulário
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Text = "Listar Almoxarifados";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Configurações do botão de novo produto
            novoButton = new Button();
            novoButton.Text = "Novo";
            novoButton.Location = new Point(20, 340);
            novoButton.Size = new Size(80, 30);
            novoButton.Click += new EventHandler(NovoButton_Click);
            this.Controls.Add(novoButton);

            // Configurações do botão de alterar produto
            alterarButton = new Button();
            alterarButton.Text = "Alterar";
            alterarButton.Location = new Point(110, 340);
            alterarButton.Size = new Size(80, 30);
            alterarButton.Click += new EventHandler(AlterarButton_Click);
            this.Controls.Add(alterarButton);

            // Configurações do botão de excluir produto
            excluirButton = new Button();
            excluirButton.Text = "Excluir";
            excluirButton.Location = new Point(200, 340);
            excluirButton.Size = new Size(80, 30);
            excluirButton.Click += new EventHandler(ExcluirButton_Click);
            this.Controls.Add(excluirButton);

            // Configurações do botão de cancelar
            cancelarButton = new Button();
            cancelarButton.Text = "Cancelar";
            cancelarButton.Location = new Point(290, 340);
            cancelarButton.Size = new Size(80, 30);
            cancelarButton.Click += new EventHandler(CancelarButton_Click);
            this.Controls.Add(cancelarButton);

            // Configurações do botão de sair
            sairButton = new Button();
            sairButton.Text = "Sair";
            sairButton.Location = new Point(380, 340);
            sairButton.Size = new Size(80, 30);
            sairButton.Click += new EventHandler(SairButton_Click);
            this.Controls.Add(sairButton);

            // Configurações do grid de produtos
            produtosDataGridView = new DataGridView();
            produtosDataGridView.Location = new Point(20, 40);
            produtosDataGridView.Size = new Size(440, 280);
            produtosDataGridView.AllowUserToAddRows = false;
            produtosDataGridView.AllowUserToDeleteRows = false;
            produtosDataGridView.ReadOnly = true;
            produtosDataGridView.MultiSelect = false;
            produtosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            produtosDataGridView.AutoGenerateColumns = false;

            // Configuração das colunas do grid
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "Id";
            idColumn.HeaderText = "ID";
            idColumn.Width = 50;
            idColumn.ReadOnly = true;
            produtosDataGridView.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nomeColumn = new DataGridViewTextBoxColumn();
            nomeColumn.DataPropertyName = "Nome";
            nomeColumn.HeaderText = "Nome";
            nomeColumn.Width = 150;
            nomeColumn.ReadOnly = true;
            produtosDataGridView.Columns.Add(nomeColumn);
            DataGridViewTextBoxColumn precoColumn = new DataGridViewTextBoxColumn();
            precoColumn.DataPropertyName = "Preco";
            precoColumn.HeaderText = "Preço";
            precoColumn.Width = 70;
            precoColumn.ReadOnly = true;
            produtosDataGridView.Columns.Add(precoColumn);

            DataGridViewTextBoxColumn quantidadeColumn = new DataGridViewTextBoxColumn();
            quantidadeColumn.DataPropertyName = "Quantidade";
            quantidadeColumn.HeaderText = "Quantidade";
            quantidadeColumn.Width = 80;
            quantidadeColumn.ReadOnly = true;
            produtosDataGridView.Columns.Add(quantidadeColumn);

            this.Controls.Add(produtosDataGridView);
        }

        private void NovoButton_Click(object sender, EventArgs e)
        {
            FrmNovoAlx alx = new FrmNovoAlx();
            alx.Show();
            //throw new NotImplementedException();
        }

        private void AlterarButton_Click(object sender, EventArgs e)
        {
            // TODO: Adicionar código para alterar um produto selecionado
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            // TODO: Adicionar código para excluir um produto selecionado
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            // TODO: Adicionar código para cancelar a operação atual
        }

        private void SairButton_Click(object sender, EventArgs e)
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