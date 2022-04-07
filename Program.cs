using System;

namespace phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy galaxyPhone = new Galaxy("Galaxy", 90, "t-mobile","dan dan dan");
            Nokia nokiaPhone = new Nokia("3310", 100, "telestet","dan dan dan dan dan");
            galaxyPhone.DisplayInfo();
            nokiaPhone.DisplayInfo();
        }
    }
}
