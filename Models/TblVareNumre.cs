using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblVareNumre
{
    public int VareId { get; set; }

    public string? VareGrpId { get; set; }

    public int? VareKatId { get; set; }

    public string? VareNr { get; set; }

    public string? VareNavn { get; set; }

    public int? EnhedId { get; set; }

    public float? Enhedspris { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
