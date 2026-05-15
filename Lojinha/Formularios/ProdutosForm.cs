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
    public partial class ProdutosForm : Form
    {
        public ProdutosForm()
        {
            InitializeComponent();
        }

        private void precoLlabel_Click(object sender, EventArgs e)
        {
        }

        private void inserirButton_Click(object sender, EventArgs e)
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

        private void alterarButton_Click(object sender, EventArgs e)
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

        private void excluirButton_Click(object sender, EventArgs e)
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro exclusão: " + ex.Message.ToString());
                }
        }
    }
    
}
