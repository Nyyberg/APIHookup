using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblMatriceHoveder
{
    public int HovedId { get; set; }

    public string? Navn { get; set; }

    public virtual ICollection<TblMatricerTilPunch> TblMatricerTilPunches { get; set; } = new List<TblMatricerTilPunch>();
}
