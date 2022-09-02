using System.Net.Http.Headers;

namespace UnitTestingQuickStart;

public interface IExchangeService
{
    // definiciones
    decimal GetAmount(decimal amount, string from, string to);
}

public class ExchangeServiceFake : IExchangeService
{
    public decimal GetAmount(decimal amount, string @from, string to)
    {
        return 3.86m * amount;
    }
}

public class ExchangeService: IExchangeService
{
    public const string PEN = "PEN";
    public const string USD = "USD";

    private static string TOKEN = "CRmiYdYMxjMBSkqInh9hDrq8KBKAFwg9";

    // implementación del metodo

    public decimal GetAmount(decimal amount, string from, string to)
    {
        var URL = "https://api.apilayer.com/exchangerates_data/convert";
        var urlParameters = $"?to={to}&from={from}&amount={amount}";
        
        var client = new HttpClient();
        client.BaseAddress = new Uri(URL);

        // Add an Accept header for JSON format.
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        client.DefaultRequestHeaders.Add("apiKey", TOKEN);

        // List data response.
        HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
        if (response.IsSuccessStatusCode)
        {
            // Parse the response body.
            var dataObjects = response.Content.ReadAsAsync<Exchange>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
            client.Dispose();
            return dataObjects.result;
        }
        else
        {
            Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
        }
        
        client.Dispose();
        return 0;

    }
}