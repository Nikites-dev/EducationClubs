using System;
using System.Globalization;

namespace EducationClubs.Services
{
    public class DateTimeService
    {
        // public static DateTime StartOfWeek(DateTime dt, System.DayOfWeek startOfWeek)
        // {
        //     int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
        //     return dt.AddDays(-1 * diff).Date;
        // }
        
        public static string GetDayNameRss(int dayNumber)
        {
            var culture = CultureInfo.CreateSpecificCulture("ru-RU");
            culture.DateTimeFormat.FirstDayOfWeek = System.DayOfWeek.Sunday;

            var dayNames = culture.DateTimeFormat.DayNames;

            return dayNames[dayNumber].Substring(0, 1).ToUpper() + dayNames[dayNumber].Substring(1);
        }

        private static String GetRuWeek()
        {
            return ((System.DayOfWeek) ((Convert.ToInt32("1")) % Enum.GetValues(typeof(System.DayOfWeek)).Length)).ToString();
        }
    }
}



// DateTime mockDate = DateTime.ParseExact("2023-10-04 14:40:52,531", "yyyy-MM-dd HH:mm:ss,fff",
//     System.Globalization.CultureInfo.InvariantCulture);
// TimeSpan ts = new TimeSpan(0, 0, 1);
// mockDate = mockDate.Date + ts;
// crntTime = mockDate;