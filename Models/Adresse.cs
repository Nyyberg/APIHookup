using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class Adresse
{
    public string FabrikatTlf { get; set; } = null!;

    public string? Fabrikat { get; set; }

    public string? Adresse1 { get; set; }

    public string? Adresse2 { get; set; }

    public string? Postnr { get; set; }

    public string? KontaktPerson1 { get; set; }

    public string? Mobilnr { get; set; }

    public virtual ICollection<Maskinkartotekt> Maskinkartotekts { get; set; } = new List<Maskinkartotekt>();
}
