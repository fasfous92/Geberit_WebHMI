namespace WebApplication3.Models.Entities.Ceratus
{
    public class TimeShift
    {

        public Dictionary<int, string> time { get; set; }

        public TimeShift()
        {
            time = new Dictionary<int, string>();
            time.Add(1, "05:54 - 14:00");
            time.Add(2, "14:00 - 22:06");
        }


    }
}

