public class Arboles{
    public string Nombre {get; set;}
    public int Edad {get; set;}
    public string Pais {get; set;}
    public int Altura {get; set;}

    public Arboles(string nombre, int edad, string pais, int altura)
    {
        this.Nombre = nombre;
        this.Edad = edad;
        this.Altura = altura;
        this.Pais = pais;
    }
}