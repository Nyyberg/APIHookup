using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class VedligeholdelseForespørgsel
{
    public int VedligehNr { get; set; }

    public string? LinieNr { get; set; }

    public string? LinieNrTekst { get; set; }

    public int? Interval { get; set; }

    public DateTime? DatoStart { get; set; }

    public DateTime? DatoUdført { get; set; }

    public string? VedligeholdelseTekst { get; set; }
}
