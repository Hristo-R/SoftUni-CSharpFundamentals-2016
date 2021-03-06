﻿using System;

namespace GalacticGPS
{
    public struct Location
    {
        private double latitude;
        private double longitude;

        public Location(double latitude, double longitude, Planet planet) : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }
            set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException(
                        "The valid range of latitude in degrees is -90 and +90");
                }
                this.latitude = value;
            }
        }

        public double Longitude
        {
            get
            {
                return this.longitude;
            }
            set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException(
                        "The valid range of latitude in degrees is -180 and +180");
                }
                this.longitude = value;
            }
        }

        public Planet Planet { get; set; }

        public override string ToString()
        {
            return string.Format(
                "{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);
        }
    }
}
