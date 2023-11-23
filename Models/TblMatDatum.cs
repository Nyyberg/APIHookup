using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblMatDatum
{
    public int MatId { get; set; }

    public int? EmneId { get; set; }

    public float? Dim1 { get; set; }

    public float? Dim2 { get; set; }

    public float? Dim3 { get; set; }

    public string? Norm { get; set; }

    public float? Styk { get; set; }

    public float? Masse { get; set; }

    public int? Length { get; set; }

    public string? MatrNr { get; set; }

    public string? MatrNavn { get; set; }

    public float? Pris { get; set; }

    public string? Remarks { get; set; }

    public float? EnhedsPris { get; set; }

    public string? En1020431 { get; set; }

    public string? En1020432 { get; set; }

    public string? Ped { get; set; }

    public string? Adw { get; set; }

    public string? Nace { get; set; }

    public string? Asme { get; set; }

    public string? KinaLort { get; set; }

    public int? RekvId { get; set; }

    public int? LinieId { get; set; }

    public bool? Coil { get; set; }

    public bool? Seamless { get; set; }

    public string? Finish { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
