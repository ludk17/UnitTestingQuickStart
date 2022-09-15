namespace UnitTestingQuickStart;

// Necesito saber cuanto dinero tiene
// mi cuenta despeus de todos los gastos que haga
// la tajeta acepta gastos en soles y dolares.

public class CuentaAhorros
{
    private decimal Monto;
    private IExchangeService ExchangeService;

    public CuentaAhorros(decimal monto, IExchangeService exchangeService)
    {
        Monto = monto;
        ExchangeService = exchangeService;
    }

    public decimal GetSaldo()
    {
        return this.Monto;
    }
    public void Gastar(decimal monto, string moneda)
    {
        if (moneda == "USD")
        {
            monto = monto * ExchangeService.GetCurrent("USD", "PEN"); //3.86
        }
        this.Monto -= monto;
    }
}


// string -> "" primitvos
// int -> 1
// string[] -> []string
// class { string, int }
// intefaces


//  mocks