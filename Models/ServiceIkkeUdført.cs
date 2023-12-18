using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class ServiceIkkeUdført
{
    public string? LinieNr { get; set; }

    public string? LinieNrTekst { get; set; }

    public DateTime? DatoStart { get; set; }

    public DateTime? DatoUdført { get; set; }

    public string? ServiceTekst { get; set; }

    public int ServiceNr { get; set; }

    public string? Priotet { get; set; }
}
