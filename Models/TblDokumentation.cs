using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblDokumentation
{
    public int DokuReqId { get; set; }

    public int? PosRevId { get; set; }

    public bool? Vtrpt { get; set; }

    public string? Vtfile { get; set; }

    public bool? Ptrpt { get; set; }

    public string? Ptfile { get; set; }

    public bool? Ltrpt { get; set; }

    public string? Ltfile { get; set; }

    public bool? Pt20rpt { get; set; }

    public string? Pt20file { get; set; }

    public bool? Rtrpt { get; set; }

    public string? Rtfile { get; set; }

    public bool? Docrpt { get; set; }

    public string? Docfile { get; set; }

    public bool? Stprpt { get; set; }

    public string? Stpfile { get; set; }

    public string? Kategori { get; set; }

    public string? EndeTypeV { get; set; }

    public string? EndeTypeH { get; set; }

    public int? Dn { get; set; }

    public float? Tdmin { get; set; }

    public float? Td { get; set; }

    public float? Pdmin { get; set; }

    public string? Pd { get; set; }

    public string? FluidGrp { get; set; }

    public string? BellowNorm { get; set; }

    public float? TestPressure { get; set; }

    public string? CategoryText { get; set; }

    public string? ClientName { get; set; }

    public string? ClientQuoteNo { get; set; }

    public string? ClientOrderNo { get; set; }

    public string? ObjectTypeNo { get; set; }

    public string? ObjectDimension { get; set; }

    public int? PosNr { get; set; }

    public int? RevNr { get; set; }

    public string? SagsNr { get; set; }

    public string? SerialNo { get; set; }

    public string? TagNr { get; set; }

    public string? YearOfBuild { get; set; }

    public bool? Pt20extern { get; set; }

    public string? SignPtlt { get; set; }

    public string? SignVtpt { get; set; }

    public string? SignStp { get; set; }

    public string? SignDoC { get; set; }

    public bool? VtOk { get; set; }

    public bool? PtOk { get; set; }

    public bool? LtOk { get; set; }

    public bool? Pt20Ok { get; set; }

    public bool? RtOk { get; set; }

    public bool? StpOk { get; set; }

    public bool? DocOk { get; set; }

    public string? Module { get; set; }

    public DateTime? DateFixedPtvt { get; set; }

    public DateTime? DateFixedLtpt20 { get; set; }

    public DateTime? DateFixedDoc { get; set; }

    public DateTime? DateFixedStp { get; set; }

    public string? Ndtstd { get; set; }

    public string? NoBo { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
