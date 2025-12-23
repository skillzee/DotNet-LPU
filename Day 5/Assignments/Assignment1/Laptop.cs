using System;

namespace Assignment1;

public class Laptop: Computer
{
    public int Displaysize{get; set;}
    public int BatteryVolt{get; set;}


    public double LaptopPriceCalculation()
    {

        int processorCost = 0;

        if (Processor == "i3")
            processorCost = 2500;
        else if (Processor == "i5")
            processorCost = 5000;
        else if (Processor == "i7")
            processorCost = 6500;



        double finalPrice = processorCost + (this.RamSize * this.RamPrice) + (this.HardDiskSize * this.HardDiskPrice) + (this.GraphicCard * this.GraphicCardPrice) + (this.Displaysize * this.MonitorPrice) + (this.BatteryVolt * this.PowerSupplyPrice);

        return finalPrice;
    }
}
