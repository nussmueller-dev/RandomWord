using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RandomeWord.Controllers {
  [Route("sentence")]
  [ApiController]
  public class SentenceController : ControllerBase {
    private readonly Logic _logic;
    public SentenceController(Logic logic) {
      _logic = logic;
    }

    [HttpGet]
    public string Get() {
      return _logic.GetRandomSentence();
    }
  }
}
