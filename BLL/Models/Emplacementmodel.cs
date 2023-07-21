using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace BLL.Models;
public partial class Emplacementmodel
{
    public int IdEmplacement { get; set; }

    public string Nom { get; set; } = null!;

    public int IdMagasin { get; set; }

}
