using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using SQLitePCL;

public partial class Desarrollo{
public static void Configuracion(){
        bool continuar = true;
        while(continuar){
        Console.Clear();
        Console.WriteLine(@"
        
__,_,
  [_|_/ 
   //
 _//    __
(_|)   |@@|
 \ \__ \--/ __
  \o__|----|  |   __
      \ }{ /\ )_ / _\
      /\__/\ \__O (__
     (--/\--)    \__/
     _)(  )(_
    `---''---'
        
        
        Configuracion.
        1- Enfermedades.
        2- Carreras.
        R- Regresar.
        ");
        Console.Write("Ingrese una opcion: ");
        string opcion = Console.ReadLine()??"";

            switch(opcion){
                case "1":
                    Console.WriteLine("Enfermedades.");
                    Desarrollo.Conf_Enfermedades();

                break;

                case "2":
                    Console.WriteLine("Carreras");
                    Desarrollo.Conf_carreras();
                break;

                case "r":
                continuar = false;
                    Console.WriteLine("Regresar");
                break;

                default:
                    Console.WriteLine("Opcion no valida.");
                    Utils.Pausa();
                break;
            }
        }
    }


    public static void Conf_Enfermedades(){
        var db = new Covid1Context();
        bool continuar = true;
        while(continuar){
            Console.Clear();
            Console.WriteLine(@"
            Gestion de enfermedades.
            
            1- Agregar enfermedad.
            2- Modificar enfermedad.
            3- Eliminar enfermedad.
            r- Regresar.
            
            ");
            Console.Write("Ingrese una opcion: ");
            string opcion = Console.ReadLine()??"";
            switch(opcion){
                case "1":
                    Console.Clear();
                    Console.WriteLine("Agregar enfermedad.");
                    var p = new Enfermedad();
                    p.Nombre = Utils.input("Ingrese el nombre de la enfermedad: ");
                    db.Enfermedades.Add(p);
                    db.SaveChanges();
                    Console.WriteLine("enfermedad agregada");
                    Utils.Pausa();
                break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Modificar enfermedad.");
                    Console.WriteLine("Vamos a editar una enfermedad.");

                    List<Enfermedad> enfermedades = db.Enfermedades.ToList();
                    foreach(var prov in enfermedades){
                        Console.WriteLine($"{prov.Id} - {prov.Nombre}");
                    }

                    Console.WriteLine("Ingrese el id de la enfermedad a modificar: ");
                    var editar = db.Enfermedades.Find(int.Parse(Console.ReadLine()));
                    if(editar == null){
                        Console.WriteLine("No se encontro la enfermedad");
                        Utils.Pausa();
                    }
                    else{
                        Console.WriteLine($"Ingrese el nuevo nombre de la enfermedad: ({editar.Nombre}) ");
                        editar.Nombre = Console.ReadLine()??"";
                        db.SaveChanges();
                        Console.WriteLine("enfermedad modificada");
                    }
                    
                break;

                case "3":
                Console.Clear();
                    Console.WriteLine("Eliminar enfermedad.");
                    List<Enfermedad> enfermedades1 = db.Enfermedades.ToList();
                    foreach(var prov in enfermedades1){
                        Console.WriteLine($"{prov.Id} - {prov.Nombre}");
                    }
                    Console.WriteLine("Ingrese el id de la enfermedad a eliminar: ");
                    var eliminar = db.Enfermedades.Find(int.Parse(Console.ReadLine()));
                    if(eliminar == null){
                        Console.WriteLine("No se encontro la enfermedad.");
                        Utils.Pausa();
                    }
                    else{
                        db.Enfermedades.Remove(eliminar);
                        db.SaveChanges();
                        Console.WriteLine("enfermedad eliminada.");
                        Utils.Pausa();
                    }
                break;

                case "r":
                    continuar = false;
                break; 

                default:
                Console.WriteLine("Opcion no valida.");
                break;

        }
        }

    }
    public static void Conf_carreras(){
        var db = new Covid1Context();
        bool continuar = true;
        while(continuar){
            Console.Clear();
            Console.WriteLine(@"
            Gestion de carrera.
            
            1- Agregar carrera.
            2- Modificar carrera.
            3- Eliminar carrera.
            r- Regresar.
            
            ");
            Console.Write("Ingrese una opcion: ");
            string opcion = Console.ReadLine()??"";
            switch(opcion){
                case "1":
                    Console.Clear();
                    Console.WriteLine("Agregar carrera.");
                    var v = new Carrera();
                    v.Nombre = Utils.input("Ingrese el nombre de la carrera: ");
                    db.Carreras.Add(v);
                    db.SaveChanges();
                    Console.WriteLine("carrera agregada");
                    Utils.Pausa();
                break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Modificar carrera.");
                    Console.WriteLine("Vamos a editar una carrera.");

                    List<Carrera> carreras = db.Carreras.ToList();
                    foreach(var vac in carreras){
                        Console.WriteLine($"{vac.Id} - {vac.Nombre}");
                    }

                    Console.WriteLine("Ingrese el id de la carrera a modificar: ");
                    var editar = db.Carreras.Find(int.Parse(Console.ReadLine()));
                    if(editar == null){
                        Console.WriteLine("No se encontro la carrera");
                        Utils.Pausa();
                    }
                    else{
                        Console.WriteLine($"Ingrese el nuevo nombre de la carrera: ({editar.Nombre}) ");
                        editar.Nombre = Console.ReadLine()??"";
                        db.SaveChanges();
                        Console.WriteLine("carrera modificada");
                    }
                    
                break;

                case "3":
                Console.Clear();
                    Console.WriteLine("Eliminar carrera.");
                    List<Carrera> carreras1 = db.Carreras.ToList();
                    foreach(var vac in carreras1){
                        Console.WriteLine($"{vac.Id} - {vac.Nombre}");
                    }
                    Console.WriteLine("Ingrese el id de la carrera a eliminar: ");
                    var eliminar = db.Carreras.Find(int.Parse(Console.ReadLine()));
                    if(eliminar == null){
                        Console.WriteLine("No se encontro la provincia.");
                        Utils.Pausa();
                    }
                    else{
                        db.Carreras.Remove(eliminar);
                        db.SaveChanges();
                        Console.WriteLine("carrera eliminada.");
                        Utils.Pausa();
                    }
                break;

                case "r":
                    continuar = false;
                break; 

                default:
                Console.WriteLine("Opcion no valida.");
                break;

        }
        }

    }
    
    public static void Registrar(){
        var db = new Covid1Context();
        Console.Clear();
        Console.WriteLine("Registrar estudiante enfermo");
        var p = new Persona();
        var proceso = new Proceso();
        
        var Cedula = Utils.input("Ingrese la cedula sin guiones: ");

        p = db.Personas.Where(x => x.Cedula == Cedula).FirstOrDefault();

        if(p == null){
            p = new Persona();
            p.Cedula = Cedula;
            var personaCedula = new Persona_cedula();
            personaCedula.ok = false;
            try{
                var url = "https://api.adamix.net/apec/cedula/"+Cedula;
                var client = new HttpClient();
                var response = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
                personaCedula = Newtonsoft.Json.JsonConvert.DeserializeObject<Persona_cedula>(response);
            }
            catch(Exception){}

            if(personaCedula.ok){
                p.Nombre = personaCedula.Nombres;
                p.Apellido = $"{personaCedula.Apellido1} {personaCedula.Apellido2}";
            }else{
                p.Nombre = Utils.input("Ingrese el nombre: ");
                p.Apellido = Utils.input("ingrese el apellido: ");
            }
            p.Matricula = Utils.input("Ingrese su matricula: ");
            p.Telefono = Utils.input("Ingrese el telefono: ");
            p.diasEnfermo = Utils.input("Ingrese la cantidad de dias enfermo: ");
            p.FechaNacimiento = Utils.input("Ingrese su fecha de nacimiento: ");
            p.SignoZodiacal = Utils.input("Ingrese su signo zodiacal: ");
            p.Lugar = Utils.input("Ingrese el lugar donde cree que se contagio: ");
            p.lat = Utils.input("Ingrese la latitud del lugar donde se contagio: ");
            p.lon = Utils.input("Ingrese la longitud del lugar donde se contagio: ");
            db.Personas.Add(p);
            }

        proceso.Persona = p;
        proceso.Fecha = DateTime.Now;

        var listadocarrera = db.Carreras.ToList();
        foreach(var vac in listadocarrera){
            Console.WriteLine($"{vac.Id} - {vac.Nombre}");
        }
        while(proceso.Carrera == null){
           
            Console.WriteLine("Ingrese el id de la carrera: ");
            var carrera = db.Carreras.Find(int.Parse(Console.ReadLine()));
            if(carrera == null){
                Console.WriteLine("No se encontro la carrera");
            }
            else{
                proceso.Carrera = carrera;
            }
        }

        var listadoenfermedad = db.Enfermedades.ToList();
        foreach(var prov in listadoenfermedad){
            Console.WriteLine($"{prov.Id} - {prov.Nombre}");
        }
        
        while(proceso.Enfermedad == null){
            Console.WriteLine("Ingrese el id de la enfermedad: ");
            var enfermedad = db.Enfermedades.Find(int.Parse(Console.ReadLine()));
            if(enfermedad == null){
                Console.WriteLine("No se encontro la enfermedad");
            }
            else{
                proceso.Enfermedad = enfermedad;
            }
        }

        db.Procesos.Add(proceso);
        db.SaveChanges();
        Console.WriteLine("estudiante registrado");
        Utils.Pausa();
    }


    public static void Consultas()
{
    var db = new Covid1Context();
    Console.Clear();
    Console.WriteLine("Consulta de procesos por matrícula");
    
    var matricula = Utils.input("Ingrese la matrícula del estudiante: ");

    var persona = db.Personas.FirstOrDefault(p => p.Matricula == matricula);

    if (persona == null)
    {
        Console.WriteLine("No se encontró la matrícula.");
        Utils.Pausa();
        return;
    }

    var procesos = db.Procesos
        .Include(p => p.Enfermedad)
        .Where(p => p.Persona.Id == persona.Id)
        .OrderBy(p => p.Fecha)
        .ToList();

    if (procesos.Count == 0)
    {
        Console.WriteLine($"El estudiante con matrícula {matricula} no tiene registros de enfermedades.");
    }
    else
    {
        Console.WriteLine($"Historial de procesos para {persona.Nombre} {persona.Apellido} ({matricula}):");
        Console.WriteLine("Fecha\t\tEnfermedad\tDías enfermo");
        int totalDiasEnfermo = 0;

        foreach (var proceso in procesos)
        {
            int diasEnfermo = (DateTime.Now - proceso.Fecha).Days;
            totalDiasEnfermo += diasEnfermo;

            Console.WriteLine($"{proceso.Fecha.ToShortDateString()}\t{proceso.Enfermedad.Nombre}\t{diasEnfermo}");
        }

        Console.WriteLine($"Total de días enfermo: {totalDiasEnfermo}");
    }

    Utils.Pausa();
}



public static void GenerarReporte()
{
    var db = new Covid1Context();
    Console.Clear();

    Console.WriteLine("Generar Reporte");
    Console.WriteLine("1- Número de afectados por enfermedad");
    Console.WriteLine("2- Reporte Zodiacal");
    Console.WriteLine("3- Enfermos por carrera");
    Console.Write("Ingrese el número de la opción: ");
    
    string opcion = Console.ReadLine()?.ToLower();

    switch (opcion)
    {
        case "1":
            ReporteAfectadosPorEnfermedad(db);
            break;

        case "2":
            ReporteZodiacal(db);
            break;

        case "3":
            ReporteEnfermosPorCarrera(db);
            break;

        default:
            Console.WriteLine("Opción no válida.");
            Utils.Pausa();
            break;
    }
}

private static void ReporteAfectadosPorEnfermedad(Covid1Context db)
{
    Console.Clear();
    Console.WriteLine("Número de afectados por enfermedad");

    var afectadosPorEnfermedad = db.Procesos
        .GroupBy(p => p.Enfermedad)
        .Select(g => new { Enfermedad = g.Key.Nombre, Cantidad = g.Count() })
        .ToList();

    foreach (var afectado in afectadosPorEnfermedad)
    {
        Console.WriteLine($"{afectado.Enfermedad}: {afectado.Cantidad} personas");
    }

    Utils.Pausa();
}

private static void ReporteZodiacal(Covid1Context db)
{
    Console.Clear();
    Console.WriteLine("Reporte Zodiacal");

    var afectadosPorSigno = db.Personas
        .Where(p => p.FechaNacimiento != null)
        .GroupBy(p => p.SignoZodiacal)
        .Select(g => new { Signo = g.Key, Cantidad = g.Count() })
        .ToList();

    foreach (var afectado in afectadosPorSigno)
    {
        Console.WriteLine($"{afectado.Signo}: {afectado.Cantidad} personas");
    }

    Utils.Pausa();
}

private static void ReporteEnfermosPorCarrera(Covid1Context db)
{
    Console.Clear();
    Console.WriteLine("Enfermos por carrera");

    var enfermosPorCarrera = db.Procesos
        .GroupBy(p => p.Carrera)
        .Select(g => new { Carrera = g.Key.Nombre, Cantidad = g.Count() })
        .ToList();

    foreach (var enfermo in enfermosPorCarrera)
    {
        Console.WriteLine($"{enfermo.Carrera}: {enfermo.Cantidad} personas");
    }

    Utils.Pausa();
}


public static void Exportar(){
    var db = new Covid1Context();
    Console.Clear();
    Console.WriteLine("Vamos a exportar una tarjeta del estudiante.");
    Persona persona = null;
    while(persona == null){
        var cedula = Utils.input("ingrese la cedula sin guiones o x para ver un listado de las personas: ");
        if(cedula.ToLower().Trim() == "x"){
            var listadoPersonas = db.Personas.ToList();
            foreach(var p in listadoPersonas){
                Console.WriteLine($"{p.Id} {p.Cedula} - {p.Nombre} {p.Apellido}");
            }
            cedula = Utils.input("Digite el id de la persona: ");
            persona = db.Personas.Find(int.Parse(cedula));
        }else{
            persona = db.Personas.Where(x => x.Cedula == cedula).FirstOrDefault();
        }
    }
    var listadoProcesos = db.Procesos.Where(x => x.Persona.Id == persona.Id)
    .Include(x => x.Carrera).Include(x => x.Enfermedad).ToList();

    Console.WriteLine($"{persona.Nombre} {persona.Apellido}");
    var detalle = "";
    foreach(var proceso in listadoProcesos){
        Console.WriteLine($"{proceso.Id} {proceso.Carrera.Nombre} - {proceso.Enfermedad.Nombre} {proceso.Fecha.ToShortDateString()}");
        detalle += @$"
            <tr>

                <td>{proceso.Fecha.ToShortDateString()}</td>
                <td>{proceso.Carrera.Nombre}</td>
                <td>{proceso.Enfermedad.Nombre}</td>
            </tr>
        ";
    }

    var html = @$"
    <html>
        <head>
            <tittle>Tarjeta de {persona.Nombre} {persona.Apellido}</tittle>
            <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css'>

        </head>
        <body>
            <div clss = 'container'>
                <h1>Tarjeta de {persona.Nombre} {persona.Apellido}</h1>
                <h3>Cedula {persona.Cedula}</h3>
                <h3>Telefono {persona.Telefono}</h3>

                <h4>Procesos aplicados.</h4>
                <table>
                    <thead>
                        <tr>
                            <th>Fecha</th>
                            <th>Carrera</th>
                            <th>Enfermedad</th>
                        </tr>
                    </thead>
                    <tbody>
                        {detalle}
                    </tbody>
                </table>    

            </div>    
        </body>
    </html>
    
 ";
 System.IO.File.WriteAllText("tarjeta.html", html);
 Console.WriteLine("Tarjeta generada.");
 var url = "tarjeta.html";
 var psi = new System.Diagnostics.ProcessStartInfo();
 psi.UseShellExecute = true;
 psi.FileName = url;
 System.Diagnostics.Process.Start(psi);

    Utils.Pausa();
}



public static void VerMapa()
{
    Console.Clear();
    Console.WriteLine("Ver mapa.");
    var db = new Covid1Context();

    var marcadores = "";

    var listadoPersonas = db.Personas.ToList();
    foreach (var persona in listadoPersonas)
    {
        if (!string.IsNullOrEmpty(persona.Lugar) && persona.lat != null && persona.lon != null)
        {
            marcadores += @$"
                var marker = L.marker([{persona.lat}, {persona.lon}]).addTo(map)
                .bindPopup(`
                    <h3>{persona.Nombre} {persona.Apellido}</h3>
                    Cédula: {persona.Cedula}</br>
                    Lugar: {persona.Lugar}</br>
                    Teléfono: {persona.Telefono}</br>
                `);
            ";
        }
    }

    var plantilla = System.IO.File.ReadAllText("plantilla.html");
    plantilla = plantilla.Replace("CODIGOEDISONC#", marcadores);

    System.IO.File.WriteAllText("mapa.html", plantilla);

    var psi = new System.Diagnostics.ProcessStartInfo();
    psi.UseShellExecute = true;
    psi.FileName = "mapa.html";
    System.Diagnostics.Process.Start(psi);

    Utils.Pausa("Mapa abierto.");
}

}