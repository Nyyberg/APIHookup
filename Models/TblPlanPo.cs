using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblPlanPo
{
    public int PlanPosId { get; set; }

    public int? PosRevId { get; set; }

    public int? OperationId { get; set; }

    public float? PlanTimer { get; set; }

    public int? LeadDage { get; set; }

    public int? LeadStart { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual TblPositioner? PosRev { get; set; }
}
