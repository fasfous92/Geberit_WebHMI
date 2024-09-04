using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models.Entities.ACB
{
    [Keyless]

    public class BenchTotal
    {
        public int id { get; set; }
        public int BenchID { get; set; }
        public DateTime TimestampcolConsumption { get; set; }
        public float Volauto01 { get; set; }
        public float Volauto02 { get; set; }
        public float Volhand01 { get; set; }
        public float Volhand02 { get; set; }
        public float Temperature { get; set; }
        public String operating_mode { get; set; }

        public int Casting_Counter { get; set; }
        public DateTime TotalTime { get; set; }
        public DateTime RestTime { get; set; }

        public DateTime TimestampcolRecipe { get; set; }
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

        public BenchTotal(benchConsumption benchConsumption, castProcess castProcess)
        {
            this.BenchID = benchConsumption.BenchID;
            this.TimestampcolConsumption = benchConsumption.Timestampcol;
            this.Volauto01 = benchConsumption.Volauto01;
            this.Volauto02 = benchConsumption.Volauto02;
            this.Volhand01 = benchConsumption.Volhand01;
            this.Volhand02 = benchConsumption.Volhand02;
            this.Temperature = benchConsumption.Temperature;
            OperatingMode operatingMode = new OperatingMode();
            this.operating_mode = operatingMode.mode.GetValueOrDefault(benchConsumption.operating_mode);
            this.Casting_Counter = benchConsumption.Casting_Counter;
            this.TotalTime = benchConsumption.TotalTime;
            this.RestTime = benchConsumption.RestTime;
            this.TimestampcolRecipe = castProcess.Timestampcol;
            this.Target_Time_Predraining = castProcess.Target_Time_Predraining;
            this.Target_Time_Prefilling_Pipe = castProcess.Target_Time_Prefilling_Pipe;
            this.Target_Time_Circulate_air_after_hardening = castProcess.Target_Time_Circulate_air_after_hardening;
            this.Time_Shift_Between_1_To_Last_Mould = castProcess.Time_Shift_Between_1_To_Last_Mould;
            this.Target_Time_Filling = castProcess.Target_Time_Filling;
            this.Target_Time_Bodybuilding = castProcess.Target_Time_Bodybuilding;
            this.Target_Time_Draining = castProcess.Target_Time_Draining;
            this.Target_Time_Hardening = castProcess.Target_Time_Hardening;
            this.Target_Time_Emptying_pipe = castProcess.Target_Time_Emptying_pipe;
            this.Target_Time_Circulating_Air = castProcess.Target_Time_Circulating_Air;
            this.Time_Valve_Group_Vg81 = castProcess.Time_Valve_Group_Vg81;
            this.Time_Valve_Group_Vg82 = castProcess.Time_Valve_Group_Vg82;
            this.Time_Valve_Group_Vg83 = castProcess.Time_Valve_Group_Vg83;
            this.Time_Valve_Group_Vg91 = castProcess.Time_Valve_Group_Vg91;
            this.Time_Valve_Group_Vg92 = castProcess.Time_Valve_Group_Vg92;
            this.Time_Valve_Group_Vg93 = castProcess.Time_Valve_Group_Vg93;
            this.Time_Valve_Group_Vg94 = castProcess.Time_Valve_Group_Vg94;

        }


    }
}
