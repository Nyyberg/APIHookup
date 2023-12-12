using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class Tblkunde
{
    public int RekvKundeId { get; set; }

    public string? Kunde { get; set; }

    public string? AdrUndLev { get; set; }

    public string? PostNrUndLev { get; set; }

    public string? HovedNummer { get; set; }

    public string? Valuta { get; set; }

    public int? LevTypeId { get; set; }

    public string? Gruppe { get; set; }

    public virtual ICollection<TblKontaktLev> TblKontaktLevs { get; set; } = new List<TblKontaktLev>();

    public virtual ICollection<Tblhoved> Tblhoveds { get; set; } = new List<Tblhoved>();
}
