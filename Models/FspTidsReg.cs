using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class FspTidsReg
{
    public int? OrdreId { get; set; }

    public int? AfdId { get; set; }

    public string? OrdreNavn { get; set; }

    public DateTime? TidInd { get; set; }

    public DateTime? TidUd { get; set; }
}
