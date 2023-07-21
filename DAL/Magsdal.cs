using System.Linq;
using GestionStock.api.Repository;
using GestionStock.api.Repository.Entities;
using Web_Api.Repository.Entities;
namespace DAL
{
    public class Magsdal
    {
        public List<Magasin> Getallmag()
        {
            var db = new GestionStockDbContext();
            return db.Magasins.ToList();
        }
        public List<Inventaire> Getallinventaire()
        {
            var db = new GestionStockDbContext();
            return db.Inventaires.ToList();
        }

        public List<Emplacement> Getallemplacement()
        {
            var db = new GestionStockDbContext();
            return db.Emplacements.ToList();
        }
        public List<Magasinier> Getall()
        {
            var db = new GestionStockDbContext();
            return db.Magasiniers.ToList();
        }
        public Magasinier Getbyid(int id)
        {
            var db = new GestionStockDbContext();
            Magasinier p = db.Magasiniers.FirstOrDefault(x => x.IdMagasinier == id);
            return p;

        }
        public Stock GetStockbyid(String code)
        {
            var db = new GestionStockDbContext();
            Stock p = db.Stocks.FirstOrDefault(x => (x.CodeArticle == code || x.Us == code ));
            return p;

        }
        public void SetStock(Stock stock)
        {
            var db = new GestionStockDbContext();
            db.Add(stock);
            db.SaveChanges();
        }

        public void setLocation (String code, String user, String space, String placement)
        {
            Stock stock;
            var db = new GestionStockDbContext();
            if (db.Stocks.FirstOrDefault(x => x.Us == code) != null)
            {
                stock = db.Stocks.FirstOrDefault(s => s.Us == code);
            }
            else if (db.Stocks.FirstOrDefault(x => x.CodeArticle == code) != null)
            {
                stock = db.Stocks.FirstOrDefault(s => s.CodeArticle == code);
            }
            else
            {
                throw new Exception("invalid values");
            }
            var magasinier = db.Magasiniers.FirstOrDefault(m => m.MatMagasinier == user);
            var emplacement = db.Emplacements.FirstOrDefault(e => e.Nom == space);
            var inventaire = db.Inventaires.FirstOrDefault(g => g.MariculeInventaire == placement);

            // Create a new instance of the Location model and set its properties
            var location = new Location
            {
                IdMagasinier = magasinier?.IdMagasinier ?? 0,
                IdMagazin = emplacement?.IdMagasin ?? 0,
                IdEmplacement = emplacement?.IdEmplacement ?? 0,
                IdInventaire = inventaire.IdInventaire,
                CodeArticle = stock.CodeArticle,
                Quantity = stock.Quantity,
                Us = stock.Us,
                Date = DateTime.Now
            };

            db.Add(location);
            db.SaveChanges();

        }

        public Location GetLocations(int id)
        {
            var db = new GestionStockDbContext();
            Location l = db.Locations.FirstOrDefault(x => x.LocationId == id);
            return l;
        }




    }
}