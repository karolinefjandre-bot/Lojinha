using Lojinha.DAL;
using Lojinha.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lojinha.BLL
{
    internal class ProdutosBLL
    {
        public void Incluir(ProdutoInformation produto)
        {
            //o nome do cliente é obrigatório
            if (produto.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }
            produto.Nome = produto.Nome.Trim();
            //Se está tudo Ok, chama a rotina de inserção
            ProdutoDAL obj = new ProdutoDAL();
            obj.Inserir(produto);
        }
        public void Alterar(ProdutoInformation produto)
        {

            //o nome do cliente é obrigatório
            if (produto.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }
            produto.Nome = produto.Nome.Trim();
            //Se está tudo Ok, chama a rotina de alteração
            ProdutoDAL obj = new ProdutoDAL();
            obj.Alterar(produto);
        }

        public void Excluir(int codigo)
        {
            if (codigo < 1)
            {
                throw new Exception("Selecione um produto antes de excluir");
            }
            ProdutoDAL obj = new ProdutoDAL();
            obj.Excluir(codigo);
        }
        public DataTable Seleciona(string filtro)
        {
            ProdutoDAL obj = new ProdutoDAL();
            return obj.Seleciona(filtro);
        }
    }
}

    
    
