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

        public bool EstaDisponivel()
        {
            EstoqueRepositorio estoqueRepositorio = new EstoqueRepositorio(); // Banco de dados dos Estoques (não ficará aqui)

            for (int i = 0; i < Receita.Ingredientes.Count; i++)
            {
                Estoque estoqueBaixo = estoqueRepositorio.BuscarTodos().FirstOrDefault<Estoque>(x => x.Ingrediente == Receita.Ingredientes[i]);

                if (estoqueBaixo is null || estoqueBaixo.QuantidadeAtual < Receita.QuantidadesIngrediente[i])
                {
                    return false; // O ingrediente não está cadastrado ou existe falta de ingredientes, há algum problema!
                }
            }

            return true;
        }

        public void Preparar()
        {
            EstoqueRepositorio estoqueRepositorio = new EstoqueRepositorio(); // Banco de dados dos Estoques (não ficará aqui)

            if (EstaDisponivel())
            {
                for (int i = 0; i < Receita.Ingredientes.Count; i++)
                {
                    Estoque estoque = estoqueRepositorio.BuscarTodos().FirstOrDefault<Estoque>(x => x.Ingrediente == Receita.Ingredientes[i]);
                    estoque.AlterarQuantidade(-Receita.QuantidadesIngrediente[i]);
                }
            }
        }
    }
}