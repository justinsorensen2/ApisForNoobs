using System;
using Microsoft.AspNetCore.Mvc;

namespace ExplosiveAPI.Controllers
{

  [Route("[controller]")]
  [ApiController]

  public class ExplodingController : ControllerBase
  {
    [HttpGet("exploding")]

    public String Exploding(string s)
    {


      var answerString = "";
      foreach (var letter in s)
      {
        var number = int.Parse(letter.ToString());
        for (var i = 0; i < number; i++)
        {
          answerString += letter;
        }
      }
      return answerString;
    }
  }
}