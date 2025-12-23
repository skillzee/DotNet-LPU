using System;

namespace Assignment1;

public class Computer
{




    public string? Processor{get; set;}
    public int RamSize{get; set;}
    public int HardDiskSize{get; set;}
    public int GraphicCard{get; set;}


        public int RamPrice
    {
        get
        {
            return 200;
        }
    }
    public int HardDiskPrice
    {
        get
        {
            return 1500;
        }
    }
    public int GraphicCardPrice
    {
        get
        {
            return 2500;
        }
    }
    public int PowerSupplyPrice
    {
        get
        {
            return 20;
        }
    }
    public int MonitorPrice
    {
        get
        {
            return 250;
        }
    }
}