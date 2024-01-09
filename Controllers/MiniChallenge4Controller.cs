
using Microsoft.AspNetCore.Mvc;
using MiniChallenges2_4.Services.MiniChallenge;

namespace MiniChallenges2_4.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge4Controller : ControllerBase
{
    private readonly IMiniChallenge4 _miniChallenge4;

    public MiniChallenge4Controller(IMiniChallenge4 miniChallenge4)
    {
        _miniChallenge4 = miniChallenge4;
    }

    [HttpPost]
    [Route("GreaterOrLess/{firstNum}/{secondNum}")]
    public string GreaterOrLess(string firstNum, string secondNum)
    {
        return _miniChallenge4.GreaterOrLess(firstNum, secondNum);
    }

}
