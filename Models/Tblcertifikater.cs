using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class Tblcertifikater
{
    public int CertId { get; set; }

    public int? RekvId { get; set; }

    public string? CertPath { get; set; }

    public string? En1020431 { get; set; }

    public string? En1020432 { get; set; }

    public string? Ped { get; set; }

    public string? Adw { get; set; }

    public string? Nace { get; set; }

    public string? Asme { get; set; }

    public string? FromChina { get; set; }

    public virtual Tblhoved? Rekv { get; set; }

    public virtual ICollection<TblChargeNr> TblChargeNrs { get; set; } = new List<TblChargeNr>();
}
