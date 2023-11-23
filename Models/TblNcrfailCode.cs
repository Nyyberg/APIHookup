using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblNcrfailCode
{
    public int FailCodeId { get; set; }

    public string? FailCode { get; set; }

    public virtual ICollection<TblNcrfailCode1> TblNcrfailCode1s { get; set; } = new List<TblNcrfailCode1>();
}
