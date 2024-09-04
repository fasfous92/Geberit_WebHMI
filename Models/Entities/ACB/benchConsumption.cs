namespace WebApplication3.Models.Entities.ACB
{
    public class benchConsumption
    {
        public int id { get; set; }
        public int BenchID { get; set; }
        public DateTime Timestampcol { get; set; }
        public float Volauto01 { get; set; }
        public float Volauto02 { get; set; }
        public float Volhand01 { get; set; }
        public float Volhand02 { get; set; }
        public float Temperature { get; set; }
        public int operating_mode { get; set; }

        public int Casting_Counter { get; set; }
        public DateTime TotalTime { get; set; }
        public DateTime RestTime { get; set; }

    }
}
