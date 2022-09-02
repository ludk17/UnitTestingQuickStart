namespace UnitTestingQuickStart;

public class PersonaHelper
{
    private List<Persona> Personas;
    public PersonaHelper(List<Persona> personas)
    {
        this.Personas = personas;
    }
    
    public Persona ObtenerAlMayor()
    {
        return Personas.First(o => o.Edad == Personas.Max(x => x.Edad));
    }
    
    public Persona ObtenerAlMenor()
    {
        return Personas.First(o => o.Edad == Personas.Min(x => x.Edad));
    }
    
    public Persona BuscarPorNombre(string nombre)
    {
        return Personas.First(o => o.Nombre == nombre);
    }
}