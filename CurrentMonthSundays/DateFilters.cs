
// Saving Current Date
DateTime today = DateTime.Now;
// find out the days of month
int daysInMonth = DateTime.DaysInMonth(today.Year, today.Month);
// iterate by incrementing the date and fetch only sundays 
IEnumerable<DateTime> dates = Enumerable.Range(1, daysInMonth)
                            .Select(n => new DateTime(today.Year, today.Month, n))
                            .Where(date => date.DayOfWeek == DayOfWeek.Sunday)
                            .ToArray();
// print out all the dates of sundays
foreach (DateTime date in dates)
{ Console.WriteLine(date); }