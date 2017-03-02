public class Year
{
    public static bool IsLeap(int year)
    {
        bool isDevisibleBy4 = year % 4 == 0;
        bool isDevisibleBy100 = year % 100 == 0;
        bool isDevisibleBy400 = year % 400 == 0;

        if (isDevisibleBy4)
        {
            if (isDevisibleBy100)
            {
                if (isDevisibleBy400)
                    return true;
                else
                    return false;
            }
            return true;
        }
        else
            return false;
    }
}