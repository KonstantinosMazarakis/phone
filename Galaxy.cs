using System;


public class Galaxy  : Phone, IRingable 
{
    public Galaxy (string versionNumber, int batteryPercentage, string carrier, string ringTone) 
        : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        private bool isUnlocked;
    public string Ring() 
    {
        return RingTone;
    }
    public string Unlock() 
    {
        
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

