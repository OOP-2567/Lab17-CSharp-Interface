﻿Television myTV = new SonyTV();
myTV.Wattage = 100;
myTV.TurnOn();
myTV.ChannelUp();
myTV.ChannelDown();
myTV.TurnOff();

Lamp myLamp = new DesktopLamp();
myLamp.Wattage = 50;
myLamp.TurnOn();
myLamp.ChannelUp();
myLamp.ChannelDown();
myLamp.TurnOff();

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

class Television : PowerAppliance, IRemoteControl
{
    public int Channel { get; set; }
    
    public virtual void TurnOn() { }
    public virtual void TurnOff() { }
    public virtual void ChannelUp() { }
    public virtual void ChannelDown() { }
}

class Lamp : PowerAppliance, IRemoteControl
{
    public virtual void TurnOn() { }
    public virtual void TurnOff() { }
    public virtual void ChannelUp() { }
    public virtual void ChannelDown() { }
}

class SonyTV : Television
{
    public override void TurnOn() { System.Console.WriteLine("TV Turn on"); PowerStatus = true; }
    public override void TurnOff() { System.Console.WriteLine("TV Turn off"); PowerStatus = false; }
    public override void ChannelUp() { System.Console.WriteLine("TV Channel up"); }
    public override void ChannelDown() { System.Console.WriteLine("TV Channel down"); }
}

class DesktopLamp : Lamp
{
    public override void TurnOn() { System.Console.WriteLine("Lamp Turn on"); PowerStatus = true; }
    public override void TurnOff() { System.Console.WriteLine("Lamp Turn off"); PowerStatus = false; }
    public override void ChannelUp() { System.Console.WriteLine("Lamp cannot change channel"); }
    public override void ChannelDown() { System.Console.WriteLine("Lamp cannot change channel"); }
}