namespace Problem_02.LaptopShop
{
    using System;

    public class Battery
    {
        private string batteryType;
        private string batteryLife;

        public Battery()
        {
        }

        public Battery(string batteryType)
        {
            this.BatteryType = batteryType;
        }

        public Battery(string batteryType, string batteryLife) : this(batteryType)
        {
            this.BatteryLife = batteryLife;
        }

        public string BatteryType
        {
            get
            {
                return this.batteryType;
            }

            set
            {
                if (value != null && string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Input data is invalid");
                }

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
                if (value != null && double.Parse(value) < 0)
                {
                    throw new ArgumentException("Input data is invalid");
                }

                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "battery: {0}\nbattery life: {1} hours\n",
                this.BatteryType, 
                this.BatteryLife);
        }
    }
}
