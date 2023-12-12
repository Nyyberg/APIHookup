using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblDesignere
{
    public int DesignerId { get; set; }

    public string Initialer { get; set; } = null!;

    public string Navn { get; set; } = null!;

    public string? Tlf { get; set; }

    public string? Mail { get; set; }

    public bool? Aktiv { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
