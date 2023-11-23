using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TbllinieCorrupted
{
    public int LinieId { get; set; }

    public int? RekvId { get; set; }

    public string? Beskrivelse { get; set; }

    public string? Antal { get; set; }

    public bool? Modtaget { get; set; }

    public bool? Faktura { get; set; }

    public int? PosRevId { get; set; }

    public int? PosNr { get; set; }

    public int? RevNr { get; set; }

    public string? ItemPos { get; set; }

    public bool? Tegning { get; set; }

    public bool? Certifikat { get; set; }

    public bool? Godkendt { get; set; }

    public DateTime? ModtagetD { get; set; }

    public DateTime? GodkendtD { get; set; }

    public string? Stnr { get; set; }

    public int? VareId { get; set; }

    public string? VareEnhed { get; set; }

    public float? PrisIalt { get; set; }

    public int? ModtagetAf { get; set; }

    public int? GodkendtAf { get; set; }

    public int? ChargeId { get; set; }

    public int? FakId { get; set; }

    public float? EnhPris { get; set; }

    public string? Valuta { get; set; }

    public string? Port { get; set; }

    public bool? Materiale { get; set; }

    public bool? MedCert { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
