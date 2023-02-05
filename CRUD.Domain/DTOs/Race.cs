using System;

namespace CRUD.Domain.DTOs
{
    public class Race
    {
        public int id { get; set; }
        public int competidor_id { get; set; }
        public int pista_id { get; set; }
        public DateTime data { get; set; }
        public decimal tempo_gasto { get; set; }
    }
}
