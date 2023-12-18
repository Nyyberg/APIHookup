using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblPositioner
{
    public int PosRevId { get; set; }

    public int TilbudId { get; set; }

    public int PosNr { get; set; }

    public int? RevNr { get; set; }

    public string? ItemNr { get; set; }

    public byte? Status { get; set; }

    public DateTime? RevDato { get; set; }

    public decimal? Pris { get; set; }

    public int? Antal { get; set; }

    public float? Masse { get; set; }

    public int? Dn { get; set; }

    public string? Ktype { get; set; }

    public byte? Iprod { get; set; }

    public int? AntalRev { get; set; }

    public int? SubStatus { get; set; }

    public int? Priorititet { get; set; }

    public int? DokuStatus { get; set; }

    public string? Transportdag { get; set; }

    public float? TotalTimer { get; set; }

    public int? NProduktion { get; set; }

    public int? NTransport { get; set; }

    public int? NFaktura { get; set; }

    public DateTime? OrdreDato { get; set; }

    public float? TidBalg { get; set; }

    public float? TidSort { get; set; }

    public int? Afsluttet { get; set; }

    public float? ReelMasseStk { get; set; }

    public int? LagtUd { get; set; }

    public DateTime? AfsluttetDato { get; set; }

    public string? Valuta { get; set; }

    public decimal? PrisIvaluta { get; set; }

    public decimal? PrisTotal { get; set; }

    public int? AntalDelLev { get; set; }

    public int? IsCurrent { get; set; }

    public int? CurrentRev { get; set; }

    public int? ProdId { get; set; }

    public bool? Planlagt { get; set; }

    public double? Faktureret { get; set; }

    public float? PlanTidSort { get; set; }

    public float? PlanTidRust { get; set; }

    public DateTime? AfsluttetD { get; set; }

    public float? PlanTidHalvfab { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual ICollection<TblPlanPo> TblPlanPos { get; set; } = new List<TblPlanPo>();

    public virtual ICollection<TblRekvTransport> TblRekvTransports { get; set; } = new List<TblRekvTransport>();

    public virtual ICollection<TblStykliste> TblStyklistes { get; set; } = new List<TblStykliste>();

    public virtual TblTilbud Tilbud { get; set; } = null!;
}
