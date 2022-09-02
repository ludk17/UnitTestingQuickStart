using System.Collections.Generic;
using NUnit.Framework;

namespace UnitTestingQuickStart.Tests;

public class AlgoritmosTest
{
    // Aca estaran los casos de prueba
    [Test]
    public void Caso01ObtenerMax()
    {
        // AAA
        // Arrange, Act, Assert
        // Instanciar, Llamar Metodo , Verificar
        var algoritmos = new Algoritmos();
        var max = algoritmos.ObtenerMaxDeCincoNumeros(1,2,3,4,5);
        
        Assert.AreEqual(5, max);
    }
    
    [Test]
    public void Caso02ObtenerMax()
    {
        // AAA
        // Arrange, Act, Assert
        // Instanciar, Llamar Metodo , Verificar
        var algoritmos = new Algoritmos();
        var real = algoritmos.ObtenerMaxDeCincoNumeros(5,4,3,2,1);
        Assert.AreEqual(5, real);
    }
    
    [Test]
    public void Caso03ObtenerMax()
    {
        // AAA
        // Arrange, Act, Assert
        // Instanciar, Llamar Metodo , Verificar
        var algoritmos = new Algoritmos();
        var max = algoritmos.ObtenerMaxDeCincoNumeros(51,42,301,2,10);
        
        Assert.AreEqual(301, max);
    }
    
    [Test]
    public void Caso04ObtenerMax()
    {
        var algoritmos = new Algoritmos();
        var max = algoritmos.ObtenerMaxDeCincoNumeros(-100,3,4,53,1);
        Assert.AreEqual(53, max);
    }

    [Test]
    public void Caso01Palindromo()
    {
        var algoritmos = new Algoritmos();
        var result = algoritmos.EsPalindromo("lima");
        Assert.AreEqual(false, result);
    }
    
    [Test]
    public void Caso02Palindromo()
    {
        var algoritmos = new Algoritmos();
        var result = algoritmos.EsPalindromo("mochila");
        Assert.AreEqual(false, result);
    }
    
    [Test]
    public void Caso03Palindromo()
    {
        var algoritmos = new Algoritmos();
        var result = algoritmos.EsPalindromo("oso");
        Assert.AreEqual(true, result);
    }


    [Test]
    public void Caso04Palindromo()
    {
        var algoritmos = new Algoritmos();
        var result = algoritmos.EsPalindromo("anita lava la tina");
        Assert.AreEqual(true, result);
    }
    
    [Test]
    public void Caso05Palindromo()
    {
        var algoritmos = new Algoritmos();
        var result = algoritmos.EsPalindromo("Oso");
        Assert.AreEqual(true, result);
    }
    
    // Dado una lista de personas, quiero saber quien es el mayor
    
    // Caso 01, Luis 20, Maria 21, Juan 15 => Maria
    [Test]
    public void QuienEsElMayorCaso01()
    {
        //int, string, date, boolean, CLASS
        
        var personas = new List<Persona>
        {
            new Persona {Nombre = "Luis", Edad = 20},
            new Persona {Nombre = "Maria", Edad = 21},
            new Persona {Nombre = "Juan", Edad = 15},
        };
        
        var helper = new PersonaHelper(personas);
        var result = helper.ObtenerAlMayor();
        
        Assert.AreEqual("Maria", result.Nombre);
    }
    
    
    [Test]
    public void QuienEsElMayorCaso02()
    {
        var personas = new List<Persona>
        {
            new Persona {Nombre = "Luis", Edad = 12},
            new Persona {Nombre = "Maria", Edad = 1},
            new Persona {Nombre = "Juan", Edad = 15},
        };
        
        var helper = new PersonaHelper(personas);
        var result = helper.ObtenerAlMayor();
        
        Assert.AreEqual("Juan", result.Nombre);
    }
    
}











