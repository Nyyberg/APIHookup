using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblPlanProd
{
    public int PlanProdId { get; set; }

    public int? TilbudId { get; set; }

    public string? LevUgeDag { get; set; }

    public DateTime? LevDato { get; set; }

    public DateTime? ProdStartDato { get; set; }

    public int? BeregnetLeadTime { get; set; }

    public bool? Faktureret { get; set; }

    public int? LevNo { get; set; }

    public int? RekvId { get; set; }

    public double? FakturaAmount { get; set; }

    public DateTime? FakturaEndDate { get; set; }

    public int? PlanProdStatus { get; set; }

    public bool? Godkendt { get; set; }

    public bool? Afsluttet { get; set; }

    public DateTime? AfsluttetD { get; set; }

    public DateTime? HalvFabStartD { get; set; }

    public DateTime? HalvfabSlutD { get; set; }

    public DateTime? Hal1StartD { get; set; }

    public DateTime? Hal1SlutD { get; set; }

    public DateTime? Hal2StartD { get; set; }

    public DateTime? Hal2SlutD { get; set; }

    public DateTime? HydroStartD { get; set; }

    public DateTime? HydroSlutD { get; set; }

    public DateTime? BalgStartD { get; set; }

    public DateTime? BalgSlutD { get; set; }

    public float? HalvFabTimer { get; set; }

    public float? Hal1Timer { get; set; }

    public float? Hal2Timer { get; set; }

    public float? HydroTimer { get; set; }

    public float? BalgTimer { get; set; }

    public bool? HalvFabKlar { get; set; }

    public bool? SortKlar { get; set; }

    public bool? BalgKlar { get; set; }

    public float? SortTimerSum { get; set; }

    public float? RustTimerSum { get; set; }

    public bool? Hal1Klar { get; set; }

    public bool? Hal2Klar { get; set; }

    public bool? BalgrumKlar { get; set; }

    public bool? HydroKlar { get; set; }

    public float? HalvFabTimerBrugt { get; set; }

    public float? Hal1TimerBrugt { get; set; }

    public float? Hal2TimerBrugt { get; set; }

    public float? HydroTimerBrugt { get; set; }

    public float? BalgTimerBrugt { get; set; }

    public bool? JoblisterOk { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual ICollection<TblPlanProdLinie> TblPlanProdLinies { get; set; } = new List<TblPlanProdLinie>();
}
