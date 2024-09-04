using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models.Entities.Ceratus
{
    public class DailyConsumption
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("Timestampcol")]
        public DateTime Date { get; set; }
        [Column("Daily_Water")]

        public float water { get; set; }
        [Column("Daily_Compressed_Air")]
        public float compressedAir { get; set; }
        [Column("Daily_Glaze")]
        public float glaze { get; set; }
        [Column("Daily_Glaze_Density")]
        public float glazeDensity { get; set; }
        [Column("Daily_Temperature")]
        public float temperature { get; set; }
        [Column("Daily_Energy_Consumption")]
        public float energy { get; set; }





    }
}
