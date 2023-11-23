using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblRekvTransport
{
    public int RekvTranId { get; set; }

    public int? RekvId { get; set; }

    public int? PosRevId { get; set; }

    public int? TranAntal { get; set; }

    public int? TranMax { get; set; }

    public virtual TblPositioner? PosRev { get; set; }
}
