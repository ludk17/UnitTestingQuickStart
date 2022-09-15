using Moq;
using NUnit.Framework;

namespace UnitTestingQuickStart.Tests;

public class CuentaAhorrosTest
{
    private const string USD = "USD";
    private const string PEN = "PEN";
    
    [Test]
    public void CuentaAhorroSaldoCaso01()
    {
        var mockService = new Mock<IExchangeService>();
        mockService.Setup(o => o.GetCurrent(USD, PEN)).Returns(3.86m);
        var service = mockService.Object;
        
        var cuenta = new CuentaAhorros(1000, service);
        // gastos en soles o dolares
        var result = cuenta.GetSaldo();
        Assert.AreEqual(1000, result);
    }
    
    [Test]
    public void CuentaAhorroSaldoCaso05()
    {
        var mockService = new Mock<IExchangeService>();
        mockService.Setup(o => o.GetCurrent(USD, PEN)).Returns(3.87m);
        var service = mockService.Object;

        var cuenta = new CuentaAhorros(1000, service);
        cuenta.Gastar(100, USD); // 3.87 =>
        var result = cuenta.GetSaldo();
        Assert.AreEqual(613, result); 
    }
    
    [Test]
    public void CuentaAhorroSaldoCaso06()
    {
        var mockService = new Mock<IExchangeService>();
        mockService.Setup(o => o.GetCurrent(USD, PEN)).Returns(3.88m);
        var service = mockService.Object;
        
        // var service = new ExchangeServiceFake3();
        var cuenta = new CuentaAhorros(1000, service);
        cuenta.Gastar(100, USD); // 3.88 =>
        var result = cuenta.GetSaldo();
        Assert.AreEqual(612, result); 
    }
    
    [Test]
    public void CuentaAhorroSaldoCaso02()
    {
        var mockService = new Mock<IExchangeService>();
        mockService.Setup(o => o.GetCurrent(USD, PEN)).Returns(3.86m);
        var service = mockService.Object;
        
        var cuenta = new CuentaAhorros(1000, service);
        cuenta.Gastar(100, PEN);
        var result = cuenta.GetSaldo();
        Assert.AreEqual(900, result);
    }
    
    [Test]
    public void CuentaAhorroSaldoCaso03()
    {
        var mockService = new Mock<IExchangeService>();
        mockService.Setup(o => o.GetCurrent(USD, PEN)).Returns(3.86m);
        var service = mockService.Object;
        
        var cuenta = new CuentaAhorros(1000, service); // Siempre en soles
        cuenta.Gastar(100, USD);
        var result = cuenta.GetSaldo();
        Assert.AreEqual(614m, result);
    }
    
    // prueba integral
    [Test]
    public void CuentaAhorroSaldoCaso04()
    {
        var mockService = new Mock<IExchangeService>();
        mockService.Setup(o => o.GetCurrent(USD, PEN)).Returns(3.86m);
        var service = mockService.Object;
        
        var cuenta = new CuentaAhorros(1000, service); // Siempre en soles
        cuenta.Gastar(100, USD);
        cuenta.Gastar(100, PEN);
        var result = cuenta.GetSaldo();
        Assert.AreEqual(514m, result);
    }
    
}