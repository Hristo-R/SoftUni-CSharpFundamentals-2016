namespace Problem_02.LaptopShop
{
    using System;
    using System.Text;

    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private string batteryType;
        private string batteryLife;
        private decimal price;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(
            string model,
            string manufacturer,
            string processor,
            string ram,
            string graphicsCard,
            string hdd,
            string screen,
            string batteryType,
            string batteryLife,
            decimal price)
            : this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hdd;
            this.BatteryType = batteryType;
            this.BatteryLife = batteryLife;
            this.Screen = screen;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (value == null || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Input data is invalid");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Input data is invalid");
                }

                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Input data is invalid");
                }

                this.processor = value;
            }
        }

        public string RAM
        {
            get
            {
                return this.ram;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Input data is invalid");
                }

                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Input data is invalid");
                }

                this.graphicsCard = value;
            }
        }

        public string HDD
        {
            get
            {
                return this.hdd;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Input data is invalid");
                }

                this.hdd = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Input data is invalid");
                }

                this.screen = value;
            }
        }

        public string BatteryType
        {
            get
            {
                return this.batteryType;
            }

            set
            {
                this.batteryType = value;
            }
        }

        public string BatteryLife
        {
            get
            {
                return this.batteryLife;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Input data is invalid");
                }

                this.batteryLife = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Input data is invalid");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder laptop = new StringBuilder();
            laptop.AppendLine("Sample laptop description:");
            laptop.AppendLine("model: " + this.Model);

            if (this.Manufacturer != null)
            {
                laptop.AppendLine("manufacturer: " + this.Manufacturer);
            }

            if (this.Processor != null)
            {
                laptop.AppendLine("processor: " + this.Processor);
            }

            if (this.RAM != null)
            {
                laptop.AppendLine("RAM: " + this.RAM);
            }

            if (this.graphicsCard != null)
            {
                laptop.AppendLine("graphics card: " + this.graphicsCard);
            }

            if (this.HDD != null)
            {
                laptop.AppendLine("HDD: " + this.HDD);
            }

            if (this.Screen != null)
            {
                laptop.AppendLine("screen: " + this.Screen);
            }

            laptop.AppendLine("price: " + this.Price + " lv");

            return laptop.ToString();
        }
    }
}