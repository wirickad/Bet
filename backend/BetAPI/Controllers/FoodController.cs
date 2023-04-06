using BetAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace BetAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodController : Controller
    {
        private FoodDBContext context;
        public FoodController(FoodDBContext temp)
        {
            context = temp;
        }
        
        public IEnumerable<MarriottFood> Get()
        {
            return context.Foods.ToArray();
        }

    }
}
