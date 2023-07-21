using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BLL.Models;
public partial class Inventairemodel
{
    public int IdInventaire { get; set; }

    public string MariculeInventaire { get; set; } = null!;

}
