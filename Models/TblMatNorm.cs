using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblMatNorm
{
    public int MatNormId { get; set; }

    public int? MatTypeId { get; set; }

    public string? MatrNr { get; set; }

    public string? MatNorm { get; set; }

    public bool? Seamless { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
