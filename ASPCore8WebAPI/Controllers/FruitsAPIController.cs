using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPCore8WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsAPIController : ControllerBase
    {
        public List<string> fruits = new List<string>()
        {
            "Apple",
            "Banana",
            "Mango",
            "Cherry",
            "Grapes"

        };
        [HttpGet]
        public List<string> GetFruits()// yah action method hai yah action mehthod tab execute hoga, jab iske pass get request generate hogi 
        {
            return fruits;
        }

        [HttpGet("{id}")]
        public string GetFruitsByIndex(int id)// yah action method hai yah action mehthod tab execute hoga, jab iske pass get request generate hogi 
        {
            return fruits.ElementAt(id);
        }
    }
}
