using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblOptaellinger
{
    public int OptId { get; set; }

    public DateTime? OptDato { get; set; }

    public string? OptNavn { get; set; }

    public int? Godkendt { get; set; }

    public virtual ICollection<TblLagerOptNy> TblLagerOptNies { get; set; } = new List<TblLagerOptNy>();

    public virtual ICollection<TblLagerOpt> TblLagerOpts { get; set; } = new List<TblLagerOpt>();
}
