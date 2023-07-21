using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Web_Api.Repository.Entities;

[Table("Magasin")]
public partial class Magasin
{
    [Key]
    public int IdMagasin { get; set; }

    [StringLength(50)]
    public string Nom { get; set; } = null!;

    [InverseProperty("IdMagasinNavigation")]
    public virtual ICollection<Emplacement> Emplacements { get; set; } = new List<Emplacement>();

    [InverseProperty("IdMagazinNavigation")]
    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
}
