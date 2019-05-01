using dotnet.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    [Route("api/[controller]")]
    public class FibController : Controller
    {
        private readonly IFibService _fibService;

        public FibController(IFibService fibService)
        {
            _fibService = fibService;
        }

        [HttpGet("{n}")]
        public long Get(int n)
        {
            return _fibService.GetFibN(n);
        }
        
        [HttpGet("fast/{n}")]
        public long GetFast(int n)
        {
            return _fibService.GetFibNFast(n);
        }
    }
}