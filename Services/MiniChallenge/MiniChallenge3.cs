
namespace MiniChallenges2_4.Services.MiniChallenge
{
    public class MiniChallenge3 : IMiniChallenge3
    {
        public MiniChallenge3()
        {
            
        }
        public string NameAndTime(string userName, string wakeUpTime)
        {
            return $"Nice to meet you {userName}! Wow, you woke up at {wakeUpTime}!";
        }
    }
}