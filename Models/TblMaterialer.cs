using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblMaterialer
{
    public int MatId { get; set; }

    /// <summary>
    /// Emnetype ID
    /// </summary>
    public int? EmneId { get; set; }

    /// <summary>
    /// 1, alt er forbrugt
    /// </summary>
    public int? MatStatus { get; set; }

    /// <summary>
    /// Rekvisitionsnummer
    /// </summary>
    public string? RekvNr { get; set; }

    /// <summary>
    /// Intern chargenr
    /// </summary>
    public string? Stnr { get; set; }

    /// <summary>
    /// Certifikat chargenr
    /// </summary>
    public string? ChargeNr { get; set; }

    /// <summary>
    /// Materiale oprettet d.
    /// </summary>
    public DateTime? Dato { get; set; }

    /// <summary>
    /// L,        , PN
    /// </summary>
    public float? Dim1 { get; set; }

    /// <summary>
    /// B, Øu, DN, M
    /// </summary>
    public float? Dim2 { get; set; }

    /// <summary>
    /// T, T    , Norm
    /// </summary>
    public float? Dim3 { get; set; }

    public string? Norm { get; set; }

    public float? Styk { get; set; }

    public float? Masse { get; set; }

    /// <summary>
    /// Længde på rør, rundstål og gevindstænger
    /// </summary>
    public int? Length { get; set; }

    /// <summary>
    /// Werkstoff nummer efter EN
    /// </summary>
    public string? MatrNr { get; set; }

    /// <summary>
    /// Alternativt materiale navn
    /// </summary>
    public string? MatrNavn { get; set; }

    /// <summary>
    /// Link til certifikaterne
    /// </summary>
    public string? CertLink { get; set; }

    /// <summary>
    /// Link til følgesedler
    /// </summary>
    public string? FolgeLink { get; set; }

    /// <summary>
    /// Pris
    /// </summary>
    public float? Pris { get; set; }

    /// <summary>
    /// Evt. bemærkninger
    /// </summary>
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

    public virtual ICollection<TblAftraek> TblAftraeks { get; set; } = new List<TblAftraek>();

    public virtual ICollection<TblForbrug> TblForbrugs { get; set; } = new List<TblForbrug>();

    public virtual ICollection<TblLagerOptNy> TblLagerOptNies { get; set; } = new List<TblLagerOptNy>();

    public virtual ICollection<TblLager> TblLagers { get; set; } = new List<TblLager>();
}
