using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class Maskinkartotekt
{
    public string Maskinnr { get; set; } = null!;

    public string? LinieNr { get; set; }

    public string? FabrikatTlf { get; set; }

    public string? Type { get; set; }

    public string? År { get; set; }

    public string? Lokation { get; set; }

    public string? DossierNr { get; set; }

    public string? Beskriv { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual Adresse? FabrikatTlfNavigation { get; set; }

    public virtual LinieNr? LinieNrNavigation { get; set; }
}
