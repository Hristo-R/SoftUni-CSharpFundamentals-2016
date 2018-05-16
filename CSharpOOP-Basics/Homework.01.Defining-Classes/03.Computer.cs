namespace Problem03.PC_Catalog
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Computer
    {
        private string computerName;
        private List<Component> components;
        private decimal computerPrice;

        public Computer(string computerName, List<Component> components)
        {
            this.ComputerName = computerName;
            this.Components = components;
        }

        public string ComputerName
        {
            get
            {
                return this.computerName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Input data is invalid");
                }

                this.computerName = value;
            }
        }

        public List<Component> Components
        {
            get
            {
                return this.components;
            }

            set
            {
                this.components = value;
            }
        }

        public decimal ComputerPrice
        {
            get
            {
                return this.computerPrice;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Input data is invalid");
                }

                this.computerPrice = value;
            }
        }

        public override string ToString()
        {
            decimal totalPrice = 0M;
            StringBuilder computer = new StringBuilder();

            computer.AppendLine($"computer name: {this.computerName}\n");
            foreach (Component component in this.components)
            {
                computer.AppendLine($"component:");
                computer.AppendLine($"\t {component.Name}");
                if (component.Details != null)
                {
                    computer.AppendLine($"details:");
                    computer.AppendLine($"\t {component.Details}\n");
                }

                totalPrice += component.Price;
            }

            computer.AppendLine($"\nTotal computer price: {totalPrice.ToString():F2} BGN");

            return computer.ToString();
        }
    }
}