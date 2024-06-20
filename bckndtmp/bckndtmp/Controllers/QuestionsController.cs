using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bckndtmp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        [HttpPost]
        public void Post([FromBody]Models.Question question)
        {

        }

    }
}
