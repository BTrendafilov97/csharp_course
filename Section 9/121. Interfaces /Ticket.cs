using System;

namespace InterfaceDemo
{
    class Ticket : IEquatable<Ticket>
    {
        public int DurationHours { get; set; }

        public Ticket (int durationhours)
        {
            DurationHours = durationhours;
        }

        public bool Equals(Ticket other)
        {
            return this.DurationHours == other.DurationHours;
        }

    }
}