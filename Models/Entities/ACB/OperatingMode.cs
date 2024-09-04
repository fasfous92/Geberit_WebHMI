namespace WebApplication3.Models.Entities.ACB
{

    public class OperatingMode
    {
        public Dictionary<int, string> mode { get; set; }

        public OperatingMode()
        {
            mode = new Dictionary<int, string>();
            mode.Add(0, "Aus");
            mode.Add(1, "Abzapfen");
            mode.Add(2, "Tank vorfüllen");
            mode.Add(3, "Tank vorgefüllt, warte auf Start");
            mode.Add(4, "Gießen");
            mode.Add(5, "Ausgießen");
            mode.Add(6, "Pressen");
            mode.Add(7, "Ende");
            mode.Add(10, "Tank leeren");
            mode.Add(11, "Leitung spülen");
            mode.Add(12, "Tank spülen");
            mode.Add(13, "Abzapfen beendet");
            mode.Add(14, "Leitungen vorfüllen");
            mode.Add(15, "Gießkurve angehalten");
            mode.Add(16, "Überlauf leeren");
            mode.Add(17, "Zirkulation nach Pressen fill this");
        }


    }

}
