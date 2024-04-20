
/*public static class Archivo
{

    private static List<Enfermedad> Enfermedades = new List<Enfermedad>();

    public static List<Enfermedad> ListaEnfermedad()
    {
        return Enfermedades;
    }

    public static void Guardar(List<Enfermedad> enfermedades)
    {
        Enfermedades.Clear();
        Enfermedades.AddRange(enfermedades);

        var json = Newtonsoft.Json.JsonConvert.SerializeObject(enfermedades);
        System.IO.File.WriteAllText("enfermedades.json", json);
    }

    public static void Leer()
    {
        Enfermedades = new List<Enfermedad>();
        if (System.IO.File.Exists("enfermedades.json"))
        {
            var json = System.IO.File.ReadAllText("enfermedades.json");
            try
            {
                Enfermedades = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Enfermedad>>(json);
            }
            catch (Exception)
            {
                Utils.Pausa("Error al leer el archivo.");
            }
        }
    }


}


public static class Prov
{
    public static void ListarEnfermedades(List<Enfermedad> enfermedades)
    {
        foreach (var enferm in enfermedades)
        {
            Console.WriteLine($"{enferm.Id} - {enferm.Nombre}");
        }
    }

    public static int ObtenerIdDesdeConsola()
    {
        int id;
        while (!int.TryParse(Console.ReadLine(), out id))
        {
            Console.WriteLine("Por favor, ingrese un número válido.");
        }
        return id;
    }

    public static Enfermedad EncontrarEnfermedadPorId(int id, List<Enfermedad> enfermedades)
    {
        return enfermedades.FirstOrDefault(e => e.Id == id);
    }
}*/