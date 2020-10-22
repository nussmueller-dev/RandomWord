using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RandomeWord.Controllers {
  [ApiController]
  [Route("api/word")]
  public class WordController : ControllerBase {

    [HttpGet]
    public string Get() {
      WordList wordList = new WordList();
      return wordList.getRandomeWord();
    }
  }
}
