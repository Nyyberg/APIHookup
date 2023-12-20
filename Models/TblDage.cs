using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblDage
{
    public int DagId { get; set; }

    public DateTime? DagDato { get; set; }

    public int? Hellig { get; set; }

    public float? KapHal1 { get; set; }

    public float? KapHal2 { get; set; }

    public float? KapBalgrum { get; set; }

    public float? KapHydro { get; set; }

    public float? KapHalvfab { get; set; }

    public float? KapIpo { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual ICollection<TblBelastning> TblBelastnings { get; set; } = new List<TblBelastning>();

    public virtual ICollection<TblKalender> TblKalenders { get; set; } = new List<TblKalender>();
}
