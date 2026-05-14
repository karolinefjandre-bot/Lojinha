using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lojinha.DAL;
using Lojinha.Modelos;

namespace Lojinha.BLL
{
    public class ClientesBLL
    {
        public void Incluir(ClienteInformation cliente)
        {
            //o nome do cliente é obrigatório
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            cliente.Nome = cliente.Nome.Trim();
            //Email é sempre em letras minúsculas
            cliente.Email = cliente.Email.ToLower();
            //Se está tudo Ok, chama a rotina de inserção
            ClientesDAL obj = new ClientesDAL();   
            obj.Incluir(cliente);  
        }
        public void Alterar(ClienteInformation cliente)
        {

            //o nome do cliente é obrigatório
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            cliente.Nome = cliente.Nome.Trim();
            //Email é sempre em letras minúsculas
            cliente.Email = cliente.Email.ToLower();
            //Se está tudo Ok, chama a rotina de alteração
            ClientesDAL obj = new ClientesDAL();
            obj.Alterar(cliente);
        }   

        public void Excluir(int codigo)
        {
            if(codigo < 1)
            {
                throw new Exception("Selecione um cliente antes de excluir");
            }
            ClientesDAL obj = new ClientesDAL();
            obj.Excluir(codigo);
        }
        public DataTable Seleciona(string filtro)
        {
            ClientesDAL obj = new ClientesDAL();
            return obj.Seleciona(filtro);
        }
    }
}
