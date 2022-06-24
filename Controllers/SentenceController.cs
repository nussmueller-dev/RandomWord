using Microsoft.AspNetCore.Mvc;
using RandomWord.Logic;

namespace RandomeWord.Controllers {
  [Route("sentence")]
  [ApiController]
  public class SentenceController : ControllerBase {
    private readonly Logic _logic;

    public SentenceController(Logic logic) {
      _logic = logic;
    }

    [HttpGet]
    [Produces("application/json")]
    public IActionResult Get() {
      return Ok(_logic.GetRandomSentence());
    }
  }
}
