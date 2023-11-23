using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblMaterialer
{
    public int MatId { get; set; }

    public int? EmneId { get; set; }

    public int? MatStatus { get; set; }

    public string? RekvNr { get; set; }

    public string? Stnr { get; set; }

    public string? ChargeNr { get; set; }

    public DateTime? Dato { get; set; }

    public float? Dim1 { get; set; }

    public float? Dim2 { get; set; }

    public float? Dim3 { get; set; }

    public string? Norm { get; set; }

    public float? Styk { get; set; }

    public float? Masse { get; set; }

    public int? Length { get; set; }

    public string? MatrNr { get; set; }

    public string? MatrNavn { get; set; }

    public string? CertLink { get; set; }

    public string? FolgeLink { get; set; }

    public float? Pris { get; set; }

    public string? Remarks { get; set; }

    public string? Placering { get; set; }

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

    public int? Stnum { get; set; }

    public int? ChargeId { get; set; }

    public string? ChargeNrModtaget { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual Tbllinie? Linie { get; set; }

    public virtual ICollection<TblAftraek> TblAftraeks { get; set; } = new List<TblAftraek>();

    public virtual ICollection<TblForbrug> TblForbrugs { get; set; } = new List<TblForbrug>();

    public virtual ICollection<TblLagerOptNy> TblLagerOptNies { get; set; } = new List<TblLagerOptNy>();

    public virtual ICollection<TblLager> TblLagers { get; set; } = new List<TblLager>();
}
