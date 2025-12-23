using System;

namespace Assignment1;

public class Desktop: Computer
{

    public int PowerSupplyVolt{get; set;}

    public int MonitorSize{get; set;}


    public double DesktopPriceCalculation()
    {
        int processorCost = 0;

        if (Processor == "i3")
            processorCost = 1500;
        else if (Processor == "i5")
            processorCost = 3000;
        else if (Processor == "i7")
            processorCost = 4500;

        double finalPrice = processorCost + (this.RamSize * this.RamPrice) + (this.HardDiskSize * this.HardDiskPrice) + (this.GraphicCard * this.GraphicCardPrice) + (this.MonitorSize * this.MonitorPrice) + (this.PowerSupplyVolt * this.PowerSupplyPrice);

        return finalPrice;
    }

}
