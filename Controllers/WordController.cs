using Microsoft.AspNetCore.Mvc;
using RandomWord.Logic;

namespace RandomeWord.Controllers {
  [ApiController]
  [Route("word")]
  public class WordController : ControllerBase {
    private readonly Logic _logic;

    public WordController(Logic logic) {
      _logic = logic;
    }

    [HttpGet]
    [Produces("application/json")]
    public IActionResult Get() {
      return Ok(_logic.GetRandomWord());
    }

    [HttpGet("noun")]
    [Produces("application/json")]
    public IActionResult GetNoun() {
      return Ok(_logic.GetRandomNoun());
    }
  }
}
