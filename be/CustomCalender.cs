namespace apihookup.be
{
    public class CustomCalender
    {
        bool isEveryDay { get; set; }
        bool isEveryWeek { get; set; }
        bool isEveryMonth { get; set; }
        DateTime? DateTime { get; set; }
        List<DateTime>? interval { get; set; }
    }
}
