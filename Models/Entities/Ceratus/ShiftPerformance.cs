using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models.Entities
{
    public class ShiftPerformance
    {
        public int id { get; set; }
        public int shiftId { get; set; }
        [Column("Produced_pieces_pouring")]
        public int piecesPouring { get; set; }
        [Column("Produced_pieces_glazing")]
        public int piecesGlazing { get; set; }
        [Column("Produced_pieces_unloading")]
        public int piecesUnloading { get; set; }
        [Column("Produced_pieces_conveyor")]
        public int piecesConveyor { get; set; }
        public DateTime Day_shift { get; set; }

        public DateTime Time_pouring_productive { get; set; }
        public DateTime Time_pouring_waiting_for_GL { get; set; }
        public DateTime Time_pouring_waiting_for_new_piece { get; set; }
        public DateTime Time_glazing_waiting_for_unloading { get; set; }
        public DateTime Time_machine_On { get; set; }
        public DateTime Time_machine_Off { get; set; }
        public DateTime Zycle_time_machine { get; set; }
        public DateTime Zycle_time_process { get; set; }
        public int Utilization { get; set; }

        public float Performance { get; set; }
    }
}
