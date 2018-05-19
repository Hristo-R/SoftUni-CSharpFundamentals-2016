namespace Problem03.PC_Catalog
{
    using System;
    using System.Collections.Generic;

    public class PcCatalog
    {
        public static void Main()
        {
            Component processor = new Component("processor", "Intel Pentium N4200", 100M);
            Component graphicCard = new Component("graphic card", "GeForce GTX 1080", 200M);
            Component motherboard = new Component("motherboard", "Gigabyte - B360 AORUS Gaming 3 WIFI", 250M);

            List<Component> wizardComponemnts = new List<Component>()
            {
                processor, graphicCard, motherboard
            };

            Computer officeWizard = new Computer("Office Wizard", wizardComponemnts);

            Console.WriteLine($"Description:\n\n{officeWizard}");
        }
    }
}
