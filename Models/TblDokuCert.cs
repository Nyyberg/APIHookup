using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblDokuCert
{
    public int DokuCertId { get; set; }

    public int? PosRevId { get; set; }

    public string? DokuFile { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateSent { get; set; }
}
