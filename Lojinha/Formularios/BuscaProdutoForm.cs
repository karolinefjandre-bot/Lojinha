using Lojinha.BLL;
using Lojinha.Modelos;
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

        private void LimpaButton_Click(object sender, EventArgs e)
        {

            codigoTextBox.Clear();
            nomeTextBox.Clear();
            precoTextBox.Clear();
            estoqueTextBox.Clear();
        }

        private void IncluirButton_Click(object sender, EventArgs e)
        {
            ProdutoInformation produto = new ProdutoInformation();
            produto.Nome = nomeTextBox.Text;
            produto.Preco = Convert.ToDecimal(precoTextBox.Text);
            produto.Estoque = Convert.ToInt32(estoqueTextBox.Text);

            ProdutosBLL obj = new ProdutosBLL();
            obj.Incluir(produto);
            MessageBox.Show("O produto foi incluido com sucesso");
            codigoTextBox.Text = Convert.ToString(produto.Codigo);
        }

        private void AlterarButton_Click(object sender, EventArgs e)
        {

            if (codigoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Um produto deve ser selecionado para alteração");
                return;
            }
            else
                try
                {
                    ProdutoInformation produto = new ProdutoInformation();
                    produto.Codigo = int.Parse(codigoTextBox.Text);
                    produto.Nome = nomeTextBox.Text;
                    produto.Preco = Convert.ToDecimal(precoTextBox.Text);
                    produto.Estoque = Convert.ToInt32(estoqueTextBox.Text);

                    ProdutosBLL obj = new ProdutosBLL();
                    obj.Alterar(produto);
                    MessageBox.Show("Produto alterado com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {

            if (codigoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Um produto deve ser selecionado para exclusão");
            }
            else
                try
                {
                    int codigo = Convert.ToInt32(codigoTextBox.Text);
                    ProdutosBLL obj = new ProdutosBLL();
                    obj.Excluir(codigo);

                    MessageBox.Show("Produto excluído com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro exclusão: " + ex.Message.ToString());
                }
        }
    }
}
