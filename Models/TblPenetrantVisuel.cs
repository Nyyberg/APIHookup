using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblPenetrantVisuel
{
    public int Ptvtid { get; set; }

    public int? PosRevId { get; set; }

    public string? TechnicianName { get; set; }

    public string? TechnicianIdVt { get; set; }

    public string? TechnicianIdPt { get; set; }

    public string? ObjectTemperature { get; set; }

    public string? SurfaceCondition { get; set; }

    public string? ViewingConditions { get; set; }

    public string? PreCleaning { get; set; }

    public string? Cleaning { get; set; }

    public string? PtSystem { get; set; }

    public string? PtType { get; set; }

    public string? PtRemover { get; set; }

    public string? PtDeveloper { get; set; }

    public string? PtTime { get; set; }

    public string? PtDeveloptime { get; set; }

    public string? PtProcedure { get; set; }

    public string? PtQreg { get; set; }

    public string? PtExtent1 { get; set; }

    public string? PtExtent2 { get; set; }

    public string? PtExtent3 { get; set; }

    public string? VtProcedure { get; set; }

    public string? VtQreg { get; set; }

    public string? VtQlevel { get; set; }

    public string? VtExtent1 { get; set; }

    public string? PtAccepted { get; set; }

    public string? VtAccepted { get; set; }

    public bool? Vtrpt { get; set; }

    public bool? Ptrpt { get; set; }

    public DateTime? DateFixed { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
