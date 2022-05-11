using System;

namespace InkaWebSite.Models
{
    public class Calendar
    {
        public Months CurrentMonth { get; set; } = (Months)DateTime.Now.Month;
       
        public int Month { get; set; } = DateTime.Now.Month;

        public DateTime TotalCurrentDate { get; set; } = DateTime.Now;
        public int CurrentYear { get; set; } = DateTime.Now.Year;
        public int CurrentDate { get; set; } = DateTime.Now.Day;



        public int CountTotalDayInMonth(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }
        public static int DayOfFirstDateInTheMonth(int year, int month, int day = 1)
        {
            DateTime dateTime = new(year, month, day);
            return dateTime.DayOfWeek switch
            {
                DayOfWeek.Sunday => 6,
                DayOfWeek.Monday => 0,
                DayOfWeek.Tuesday => 1,
                DayOfWeek.Wednesday => 2,
                DayOfWeek.Thursday => 3,
                DayOfWeek.Friday => 4,
                DayOfWeek.Saturday => 5,
                _ => 0,
            };
        }
    }
}
