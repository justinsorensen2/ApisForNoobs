using System;
using Microsoft.AspNetCore.Mvc;

namespace ExplosiveAPI.Controllers
{

  [Route("[controller]")]
  [ApiController]

  public class MumblingController : ControllerBase
  {
    [HttpGet("mumbling")]

    public String Mumbling(string s)
    {

      s.ToLower();
      s = s.ToLower();
      // index = 0
      var timesToRepeatTheLetter = 1;
      var answerString = "";
      // foreach letter in s
      foreach (var letter in s)
      {
        //.  repeat the letter timesToRepeatTheLetter times
        for (var i = 0; i < timesToRepeatTheLetter; i++)
        {
          if (i == 0)
          {
            answerString += letter.ToString().ToUpper();
          }
          else
          {
            answerString += letter.ToString();
          }
        }
        answerString += "-";
        timesToRepeatTheLetter++;
      }
      return answerString.TrimEnd('-');
    }
  }
}
