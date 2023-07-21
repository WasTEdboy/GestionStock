using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Web_Api.Repository.Entities;

[Table("Stock")]
public partial class Stock
{
    [Column("US")]
    [StringLength(50)]
    public string Us { get; set; } = null!;

    [Key]
    [StringLength(50)]
    public string CodeArticle { get; set; } = null!;

    public int Quantity { get; set; }

    [InverseProperty("CodeArticleNavigation")]
    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
}
