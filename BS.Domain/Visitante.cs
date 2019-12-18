using System;
using System.Collections.Generic;

namespace BS.Domain
{
    public partial class Visitante
    {
        public int Id { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public bool? Procesado { get; set; }
    }
}
