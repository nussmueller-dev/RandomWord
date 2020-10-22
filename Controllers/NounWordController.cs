using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomeNounWord;

namespace RandomeWord.Controllers {
  [ApiController]
  [Route("api/word/noun")]
  public class NounWordController : ControllerBase {

    [HttpGet]
    public string Get() {
      NounWordList wordList = new NounWordList();
      return wordList.getRandomeWord();
    }
  }
}
