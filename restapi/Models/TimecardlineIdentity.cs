using System;

namespace restapi.Models
{
    public class TimecardlineIdentity
    {
        public TimecardlineIdentity(string area, string number)
        {
            this.Area = area;
            this.Number = number;
        }

        public TimecardlineIdentity(string number) : this("line", number) { }

        public TimecardlineIdentity() : this(GetSerialNumber().ToString()) { }

        //public string Area { get; set; }

        //public string Number { get; set; }

        public string Value { get => $"{Area}-{Number}"; }

        private static long GetSerialNumber()
        {
            return new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
        }
    }
}

