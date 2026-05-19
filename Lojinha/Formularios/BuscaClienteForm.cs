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
    }
}
