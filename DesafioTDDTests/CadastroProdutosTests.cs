using DesafioTDD;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioTDDTests
{
    [TestClass]
    public class CadastroProdutosTests
    {

        //- Os campos obrigatórios serão: ‘Nome’, ‘Código do produto’ e ‘Valor de custo’
        [TestMethod]
        public void CadastroProdutoAoInserirDadosInvalidosDeveRetornarCadastroInvalido()
        {
            var produto = new Produto
            {
                Descricao = "Naruto"
            };

            var resultado = CadastroService.CadastroProduto(produto);
            Assert.IsNull(resultado.Codigo);
        }

        //- O campo ‘Valor de custo’ deve ser maior do que zero
        [TestMethod]
        public void CadastroProdutoAoInserirValorNegativoDeveRetornarCadastroInvalido()
        {
            var produto = new Produto
            {
                Nome = "Produto",
                Codigo = "100000",
                ValorCusto = -1
            };

            var resultado = CadastroService.CadastroProduto(produto);
            Assert.IsNull(resultado.Codigo);
        }

        //- A quantidade de caracteres do campo ‘Nome’ deve ser inferior a 100
        [TestMethod]
        public void CadastroProdutoAoInserirNomeAcimaDoLimiteDeCaracteresRetornaCadastroInvalido()
        {
            var produto = new Produto
            {
                Nome = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ipsum nisi, facilisis ac erat nec, vestibulum sagittis sem. Sed tristique lobortis lorem, quis vulputate diam tincidunt quis. Aenean dictum ligula ut placerat bibendum. Cras finibus, quam eu elementum sodales, est risus elementum leo, a placerat ex erat sit amet quam. Quisque molestie pulvinar odio vel rutrum. Praesent nec euismod nisl, vitae placerat turpis. Fusce non laoreet nisi. Aliquam faucibus ac dolor quis congue. Aliquam erat volutpat. Nullam in pretium dui, nec tristique dolor. Sed turpis risus, rutrum et porttitor at, aliquam a nisi. Cras viverra nisi id dolor hendrerit malesuada.",
                Codigo = "100000",
                ValorCusto = 10
            };

            var resultado = CadastroService.CadastroProduto(produto);
            Assert.IsNull(resultado.Codigo);
        }

        //- A quantidade de caracteres do campo ‘Descrição’ deve ser inferior a 500
        [TestMethod]
        public void CadastroProdutoAoInserirDescricaoAcimaDoLimiteDeCaracteresRetornaCadastroInvalido()
        {
            var produto = new Produto
            {
                Nome = "Produto Teste",
                Descricao = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eu fermentum lorem, efficitur varius nisi. Pellentesque vel nunc et justo pulvinar suscipit. Praesent venenatis finibus dui, a sagittis nisi tempus eu. Curabitur eros ante, cursus eu velit pulvinar, tempus ornare arcu. Maecenas non porttitor justo, et finibus mi. Pellentesque congue felis ante. Sed efficitur mauris ac consequat mollis. Fusce ligula sem, consequat eget lobortis semper, pharetra a turpis. Vivamus tincidunt, turpis ut blandit maximus, est tortor egestas magna, ut feugiat neque purus ut tellus. Phasellus ligula dui, luctus tristique sollicitudin eu, placerat cursus dui.
                            Donec ornare, lacus eget commodo accumsan, eros libero hendrerit neque, non vehicula nibh elit ut sem.Proin ac aliquet augue,
                            ornare consectetur nisl.Proin bibendum ipsum id nunc mollis, non fringilla libero vulputate.Etiam viverra aliquet arcu,
                            sit amet tristique ipsum.Donec odio dui, auctor et elit non, ornare elementum sapien.Donec at magna sagittis,
                            tincidunt nisi sit amet, facilisis elit.Suspendisse nec massa erat.Suspendisse at vulputate nibh.Aliquam diam nulla,
                            malesuada at lorem ac, interdum pretium lacus.Curabitur aliquet diam id eros elementum porta.Class aptent taciti sociosqu ad litora torquent per conubia nostra,
                            per inceptos himenaeos.Aliquam erat volutpat.Ut ex neque, sagittis sit amet elementum sed, ullamcorper sed quam.
                            Aliquam bibendum, nisl ullamcorper blandit feugiat, urna nibh iaculis nisl,
                            ut eleifend justo dolor in diam.Nullam finibus enim quis lorem gravida,
                            id vestibulum arcu tempor.Vivamus vulputate nisl a nulla mollis convallis.Praesent eleifend posuere augue eget efficitur.Donec eros ipsum,
                            pellentesque non molestie vitae,
                            finibus id nulla.Duis sodales,
                            est ac laoreet lobortis,
                            elit ante maximus nunc,
                            vitae fermentum justo leo ac orci.Ut ante ipsum,
                            sollicitudin eget pretium et,
                            commodo sed nisl.Proin non purus elit.Nullam vel nulla eleifend,
                            iaculis mauris eget,
                            consequat mauris.
                            Nullam ante elit,
                            aliquam in pretium ac,
                            blandit sit amet nibh.Proin tincidunt quam ac orci dictum placerat id mollis velit.Proin sodales metus erat,
                            vel tincidunt est iaculis sed.Curabitur tristique mauris orci,
                            et tincidunt quam pellentesque at.Aenean vehicula nibh a nunc cursus, in tempor neque interdum.Phasellus sit amet pretium arcu.Aliquam justo lacus,
                            sollicitudin eu elit vel,
                            placerat consequat nunc.Curabitur imperdiet hendrerit diam efficitur gravida.
                            Cras hendrerit dapibus metus.Vestibulum sed varius elit,
                            sed efficitur nisi.Ut id placerat justo,
                            vitae luctus metus.Sed vel erat eget urna porta finibus sodales quis nisl.Morbi nec imperdiet arcu,
                            eget maximus justo.Sed neque felis,
                            hendrerit eget eros ut,
                            blandit ullamcorper augue.Lorem ipsum dolor sit amet,
                            consectetur adipiscing elit.Donec pharetra turpis sed vulputate cursus.Aenean eu mauris sit amet nisl laoreet tincidunt.Aenean euismod iaculis mi, in eleifend libero vestibulum eu.Pellentesque nisi mauris,
                            ornare ac dui at,
                            facilisis ornare ipsum.
                            In eu leo et quam porttitor gravida.Morbi viverra nisl nec vestibulum mollis.Ut nunc tellus,
                            rhoncus at tincidunt et,
                            aliquam non sem.Integer a nulla felis.Aenean blandit eros tellus,
                            non faucibus ex placerat non.Praesent lacus magna,
                            sagittis varius lorem sed,
                            feugiat efficitur eros.Etiam laoreet tempor.",
                Codigo = "100000",
                ValorCusto = 100
            };

            var resultado = CadastroService.CadastroProduto(produto);
            Assert.IsNull(resultado.Codigo);
        }
        //- O campo ‘Código do produto’ deverá conter, exatamente, 6 caracteres
        [TestMethod]
        public void CadastroProdutoAoInserirCodigoComTamanhoInvalidoRetornaCadastroInvalido()
        {
            var produto = new Produto
            {
                Nome = "Produto Teste",
                Codigo = "1",
                ValorCusto = 10
            };

            var resultado = CadastroService.CadastroProduto(produto);
            Assert.IsNull(resultado.Codigo);
        }

        //- O ‘Valor de venda’ será calculado automaticamente, onde constituirá do ‘Valor de custo’ + 15% de seu valor
        [TestMethod]
        public void CadastroProdutoAoInserirProdutoRetornaValorVendaDeQuinzePorcentoDoValorCusto()
        {
            var produto = new Produto
            {
                Nome = "Produto Teste",
                Codigo = "100000",
                ValorCusto = 100
            };

            var resultado = CadastroService.CadastroProduto(produto);
            Assert.AreEqual(115, resultado.ValorVenda);
        }
    }
}
