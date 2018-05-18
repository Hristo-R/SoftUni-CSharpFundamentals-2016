namespace FractionCalculator
{
    using System;
    using System.Numerics;

    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get
            {
                return this.numerator;
            }

            set
            {
                this.numerator = value;
            }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }

            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("The denominator cannot be 0.");
                }

                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            BigInteger numerator = (fraction1.Numerator * fraction2.Denominator) + (fraction2.Numerator * fraction1.Denominator);
            BigInteger denominator = fraction1.Denominator * fraction2.Denominator;

            if (numerator > long.MaxValue || numerator < long.MinValue)
            {
                throw new ArgumentOutOfRangeException("Numerator is outside of range [-9223372036854775808 … 9223372036854775807]");
            }

            if (denominator > long.MaxValue || denominator < long.MinValue)
            {
                throw new ArgumentOutOfRangeException("Denumerator  is outside of range  [-9223372036854775808 … 9223372036854775807].");
            }

            return new Fraction((long)numerator, (long)denominator);
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            BigInteger numerator = (fraction1.Numerator * fraction2.Denominator) - (fraction2.Numerator * fraction1.Denominator);
            BigInteger denominator = fraction1.Denominator * fraction2.Denominator;

            if (numerator > long.MaxValue || numerator < long.MinValue)
            {
                throw new ArgumentOutOfRangeException("Numerator is outside of range [-9223372036854775808 … 9223372036854775807].");
            }

            if (denominator > long.MaxValue || denominator < long.MinValue)
            {
                throw new ArgumentOutOfRangeException("Denumerator  is outside of range  [-9223372036854775808 … 9223372036854775807].");
            }

            return new Fraction((long)numerator, (long)denominator);
        }

        public override string ToString()
        {
            return string.Format("{0}", (decimal)this.Numerator / this.Denominator);
        }
    }
}