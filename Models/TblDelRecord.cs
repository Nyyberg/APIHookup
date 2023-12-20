using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblDelRecord
{
    public int DelId { get; set; }

    public int? PosRevId { get; set; }

    public int? AntalProd { get; set; }

    public int? PlanProdId { get; set; }

    public int? PlanLinieId { get; set; }
}
