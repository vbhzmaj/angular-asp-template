using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bckndtmp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Models.Question> Get()
        {
            return new Models.Question[] {

                new Models.Question() {QuestionTxt = "Hello"},
                new Models.Question() {QuestionTxt = "Hi"}
            };
        }



        [HttpPost]
        public void Post([FromBody]Models.Question question)
        {

        }

    }
}
