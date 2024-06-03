using Xunit;
using Calculadora;
using System;

namespace CalculadoraTest {
    public class Teste {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(3,3,6)]
        public void TesteSomar(int v1, int v2, int res) {
            Calculos calc = new Calculos();

            int resultado = calc.somar(v1, v2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(5,2,3)]
        [InlineData(9,3,6)]
        public void TesteSubtrair(int v1, int v2, int res) {
            Calculos calc = new Calculos();

            int resultado = calc.subtrair(v1, v2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(3,2,6)]
        [InlineData(3,3,9)]
        public void TesteMultiplicar(int v1, int v2, int res) {
            Calculos calc = new Calculos();

            int resultado = calc.multiplicar(v1, v2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(10,2,5)]
        [InlineData(30,3,10)]
        public void TesteDividir(int v1, int v2, int res) {
            Calculos calc = new Calculos();

            int resultado = calc.dividir(v1, v2);

            Assert.Equal(res, resultado);
        }


        [Fact]
        public void TesteDividirPorZero() {
            Calculos calc = new Calculos();

            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3,0)
            );
        }
        
        [Fact]
        public void Testehistorico() {
            Calculos calc = new Calculos();
            calc.somar(1, 2);
            calc.somar(2, 8);
            calc.somar(3, 7);
            calc.somar(10, 2);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }


    }
}