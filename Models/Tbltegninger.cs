using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class Tbltegninger
{
    public int TegId { get; set; }

    public int? LinieId { get; set; }

    public string? TegPath { get; set; }

    public virtual Tbllinie? Linie { get; set; }
}
