using System;

namespace InkaWebSite.Models
{
    public class Calendar
    {
        public Months CurrentMonth { get; set; } = (Months)DateTime.Now.Month;
       
        public int Month { get; set; } = DateTime.Now.Month;

        public DateTime TotalCurrentDate { get; set; } = DateTime.Now;
        public int CurrentYear { get; set; } = DateTime.Now.Year;



        public int CountTotalDayInMonth(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }
        public static int DayOfFirstDateInTheMonth(int year, int month, int day = 1)
        {
            DateTime dateTime = new DateTime(year, month, day);
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return 6;
                case DayOfWeek.Monday:
                    return 0;
                case DayOfWeek.Tuesday:
                    return 1;
                case DayOfWeek.Wednesday:
                    return 2;
                case DayOfWeek.Thursday:
                    return 3;
                case DayOfWeek.Friday:
                    return 4;
                case DayOfWeek.Saturday:
                    return 5;
               
                default:
                    return 0;
            }
        }
    }
}
