using SaborDoBrasil.Repositorio;
using System.Collections.Generic;
using System.Linq;

namespace SaborDoBrasil.Dominio.Modelo
{
    public class Prato : EntidadeBase
    {
        public string Nome { get; set; }
        public bool Status { get; set; }

        public Receita Receita { get; set; }

        public void Cadastrar()
        {
            // Cadastro no banco de dados:
            
            // pratoRepositorio.Cadastrar(this); --> Adiciona diretamente a db. Verificação do perfil aqui ou lá?
            // this.Receita.Cadastrar(); --> Adiciona indiretamente a db.
        }

        public void Preparar()
        {
            EstoqueRepositorio estoqueRepositorio = new EstoqueRepositorio();

            List<Estoque> estoques = new List<Estoque>();
            int estoquesMenores = 0;

            foreach (KeyValuePair<Ingrediente, int> key in Receita.Ingredientes)
            {
                Estoque estoqueBaixo = estoqueRepositorio.BuscarTodos().FirstOrDefault<Estoque>(x => x.Ingrediente == key.Key);

                if (estoqueBaixo is null) 
                { 
                    return; // O ingrediente não está cadastrado, há algum problema!
                }
                else if (estoqueBaixo.QuantidadeAtual < key.Value)
                {
                      estoquesMenores++;
                }
            }

            if (estoquesMenores == 0) // Não existem estoques com quantidade insuficiente de ingredientes
            {
                foreach(KeyValuePair<Ingrediente, int> key in Receita.Ingredientes)
                {
                    Estoque estoque = estoqueRepositorio.BuscarTodos().FirstOrDefault<Estoque>(x => x.Ingrediente == key.Key);
                    estoque.AlterarQuantidade(-key.Value);
                }
            }
        }
    }
}
