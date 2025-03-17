using System;

interface IRemoteControl
{
    public void TurnOn();
    public void TurnOff();
    public void ChannelUp();
    public void ChannelDown();
}

abstract class PowerAppliance
{
    public bool PowerStatus;
    public int Wattage;
}

abstract class Television : PowerAppliance
{
    public int Channel { get; set; }
}

abstract class Lamp : PowerAppliance
{
}

class SonyTV : Television, IRemoteControl
{
    public void TurnOn() { System.Console.WriteLine("TV Turn on"); PowerStatus = true; }
    public void TurnOff() { System.Console.WriteLine("TV Turn off"); PowerStatus = false; }
    public void ChannelUp() { System.Console.WriteLine("TV Channel up"); }
    public void ChannelDown() { System.Console.WriteLine("TV Channel down"); }
}

class DesktopLamp : Lamp, IRemoteControl
{
    public void TurnOn() { System.Console.WriteLine("Lamp Turn on"); PowerStatus = true; }
    public void TurnOff() { System.Console.WriteLine("Lamp Turn off"); PowerStatus = false; }
    public void ChannelUp() { System.Console.WriteLine("Lamp cannot change channel"); }
    public void ChannelDown() { System.Console.WriteLine("Lamp cannot change channel"); }
}

class Program
{
    static void Main()
    {
        // Use the specific classes that implement IRemoteControl
        IRemoteControl myTV = new SonyTV();
        myTV.TurnOn();
        myTV.ChannelUp();
        myTV.ChannelDown();
        myTV.TurnOff();

        IRemoteControl myLamp = new DesktopLamp();
        myLamp.TurnOn();
        myLamp.ChannelUp();
        myLamp.ChannelDown();
        myLamp.TurnOff();
    }
}
