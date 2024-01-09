
namespace MiniChallenges2_4.Services.MiniChallenge;

public class MiniChallenge2 : IMiniChallenge2
{
    public MiniChallenge2()
    {
        
    }
    public string AddNumbers(string firstNum, string secondNum)
    {
        bool isNum1 = double.TryParse(firstNum, out double realNum1);
        bool isNum2 = double.TryParse(secondNum, out double realNum2);

        if(isNum1 && isNum2){
            double total = realNum1 + realNum2;
            return $"The total of {realNum1} and {realNum2} is {total}.";
        }else{
            return $"Either your first input, {firstNum} , or your second input, {secondNum} , wasn't a valid number. Or Both! Please try again. ";
        }
    }
}
