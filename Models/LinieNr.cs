using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class LinieNr
{
    public int Id { get; set; }

    public string? Tekst { get; set; }

    public string LinieNr1 { get; set; } = null!;

    public string? År { get; set; }

    public string? Andet { get; set; }

    public string? Plasering { get; set; }

    public string? SerieNr { get; set; }

    public bool? Drift { get; set; }

    public string? Bemærkninger { get; set; }

    public string? Godkendt { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual ICollection<Maskinkartotekt> Maskinkartotekts { get; set; } = new List<Maskinkartotekt>();

    public virtual MærkepladeTabel? MærkepladeTabel { get; set; }

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
