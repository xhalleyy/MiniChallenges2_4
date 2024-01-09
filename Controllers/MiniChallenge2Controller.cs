
using Microsoft.AspNetCore.Mvc;
using MiniChallenges2_4.Services.MiniChallenge;

namespace MiniChallenges2_4.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge2Controller : ControllerBase
{
    private readonly IMiniChallenge2 _miniChallenge2;

    public MiniChallenge2Controller(IMiniChallenge2 miniChallenge2)
    {
        _miniChallenge2 = miniChallenge2;
    }

    [HttpPost]
    [Route("AddNumbers/{firstNum}/{secondNum}")]
    public string AddNumbers(string firstNum, string secondNum)
    {
        return _miniChallenge2.AddNumbers(firstNum, secondNum);
    }
}
