namespace Competitive_Programming.Problems;

public static class LeapYear
{
    //Given a year as integer, write a method that checks if year is leap.
    //Expected input and output
    //IfYearIsLeap(2016) → true
    //IfYearIsLeap(2018) → false

    public static bool IsYearLeap(int year) => (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
}
