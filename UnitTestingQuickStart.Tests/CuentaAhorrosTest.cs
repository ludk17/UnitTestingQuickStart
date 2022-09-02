using NUnit.Framework;

namespace UnitTestingQuickStart.Tests;

public class CuentaAhorrosTest
{
    private const string USD = "USD";
    private const string PEN = "PEN";
    
    [Test]
    public void CuentaAhorroSaldoCaso01()
    {
        var cuenta = new CuentaAhorros(1000, new ExchangeServiceFake());
        // gastos en soles o dolares
        var result = cuenta.GetSaldo();
        Assert.AreEqual(1000, result);
    }
    
    [Test]
    public void CuentaAhorroSaldoCaso02()
    {
        var cuenta = new CuentaAhorros(1000, new ExchangeServiceFake());
        cuenta.Gastar(100, PEN);
        var result = cuenta.GetSaldo();
        Assert.AreEqual(900, result);
    }
    
    [Test]
    public void CuentaAhorroSaldoCaso03()
    {
        var cuenta = new CuentaAhorros(1000, new ExchangeServiceFake()); // Siempre en soles
        cuenta.Gastar(100, USD);
        var result = cuenta.GetSaldo();
        Assert.AreEqual(614m, result);
    }
    
    // prueba integral
    [Test]
    public void CuentaAhorroSaldoCaso04()
    {
        var cuenta = new CuentaAhorros(1000, new ExchangeServiceFake()); // Siempre en soles
        cuenta.Gastar(100, USD);
        cuenta.Gastar(100, PEN);
        var result = cuenta.GetSaldo();
        Assert.AreEqual(514m, result);
    }
    
}