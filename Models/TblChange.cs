using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblChange
{
    public int Id { get; set; }

    public int? RegId { get; set; }

    public DateTime? TidIndNew { get; set; }

    public DateTime? TidUdNew { get; set; }

    public string? User { get; set; }

    public DateTime? ChangedD { get; set; }

    public DateTime? TidIndOld { get; set; }

    public DateTime? TidUdOld { get; set; }
}
