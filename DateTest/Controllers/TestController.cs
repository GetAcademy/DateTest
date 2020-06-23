using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DateTest.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DateTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public Task<MyViewModel> Test()
        {
            return Task.FromResult(new MyViewModel {Date = DateTime.Now});
        }
    }
}
