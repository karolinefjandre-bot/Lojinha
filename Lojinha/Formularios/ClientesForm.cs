using Lojinha.BLL;
using Lojinha.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lojinha.Formularios
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void incluirButton_Click(object sender, EventArgs e)
        {
            ClienteInformation cliente = new ClienteInformation();
            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextbox.Text;
            cliente.Telefone = telefoneTextbox.Text;

            ClientesBLL obj = new ClientesBLL();
            obj.Incluir(cliente);
            MessageBox.Show("O cliente foi incluido com sucesso");
            codigoTextBox.Text = Convert.ToString(cliente.Codigo);
        }

        private void alterarButton_Click(object sender, EventArgs e)
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
                    cliente.Email = emailTextbox.Text;
                    cliente.Telefone = telefoneTextbox.Text;

                    ClientesBLL obj = new ClientesBLL();
                    obj.Alterar(cliente);
                    MessageBox.Show("Cliente alterado com sucesso");
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

            

        }

        private void excluirButton_Click(object sender, EventArgs e)
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro exclusão: " + ex.Message.ToString());
                }
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            codigoTextBox.Clear();
            nomeTextBox.Clear();
            emailTextbox.Clear();
            telefoneTextbox.Clear();
        }
    }
}
