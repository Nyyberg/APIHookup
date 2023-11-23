using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblPlanProdLinie
{
    public int PlanLinieId { get; set; }

    public int PlanProdId { get; set; }

    public int PosRevId { get; set; }

    public int? AntalProd { get; set; }

    public virtual TblPlanProd PlanProd { get; set; } = null!;
}
