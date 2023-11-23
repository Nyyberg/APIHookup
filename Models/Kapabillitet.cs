using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class Kapabillitet
{
    public string LinieNr { get; set; } = null!;

    public string? Kapabillitet1 { get; set; }

    public string? PdfFilVedhæftet { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual LinieNr LinieNrNavigation { get; set; } = null!;
}
