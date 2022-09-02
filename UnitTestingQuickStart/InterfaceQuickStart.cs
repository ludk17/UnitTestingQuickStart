namespace UnitTestingQuickStart;

// nivel de acceso
// palabbra clave "interface"
// nombre cualquiera, por estander en C# iniciar con la letra "I"

public interface IQuickStart
{
    // definicioanes de metodos y todos son publicos, por lo cual
    // la palabra "public" nop es requerida
    void NombreDeMetodo();
}

public interface IQuickStart2
{
    void OtroMetodo();
    void OtroMetodo2();
    void OtroMetodo3();
}

public class BaseClass
{
    
}

// una interfaz obliga a quien la usa "implementar" todos los metodos.

public class MyClass1 : IQuickStart
{
    public void NombreDeMetodo()
    {
        Console.WriteLine("My Class 1");
    }
}

public class MyClass2 : IQuickStart
{
    public void NombreDeMetodo()
    {
        Console.WriteLine("My Class 2");
    }
}

public class MyClass3 : IQuickStart
{
    public void NombreDeMetodo()
    {   
        Console.WriteLine("My Class 3");
    }
}

public class MyClass : BaseClass, IQuickStart, IQuickStart2
{
    public void NombreDeMetodo()
    {
        // el codigo para este metodo;
        Console.WriteLine("Hello Worl");
    }

    public void OtroMetodo()
    {
        // el codigo para este metodo;
    }

    public void OtroMetodo2()
    {
    }

    public void OtroMetodo3()
    {
    }
}


// nivel de acceos
// palabra clave "class"
// nombre de clase
public class InterfaceQuickStart
{
    // las clases tienen propiedades y metodos
    
    //  propiedas -> attributos
    // tupo de datos: - string, int, clase, listas, etc 
    public int Edad { get; set; }

    // metodos -> funciones, rutinas
    // public/private
    public void NombreDeMetodo(/* parametros */)
    {
        // implementación
    }
}