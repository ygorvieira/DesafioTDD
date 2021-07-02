using System;

namespace DesafioTDD
{
    public class CadastroService
    {
        private const decimal TaxaVenda = 0.15M;

        public static Produto CadastroProduto(Produto produto)
        {
            if (VerificaProduto(produto))
            {
                produto.ValorVenda = produto.ValorCusto + (produto.ValorCusto * TaxaVenda);
                Console.WriteLine("Produto cadastrado com sucesso!");

                return produto;
            }
            else
            {
                produto.Codigo = null;
                return produto;
            }
        }

        private static bool VerificaProduto(Produto produto)
        {
            return ValidaCodigo(produto) && ValidaNome(produto) && ValidaDescricao(produto) && ValidaCusto(produto);
        }

        private static bool ValidaCusto(Produto produto)
        {
            return !(produto.ValorCusto <= 0);
        }

        private static bool ValidaDescricao(Produto produto)
        {
            if (produto.Descricao != null)
            {
                return !(produto.Descricao.Length > 500);
            }
            else return true;
        }

        private static bool ValidaNome(Produto produto)
        {
            return !(produto.Nome == null || produto.Nome.Length > 100);
        }

        private static bool ValidaCodigo(Produto produto)
        {
            if (produto.Codigo != null)
            {
                return !(produto.Codigo.Length <= 0 || produto.Codigo.Length != 6);
            }
            else return true;
        }
    }
}
