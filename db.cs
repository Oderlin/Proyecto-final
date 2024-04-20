using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Covid1Context : DbContext 
{
    public DbSet<Enfermedad> Enfermedades { get; set; }
    public DbSet<Carrera> Carreras { get; set; }
    public DbSet<Persona> Personas {get; set; }
    public DbSet<Proceso> Procesos { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseSqlite("Data Source=final.db");
    }
} 

public class Enfermedad{
    public int Id {get; set; }
    public string Nombre {get; set; }
}

public class Persona{
    public int Id { get; set; }
    public string Matricula {get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Cedula {get; set; } //fecha de nacimiento
    public string FechaNacimiento { get; set; }
    public string SignoZodiacal { get; set; }
    public string diasEnfermo { get; set; }
    public string Telefono {get; set; }
    public string Lugar {get; set; }
    public string lon {get; set; }
    public string lat {get; set; }
}

public class Carrera{
    public int Id {get; set; }
    public string Nombre {get; set; }
}

public class Proceso{
    public int Id {get; set; }
    public DateTime Fecha {get; set; }
    public Persona Persona {get; set; }
    public Enfermedad Enfermedad {get; set; }
    public Carrera Carrera {get; set; }

}

public class Persona_cedula
    {
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public string IdSexo { get; set; }
        public string IdEstadoCivil { get; set; }
        public string IDEstatus { get; set; }
        public string EstatusCedulaAzul { get; set; }
        public string CedulaAnterior { get; set; }
        public bool ok { get; set; }
        public string foto { get; set; }
    }