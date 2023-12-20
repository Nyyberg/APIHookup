using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class KapabilitetForsp
{
    public string LinieNr { get; set; } = null!;

    public string? Tekst { get; set; }

    public string? Kapabillitet { get; set; }

    public string? PdfFilVedhæftet { get; set; }
}
