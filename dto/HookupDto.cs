﻿using apihookup.be;

namespace apihookup.dto
{
    /// <summary>
    /// hookup dto contains all relevant data to call an api endpoint and is used to register and dispach api calls
    /// </summary>
    public class HookupDto
    {
        public int Id { get; set; }

        public string? Url { get; set; }

        public string? MethodType { get; set; }

        public bool? IntervalIsEveryDay { get; set; }

        public bool? IntervalIsEveryWeek { get; set; }

        public bool? IntervalIsEveryMonth { get; set; }

        public DateTime? IntervalTimeOfDay { get; set; }
    }
}
