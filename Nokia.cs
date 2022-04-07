using System;


public class Nokia : Phone, IRingable 
{
    public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
        : base(versionNumber, batteryPercentage, carrier, ringTone) {isUnlocked = false;}
        private bool isUnlocked;
        private static string silentTone = "SHHHH"; 
    public string Ring() 
    {
        return (isUnlocked) ? RingTone : silentTone;
    }
    public string Unlock() 
    {
        isUnlocked = true;
         return "Unlocked";
    }
    public override void DisplayInfo() 
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$");     
            Console.WriteLine($"Nokia: {VersionNumber}");
            Console.WriteLine($"Carrier: {Carrier}");
            Console.WriteLine($"Ring Tone: {RingTone}");
            Console.WriteLine("$$$$$$$$$$$$$$$$$");
        } 
}

