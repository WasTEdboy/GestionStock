using BLL.Models;
using GestionStock.api.Repository.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Api.Repository.Entities;

namespace Web_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class Mags : ControllerBase
    {
        private BLL.Magsbll _magsbll;
        public Mags()
        {
            _magsbll = new BLL.Magsbll();
        }

        [HttpGet]
        [Route("getallMagasinier")]
        public List<Magasiniermodel> getall()
        {
            return _magsbll.GetMagasiniers();

        }
        [HttpGet]
        [Route("getMagasinierbyid")]
        public Magasiniermodel getbyid(int id)
        {
            return _magsbll.GetMagasinier(id);
        }
        [HttpGet]
        [Route("getallMagasin")]
        public List<Magasinmodel> GetMagasin()
        {
            return _magsbll.GetMagasin();

        }
        [HttpGet]
        [Route("getallInventaire")]
        public List<Inventairemodel> GetInventaire()
        {
            return _magsbll.Getinventaire();

        }
        [HttpGet]
        [Route("getallemplacement")]
        public List<Emplacementmodel> Getemplacement()
        {
            return _magsbll.Getemplacement();

        }
        [HttpGet]
        [Route("getlocationbyid")]
        public Locationmodel GetLocationmodel(int id)
        {
            return _magsbll.GetLocations(id);

        }



        [HttpGet]
        [Route("getStockbyid")]
        public Stockmodel getStockbyid(String code)
        {
           return _magsbll.GetStockbyid(code);
        }
        


        [HttpPost]
        [Route("InsertStock")]
        public void PostStock([FromBody] Stockmodel stockmodel )
        {
            _magsbll.SetStock(stockmodel);
        }
        [HttpPost]
        [Route("InsertLocation")]
        public void Postlocation(String code, String user, String space, String placement)
        {
            _magsbll.SetLocation(code,user,space,placement);
        }
    }

}
