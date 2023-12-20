using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblMatNavne
{
    public int Id { get; set; }

    public string? MatrNr { get; set; }

    public string? MatrNavn { get; set; }

    public int? Densitet { get; set; }

    public decimal? KgPris { get; set; }
}
