static class Controlador{
    private static List<Arboles> arboles = new List<Arboles>();

    public static void registrarArbol()
    {
        int opcion = -1;
        do
        {
            Console.WriteLine("Para registrar un árbol digite un número diferente al 0. Si desea salir digite el número 0");
            opcion = Int32.Parse(Console.ReadLine());
            if (opcion != 0)
            {
                Console.WriteLine("Por favor digite el nombre del árbol, su edad, su país de origen y su altura");
                string nombre = Console.ReadLine();
                string pais = Console.ReadLine();
                int altura = Int32.Parse(Console.ReadLine());
                int edad = Int32.Parse(Console.ReadLine());
                Arboles arboles;

                arboles = new Arboles(nombre,edad,pais,altura);
                arbolesz.Add(arboles);
                
            }
        } while (opcion != 0);
    
    }
}