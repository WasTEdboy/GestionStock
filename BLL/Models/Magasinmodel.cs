using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BLL.Models;

public partial class Magasinmodel
{
    public int IdMagazin { get; set; }

    public string Nom { get; set; } = null!;

}
