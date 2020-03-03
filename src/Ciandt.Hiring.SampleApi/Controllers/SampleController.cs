using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Ciandt.Hiring.SampleApi
{
    [ApiController]
    [Route("api/[controller]")]
    public class SampleController : ControllerBase
    {
        private readonly SampleContext _context;

        public SampleController(SampleContext context)
        {
            _context = context;
        }

        [HttpGet]
        public Musica Get()
        {
            return  _context.Musicas.First();
        }
    }


}
