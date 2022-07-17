namespace LeapYear
{
    public class LeapYear
    {
        public LeapYear() { }

        public bool Check(int year)
        {
            if((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                return true;

            return false;
        }
    }
}