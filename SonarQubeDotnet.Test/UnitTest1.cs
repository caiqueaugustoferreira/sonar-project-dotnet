

namespace SonarQubeDotnet.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("+", 5, 3, 8)]
        [InlineData("-", 5, 3, 2)]
        [InlineData("*", 5, 3, 15)]
        [InlineData("/", 6, 3, 2)]
        [InlineData("%", 50, 10, 5)]
        [InlineData("média", 5, 3, 4)]        
        public void TestCalcular(string operacao, double num1, double num2, double expected)
        {
            double result = Program.Calcular(operacao, num1, num2);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCalcularOperacaoInvalida()
        {
            Assert.Throws<ArgumentException>(() => Program.Calcular("invalida", 5, 3));
        }
    }
}
