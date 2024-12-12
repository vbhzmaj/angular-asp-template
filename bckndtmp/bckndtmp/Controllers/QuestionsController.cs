using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> Post([FromBody]Models.Question question)
        {
            _quizContext.Questions.Add(question);
            await _quizContext.SaveChangesAsync();
            return Ok(question);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Models.Question question)
        {
            if (id != question.Id) {
                return BadRequest();
            }
            
            _quizContext.Entry(question).State=EntityState.Modified;
            await _quizContext.SaveChangesAsync();
            return Ok(question);
        }


    }
}
