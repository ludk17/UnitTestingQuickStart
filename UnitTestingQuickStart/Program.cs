

public interface Interface
{
    void Imprimir(string text);
}

class Implementation : Interface
{
    public void Imprimir(string text)
    {
        Console.WriteLine(text);
    }
}

class Implementation2 : Interface
{
    public void Imprimir(string text)
    {
        Console.WriteLine(text + " desde otra implementación");
    }
}

class Persona
{
    private Interface i1; 
    public Persona(Interface i1)
    {
        this.i1 = i1;
    }

    public void ImprimirTexto()
    {
        i1.Imprimir("Hola Mundo");
    }
}


class Program
{
    static void Main(string[] args)
    {
        // new Persona(Intancia de Interface)
        // para instanciar una interface -> debo instanciar una clase que use la interface
        
        var p1 = new Persona(new Implementation());
        p1.ImprimirTexto();
        
    }
}

