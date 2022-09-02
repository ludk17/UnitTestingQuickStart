namespace UnitTestingQuickStart;

public class Algoritmos
{
    public int ObtenerMaxDeCincoNumeros(int n1, int n2, int n3, int n4, int n5)
    { 
        var ns = new int[] {n1, n2, n3, n4, n5};
        var max = ns.Max();
        return max;
    }

    public bool EsPalindromo(string frase)
    {
        // Hola -> false
        // Oso -> 

        frase = frase.Replace(" ", "");
        frase = frase.ToLower();

        return string.Join("", frase.Reverse().ToArray()) == frase;
    }
}