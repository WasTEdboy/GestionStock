using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BLL.Models;

public partial class Stockmodel
{
    public string Us { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public int Quantity { get; set; }

}
