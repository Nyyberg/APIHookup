using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblNcr
{
    public int Ncrid { get; set; }

    public string? Ncrname { get; set; }

    public DateTime? Dcreated { get; set; }

    public string? CreatedBy { get; set; }

    public int? KundeId { get; set; }

    public int? SupplierId { get; set; }

    public string? Kunde { get; set; }

    public string? Supplier { get; set; }

    public string? KundeContact { get; set; }

    public string? SupplierContact { get; set; }

    public string? KundeMail { get; set; }

    public string? SupplierMail { get; set; }

    public string? KundePhone { get; set; }

    public string? KundeNcrid { get; set; }

    public string? KundePono { get; set; }

    public string? Product { get; set; }

    public string? EndUser { get; set; }

    public bool? Levering { get; set; }

    public bool? KundeKlage { get; set; }

    public bool? Intern { get; set; }

    public string? DescriptionNc { get; set; }

    public string? HandlingNc { get; set; }

    public string? CauseNc { get; set; }

    public string? PreventiveAction { get; set; }

    public string? CorrectiveAction { get; set; }

    public int? FailCodeId { get; set; }

    public int? HandCodeId { get; set; }

    public DateTime? Dclosed { get; set; }

    public string? ClosedBy { get; set; }

    public string? OurJopNumber { get; set; }

    public string? OurPonumber { get; set; }

    public string? FailCode { get; set; }

    public string? HandCode { get; set; }

    public string? HandCodeDesc { get; set; }

    public decimal? Cost { get; set; }

    public float? Hours { get; set; }

    public string? Ansvarlig { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
