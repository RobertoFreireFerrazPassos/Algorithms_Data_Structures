namespace Algorithms_Data_Structures.Algorithms.reverserinteger;

public class ReverserInteger
{
    public static string Reverse(int N)
    {
        var result = string.Empty;
        int remaining = N;
        var isZero= remaining % 10 == 0;
        while (remaining != 0) {
            if (isZero)
            {
                remaining= remaining/10;
                isZero = remaining % 10 == 0;
            }
            else
            {
                result += remaining % 10;
                remaining = remaining / 10;
            }
        }
        return result;
    }

    public static string Reverse2(int N)
    {
        //1
        var result = string.Empty;
        var enable_print = false;
        while (N > 0)
        {
            if (enable_print == false && N % 10 != 0)
            {
                enable_print = true;
            }

            if (enable_print)
            {
                result += N % 10;
            }
            N = N / 10;
        }

        return result;
    }
}
