Television myTV = new SonyTV();
myTV.Wattage = 100;
myTV.TurnOn();
myTV.ChannelUp();
myTV.ChannelDown();
myTV.TurnOff();

Lamp myLamp = new DesktopLamp();
myLamp.Wattage = 50;
myLamp.TurnOn();
myLamp.TurnOff();

interface IRemoteControl
{
    void TurnOn();
    void TurnOff();
    void ChannelUp();
    void ChannelDown();
}

interface ILightControl
{
    void TurnOn();
    void TurnOff();
}

abstract class PowerAppliance
{
    public bool PowerStatus;
    public int Wattage;
}

class Television : PowerAppliance, IRemoteControl
{
    public int Channel { get; set; } = 1;

    public virtual void TurnOn()
    {
        PowerStatus = true;
        System.Console.WriteLine("TV Turn on");
    }

    public virtual void TurnOff()
    {
        PowerStatus = false;
        System.Console.WriteLine("TV Turn off");
    }

    public virtual void ChannelUp()
    {
        if (PowerStatus)
        {
            Channel++;
            System.Console.WriteLine("TV Channel up");
        }
        else
        {
            System.Console.WriteLine("TV is OFF. Can't change channel.");
        }
    }

    public virtual void ChannelDown()
    {
        if (PowerStatus)
        {
            Channel = (Channel > 1) ? Channel - 1 : 1;
            System.Console.WriteLine("TV Channel down");
        }
        else
        {
            System.Console.WriteLine("TV is OFF. Can't change channel.");
        }
    }
}

class Lamp : PowerAppliance, ILightControl
{
    public virtual void TurnOn()
    {
        PowerStatus = true;
        System.Console.WriteLine("Lamp Turn on");
    }

    public virtual void TurnOff()
    {
        PowerStatus = false;
        System.Console.WriteLine("Lamp Turn off");
    }
}

class SonyTV : Television
{
}

class DesktopLamp : Lamp
{
}