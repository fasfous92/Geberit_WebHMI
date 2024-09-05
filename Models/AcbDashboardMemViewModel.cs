using WebApplication3.Models.Entities.ACB;

namespace WebApplication3.Models
{
    public class AcbDashboardMemViewModel
    {
        public List<castProcess> benchsCast { get; set; }
        public List<BenchId> benchNumber { get; set; }

        public int SelectedBench { get; set; }
        public DateTime SelectedDate { get; set; }

        // public List<castProcess> castProcess { get; set; }
        // public List<BenchId> benchId { get; set; }

        public AcbDashboardMemViewModel()
        {
            benchsCast = null;
            benchNumber = new List<BenchId>();
        }

    }


}
