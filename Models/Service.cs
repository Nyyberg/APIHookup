using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class Service
{
    public int ServiceNr { get; set; }

    public string? LinieNr { get; set; }

    public DateTime? DatoStart { get; set; }

    public DateTime? DatoUdført { get; set; }

    public string? Priotet { get; set; }

    public string? Tekst { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
