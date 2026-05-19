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
    public partial class BuscaClienteForm : Form
    {
        public BuscaClienteForm()
        {
            InitializeComponent();
        }

        public void AtualizaGrid()
        { 
            //Comunicação com a camada BLL
            ClientesBLL obj = new ClientesBLL();
            ClientesDataGridView.DataSource = obj.Seleciona(filtroTextBox.Text);

            //Atualiza os objetos TextBox
            try 
            { 
              codigoTextBox.Text = ClientesDataGridView[0, ClientesDataGridView.CurrentRow.Index].Value.ToString();
              nomeTextBox.Text = ClientesDataGridView[1, ClientesDataGridView.CurrentRow.Index].Value.ToString();
              emailTextBox.Text = ClientesDataGridView[2, ClientesDataGridView.CurrentRow.Index].Value.ToString();
              telefoneTextBox.Text = ClientesDataGridView[3, ClientesDataGridView.CurrentRow.Index].Value.ToString();
            }
            catch (Exception)
            { 
               codigoTextBox.Text = "";
               nomeTextBox.Text = "";
               emailTextBox.Text = "";
               telefoneTextBox.Text = "";
            }
        }

        private void BuscaClienteForm_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            nomeTextBox.Focus();
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            //Comunicação com a camada BLL
            ClientesBLL obj = new ClientesBLL();
            ClientesDataGridView.DataSource = obj.Seleciona(filtroTextBox.Text);

            //Atualiza os objetos TextBox
            try
            {
                codigoTextBox.Text = ClientesDataGridView[0, ClientesDataGridView.CurrentRow.Index].Value.ToString();
                nomeTextBox.Text = ClientesDataGridView[1, ClientesDataGridView.CurrentRow.Index].Value.ToString();
                emailTextBox.Text = ClientesDataGridView[2, ClientesDataGridView.CurrentRow.Index].Value.ToString();
                telefoneTextBox.Text = ClientesDataGridView[3, ClientesDataGridView.CurrentRow.Index].Value.ToString();
            }
            catch (Exception)
            {
                codigoTextBox.Text = "";
                nomeTextBox.Text = "";
                emailTextBox.Text = "";
                telefoneTextBox.Text = "";
            }
        }

        private void LimparButton_Click(object sender, EventArgs e)
        {
            codigoTextBox.Clear();
            nomeTextBox.Clear();
            emailTextBox.Clear();
            telefoneTextBox.Clear();
        }

        private void IncluirButton_Click(object sender, EventArgs e)
        {
            ClienteInformation cliente = new ClienteInformation();
            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.Telefone = telefoneTextBox.Text;

            ClientesBLL obj = new ClientesBLL();
            obj.Incluir(cliente);
            MessageBox.Show("O cliente foi incluido com sucesso");
            codigoTextBox.Text = Convert.ToString(cliente.Codigo);
        }

        private void AlterarButton_Click(object sender, EventArgs e)
        {

            if (codigoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Um cliente deve ser selecionado para alteração");
                return;
            }
            else
                try
                {
                    ClienteInformation cliente = new ClienteInformation();
                    cliente.Codigo = int.Parse(codigoTextBox.Text);
                    cliente.Nome = nomeTextBox.Text;
                    cliente.Email = emailTextBox.Text;
                    cliente.Telefone = telefoneTextBox.Text;

                    ClientesBLL obj = new ClientesBLL();
                    obj.Alterar(cliente);
                    MessageBox.Show("Cliente alterado com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            if(codigoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Um cliente deve ser selecionado para exclusão");
            }
            else
                try
                {
                    int codigo = Convert.ToInt32(codigoTextBox.Text);
                    ClientesBLL obj = new ClientesBLL();
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
