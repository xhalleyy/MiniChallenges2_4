
using Microsoft.AspNetCore.Mvc;
using MiniChallenges2_4.Services.MiniChallenge;

namespace MiniChallenges2_4.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge3Controller : ControllerBase
{
    private readonly IMiniChallenge3 _miniChallenge3;

    public MiniChallenge3Controller(IMiniChallenge3 miniChallenge3)
    {
        _miniChallenge3 = miniChallenge3;
    }

    [HttpPost]
    [Route("NameAndTime/{userName}/{wakeUpTime}")]
    public string NameAndTime(string userName, string wakeUpTime)
    {
        return _miniChallenge3.NameAndTime(userName, wakeUpTime);
    }
}
