namespace apihookup.be
{
    public class CustomCalender
    {
        public bool isEveryDay { get; set; }
        public bool isEveryWeek { get; set; }
        public bool isEveryMonth { get; set; }
        public DateTime? timeOfDay { get; set; }
        public List<DateTime>? customInterval { get; set; }
    }
}
