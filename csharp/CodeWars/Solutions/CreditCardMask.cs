using System.Text;

namespace CodeWars.Solutions;

public class CreditCardMask
{
    public static string Solutions(string cc)
    {
        const int unSensorCount = 4;
        int charecterCount = cc.Length;

        if (charecterCount <= unSensorCount) return cc;

        StringBuilder resultBuilder = new StringBuilder();
        int startIndexUnSensor = charecterCount - unSensorCount;
        for (int currentIndex = 0; currentIndex < charecterCount; currentIndex++)
        {
            if (currentIndex < startIndexUnSensor)
            {
                resultBuilder.Append("#");
                continue;
            }

            resultBuilder.Append(cc[currentIndex]);
        }

        return resultBuilder.ToString();
    }
}
