


namespace WebApplication3.Models.Entities.ACB
{
    public class castProcess
    {
        public int id { get; set; }
        public int BenchID { get; set; }
        public DateTime Timestampcol { get; set; }
        public int Target_Time_Predraining { get; set; }
        public int Target_Time_Prefilling_Pipe { get; set; }
        public int Target_Time_Circulate_air_after_hardening { get; set; }
        public int Time_Shift_Between_1_To_Last_Mould { get; set; }
        public int Target_Time_Filling { get; set; }
        public int Target_Time_Bodybuilding { get; set; }
        public int Target_Time_Draining { get; set; }
        public int Target_Time_Hardening { get; set; }
        public int Target_Time_Emptying_pipe { get; set; }
        public int Target_Time_Circulating_Air { get; set; }
        public int Time_Valve_Group_Vg81 { get; set; }
        public int Time_Valve_Group_Vg82 { get; set; }
        public int Time_Valve_Group_Vg83 { get; set; }
        public int Time_Valve_Group_Vg91 { get; set; }
        public int Time_Valve_Group_Vg92 { get; set; }
        public int Time_Valve_Group_Vg93 { get; set; }
        public int Time_Valve_Group_Vg94 { get; set; }
    }
}
