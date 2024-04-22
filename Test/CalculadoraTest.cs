using Console.Models;

namespace test;

public class CalculadoraTest
{

    //Testes na classe Calculadora.
    public CalculadoraTest()
    {
        _cal = new Calculadora();
    }
    
    private Calculadora _cal { get; set; }

    [Fact]
    public void TesteSoma()
    {
        var resultadoSuma = _cal.Somar(10,20);
        Assert.Equal(30,resultadoSuma);
    }

    [Fact]
    public void TesteSub()
    {
        var resultadoSub = _cal.Subtrair(10,5);
        Assert.Equal(5,resultadoSub);
    }

      [Fact]
    public void TesteDiv()
    {
        var resultadoDiv = _cal.Dividir(10,2);
        Assert.Equal(5,resultadoDiv);
    }
    [Fact]
    public void TesteMult()
    {
        var resultadoMult = _cal.Multiplicar(10,2);
        Assert.Equal(20,resultadoMult);
    }
   
}