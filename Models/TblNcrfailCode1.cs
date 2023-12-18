using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblNcrfailCode1
{
    public int NcrfailCodeId { get; set; }

    public int? Ncrid { get; set; }

    public int? FailCodeId { get; set; }

    public string? FailCode { get; set; }

    public virtual TblNcrfailCode? FailCodeNavigation { get; set; }
}
