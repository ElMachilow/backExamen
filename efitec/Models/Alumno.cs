﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace efitec.Models
{
    public partial class Alumno
    {
        public Alumno()
        {
            Nota = new HashSet<Nota>();
        }

        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string ApellidoMaterno { get; set; }
        public string ApellidoPaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }

        public virtual ICollection<Nota> Nota { get; set; }
    }
}