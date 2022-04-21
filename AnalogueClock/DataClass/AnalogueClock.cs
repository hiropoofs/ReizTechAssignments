using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalogueClockTask
{
    class AnalogueClock
    {
        public int Hour { get; private set; }
        public int Minute { get; private set; }
        public double lesserAngle { get; private set; }
        public AnalogueClock(int Hours, int Minute, TimeFormatEnum format)
        {
            this.Hour = format == TimeFormatEnum.RegularTime ? Hours : Hours > 12 ? Hours - 12 : Hours;
            this.Minute = Minute;
            lesserAngle = MeasureLesserAngle();
        }
        private double MeasureLesserAngle()
        {
            int OneHourDegrees = 360 / 12;
            int OneMinuteDegrees = 360 / 60;

            double MinuteArrow = OneMinuteDegrees * this.Minute;
            double HourArrow = OneHourDegrees * this.Hour + OneHourDegrees * ((double)this.Minute / 60);

            double angle = Math.Abs(MinuteArrow - HourArrow);
            angle = angle < 180 ? angle : 360 - angle;

            return angle;
        }
    }
}
