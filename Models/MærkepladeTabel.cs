using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class MærkepladeTabel
{
    public string? Maskinnr { get; set; }

    public string LinieNr { get; set; } = null!;

    public string? FabNavn { get; set; }

    public string? Type { get; set; }

    public string? År { get; set; }

    public float? Effekt { get; set; }

    public string? Spænding { get; set; }

    public float? Strøm { get; set; }

    public int? Forsikring { get; set; }

    public int? Tilslutning { get; set; }

    public int? TilslutningTavle { get; set; }

    public float? Trykluft { get; set; }

    public float? Luftmængde { get; set; }

    public int? Vægt { get; set; }

    public string? HjælpeFelt { get; set; }

    public string? BeskrivbelseElTilslut { get; set; }

    public string? Beskrivelse { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual LinieNr LinieNrNavigation { get; set; } = null!;
}
