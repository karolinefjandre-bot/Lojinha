using Lojinha.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lojinha.Formularios
{
    public partial class BuscaProdutoForm : Form
    {
        public BuscaProdutoForm()
        {
            InitializeComponent();
        }

        public void AtualizaGrid()
        {
            //Comunicação com a camada BLL
            ProdutosBLL obj = new ProdutosBLL();
            ProdutoDataGridView.DataSource = obj.Seleciona(filtroTextBox.Text);

            //Atualiza os objetos TextBox
            try
            {
                codigoTextBox.Text = ProdutoDataGridView[0, ProdutoDataGridView.CurrentRow.Index].Value.ToString();
                nomeTextBox.Text = ProdutoDataGridView[1, ProdutoDataGridView.CurrentRow.Index].Value.ToString();
                precoTextBox.Text = ProdutoDataGridView[2, ProdutoDataGridView.CurrentRow.Index].Value.ToString();
                estoqueTextBox.Text = ProdutoDataGridView[3, ProdutoDataGridView.CurrentRow.Index].Value.ToString();
            }
            catch (Exception)
            {
                codigoTextBox.Text = "";
                nomeTextBox.Text = "";
                precoTextBox.Text = "";
                estoqueTextBox.Text = "";
            }
        }

        private void BuscaProdutoForm_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            nomeTextBox.Focus();
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            //Comunicação com a camada BLL
            ProdutosBLL obj = new ProdutosBLL();
            ProdutoDataGridView.DataSource = obj.Seleciona(filtroTextBox.Text);

            //Atualiza os objetos TextBox
            try
            {
                codigoTextBox.Text = ProdutoDataGridView[0, ProdutoDataGridView.CurrentRow.Index].Value.ToString();
                nomeTextBox.Text = ProdutoDataGridView[1, ProdutoDataGridView.CurrentRow.Index].Value.ToString();
                precoTextBox.Text = ProdutoDataGridView[2, ProdutoDataGridView.CurrentRow.Index].Value.ToString();
                estoqueTextBox.Text = ProdutoDataGridView[3, ProdutoDataGridView.CurrentRow.Index].Value.ToString();
            }
            catch (Exception)
            {
                codigoTextBox.Text = "";
                nomeTextBox.Text = "";
                precoTextBox.Text = "";
                estoqueTextBox.Text = "";
            }
        }
    }
}
