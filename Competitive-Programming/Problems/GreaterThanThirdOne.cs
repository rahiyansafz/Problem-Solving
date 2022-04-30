namespace Random_Problems.Problems;

public static class GreaterThanThirdOne
{
    //Given an array of 3 integers, write a method that checks if multiplication or sum of two first numbers is greater than third one.
    //Expected input and output
    //IfGreaterThanThirdOne([2, 7, 12]) → true
    //IfGreaterThanThirdOne([-5, -8, 50]) → false

    public static bool IfGreaterThanThirdOne(int[] arr) => arr[0] + arr[1] >= arr[2] || arr[0] * arr[1] > arr[2];
}
