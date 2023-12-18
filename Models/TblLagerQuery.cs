using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblLagerQuery
{
    public int LagerId { get; set; }

    public int? MatId { get; set; }

    public float? Dim1 { get; set; }

    public float? Dim2 { get; set; }

    public float? Dim3 { get; set; }

    public string? Norm { get; set; }

    public float? Styk { get; set; }

    public short? Masse { get; set; }

    public short? Length { get; set; }

    public DateTime? OptaltD { get; set; }

    public string? Placering { get; set; }
}
