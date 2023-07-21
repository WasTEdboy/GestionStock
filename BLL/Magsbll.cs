using AutoMapper;
using BLL.Models;
using GestionStock.api.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Web_Api.Repository.Entities;

namespace BLL
{
    public class Magsbll
    {
        private DAL.Magsdal _magsdal;
        private Mapper _magasiniers,_stock,_magasin,_inventaire,_emplacement,_location;

        public Magsbll()
        {
            _magsdal = new DAL.Magsdal();
            var _conf = new MapperConfiguration(cfg => cfg.CreateMap<Magasinier, Magasiniermodel>().ReverseMap());
            var _conf2 = new MapperConfiguration(cfg => cfg.CreateMap<Stock, Stockmodel>().ReverseMap());
            var _conf3 = new MapperConfiguration (cfg => cfg.CreateMap<Magasin, Magasinmodel>().ReverseMap());
            var _conf4 = new MapperConfiguration(cfg => cfg.CreateMap<Inventaire, Inventairemodel>().ReverseMap());
            var _conf5 = new MapperConfiguration(cfg => cfg.CreateMap<Emplacement, Emplacementmodel>().ReverseMap());
            var _conf6 = new MapperConfiguration(cfg => cfg.CreateMap<Location, Locationmodel>().ReverseMap());
            _magasiniers = new Mapper(_conf);
            _stock = new Mapper(_conf2);
            _magasin = new Mapper(_conf3);
            _inventaire = new Mapper(_conf4);
            _emplacement= new Mapper(_conf5);
            _location= new Mapper(_conf6);


        }
        public List<Magasiniermodel> GetMagasiniers()
        {
            List<Magasinier> data = _magsdal.Getall();
            List<Magasiniermodel> magasiniermodel = _magasiniers.Map<List<Magasinier>, List<Magasiniermodel>>(data);
            return magasiniermodel;
        }
        public Magasiniermodel GetMagasinier(int id)
        {
            var p = _magsdal.Getbyid(id);
            if (p == null)
            {
                throw new Exception("not found");
            }

            Magasiniermodel magasiniermodel = _magasiniers.Map<Magasinier, Magasiniermodel>(p);
            return magasiniermodel;
        }
        public List<Magasinmodel> GetMagasin()
        {
            List<Magasin> data = _magsdal.Getallmag();
            List<Magasinmodel> magasinmodel = _magasin.Map<List<Magasin>, List<Magasinmodel>>(data);
            return magasinmodel;
        }
        public List<Inventairemodel> Getinventaire()
        {
            List<Inventaire> data = _magsdal.Getallinventaire();
            List<Inventairemodel> Inventairemodel = _inventaire.Map<List<Inventaire>, List<Inventairemodel>>(data);
            return Inventairemodel;
        }
        public List<Emplacementmodel> Getemplacement()
        {
            List<Emplacement> data = _magsdal.Getallemplacement();
            List<Emplacementmodel> emplacementmodel = _emplacement.Map<List<Emplacement>, List<Emplacementmodel>>(data);
            return emplacementmodel;
        }
        public Stockmodel GetStockbyid(String code)
        {
            var stock = _magsdal.GetStockbyid(code);
            if (stock == null)
            {
                throw new Exception("Noneexistant");
            }
            Stockmodel stockmodel = _stock.Map<Stock, Stockmodel>(stock);
            return stockmodel;

        }
        public void SetStock(Stockmodel stockmodel)
        {
            Stock stock = _stock.Map<Stockmodel, Stock>(stockmodel);
            _magsdal.SetStock(stock);

        }
        public void SetLocation(String code, String user,String space,String placement)
        {
            _magsdal.setLocation(code, user, space, placement);         

        }
        public Locationmodel GetLocations(int id)
        {
            Location data = _magsdal.GetLocations(id);
            Locationmodel locationmodel = _location.Map<Location, Locationmodel>(data);
            return locationmodel;


        }

    }
    
}