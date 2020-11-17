using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RandomeWord.Controllers {
  [ApiController]
  [Route("word")]
  public class WordController : ControllerBase {
    private readonly Logic _logic;
    public WordController(Logic logic) {
      _logic = logic;
    }

    [HttpGet]
    public string Get() {
      return _logic.GetRandomWord();
    }

    [HttpGet("noun")]
    public string GetNoun() {
      return _logic.GetRandomNoun();
    }
  }
}
