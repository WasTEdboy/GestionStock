using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Web_Api.Repository.Entities;

public partial class Locationmodel
{
    public int IdMagasinier { get; set; }

    public int IdMagazin { get; set; }

    public int IdEmplacement { get; set; }

    public int IdInventaire { get; set; }

    public string CodeArticle { get; set; } = null!;

    public int Quantity { get; set; }

    public string Us { get; set; } = null!;

    public DateTime Date { get; set; }

    public virtual Stock CodeArticleNavigation { get; set; } = null!;

    public virtual Emplacement IdEmplacementNavigation { get; set; } = null!;

    public virtual Inventaire IdInventaireNavigation { get; set; } = null!;

    public virtual Magasinier IdMagasinierNavigation { get; set; } = null!;

    public virtual Magasin IdMagazinNavigation { get; set; } = null!;
}
