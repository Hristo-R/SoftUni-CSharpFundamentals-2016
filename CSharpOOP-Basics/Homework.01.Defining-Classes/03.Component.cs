namespace Problem03.PC_Catalog
{
    using System;

    public class Component
    {
        private string name;
        private string details;
        private decimal price;

        public Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Component(string name, string details, decimal price) : this(name, price)
        {
            this.Details = details;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Input data is invalid");
                }

                this.name = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Input data is invalid");
                }

                this.details = value;
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
    }
}