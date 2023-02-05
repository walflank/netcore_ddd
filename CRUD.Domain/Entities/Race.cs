using System;

namespace CRUD.Domain.Entities
{
    public class Race
    {
        public Race()
        {
            Competidor = new HashSet<Competidor>();
            Pista = new HashSet<Pista>();
        }
        public int id { get; set; }
        public int competidor_id { get; set; }
        public int pista_id { get; set; }
        public DateTime data { get; set; }
        public decimal tempo_gasto { get; set; }
        public virtual ICollection<Competidor> Competidor { get; set; }
        public virtual Pista Pista { get; set; }
    }
}
