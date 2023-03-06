using System.Runtime.InteropServices;

namespace Calculator_App_Using_C___DLL;

class Program
{
    [DllImport("CalculatorDLL.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int Add(int a, int b);

    [DllImport("CalculatorDLL.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int Subtract(int a, int b);

    [DllImport("CalculatorDLL.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int Multiply(int a, int b);

    [DllImport("CalculatorDLL.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int Divide(int a, int b);

    static void Main(string[] args)
    {
        int a = 10;
        int b = 5;

        Console.WriteLine($"Addition: {Add(a, b)}");
        Console.WriteLine($"Subtraction: {Subtract(a, b)}");
        Console.WriteLine($"Multiplication: {Multiply(a, b)}");
        Console.WriteLine($"Division: {Divide(a, b)}");

        Console.ReadLine();
    }
}
