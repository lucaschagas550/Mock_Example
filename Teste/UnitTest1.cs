using Moq;
using Teste_Mock;

namespace Teste
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // arrange
            Produto produtoBarato = new Produto()
            {
                Preco = 35
            };
            Mock<IVerificadorPrecoProduto> mock = new Mock<IVerificadorPrecoProduto>();
            mock.Setup(m => m.VerificaPrecoProduto(produtoBarato)).Returns("Produto barato!");
            VerificadorPrecoProduto verif = new VerificadorPrecoProduto();

            // act
            var resultadoEsperado = mock.Object.VerificaPrecoProduto(produtoBarato);
            var resultado = verif.VerificaPrecoProduto(produtoBarato);

            // assert
            Assert.Equal(resultado, resultadoEsperado);
        }
    }
}