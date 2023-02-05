using System;

namespace CRUD.Domain.Entities
{
    public class Competidor
    {
        public int id { get; set; }
        public string nome { get; set; }
        public char sexo { get; set; }
        public decimal temperatura { get; set; }
        public decimal peso { get; set; }
        public decimal altura { get; set; }        
    }
}
