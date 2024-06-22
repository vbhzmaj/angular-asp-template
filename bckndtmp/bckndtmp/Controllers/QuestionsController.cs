using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bckndtmp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {

        readonly QuizContext _quizContext;
        public QuestionsController(QuizContext context)
        {
            this._quizContext = context;
        }




        [HttpGet]
        public IEnumerable<Models.Question> Get()
        {
            return _quizContext.Questions;
            
        }



        [HttpPost]
        public void Post([FromBody]Models.Question question)
        {
            _quizContext.Questions.Add(question);
            _quizContext.SaveChanges();

        }

    }
}
