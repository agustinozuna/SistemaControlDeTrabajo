//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaControlDeTrabajo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contactos
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string NroTelefono { get; set; }
        public string Mensaje { get; set; }
        public Nullable<System.DateTime> fechaEnvio { get; set; }
    }
}