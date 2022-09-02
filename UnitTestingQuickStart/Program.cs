// See https://aka.ms/new-console-template for more information

// using UnitTestingQuickStart;
//
// var cuenta = new CuentaAhorros(1000, new ExchangeService());
//
// Console.WriteLine("Ingresa Gasto");
// var gasto = decimal.Parse(Console.ReadLine());
// Console.WriteLine("Ingresa Moneda");
// var moneda = Console.ReadLine();
//
// cuenta.Gastar(gasto, moneda);
//
//
// Console.WriteLine("Ingresa Gasto");
// gasto = decimal.Parse(Console.ReadLine());
// Console.WriteLine("Ingresa Moneda");
// moneda = Console.ReadLine();
//
// cuenta.Gastar(gasto, moneda);
//
// Console.WriteLine($"Su saldo es: {cuenta.GetSaldo()}");


// Programa real -> Yo quiero que use el tipo de cambio real.
// pruebas unitaria -> Yo quiero que el tipo de cambio siempre sera 3.85


using UnitTestingQuickStart;

var c = new MyClass();
c.OtroMetodo();

/*prohibido*/
// var i = new IQuickStart2(); // No se peude instanciar la interfaces
// i.OtroMetodo();

var iw = new InterfaceWork();
iw.HacerAlgoconClass(new MyClass());
// iw.HacerAlgoconClass(new BaseClass());
// iw.HacerAlgoconClass(new IQuickStart());

// iw.HacerAlgoConInterface(new IQuickStart());
iw.HacerAlgoConInterface(new MyClass());

iw.HacerAlgoConInterface(new MyClass1());
iw.HacerAlgoConInterface(new MyClass2());
iw.HacerAlgoConInterface(new MyClass3());


public class InterfaceWork
{
    public void HacerAlgoconClass(MyClass c)
    {
        c.NombreDeMetodo();
    }
    public void HacerAlgoConInterface(IQuickStart i)
    {
        i.NombreDeMetodo();
    }
}











