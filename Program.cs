using System.Runtime.InteropServices;

namespace detect_platform;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"This is Windows: {RuntimeInformation.IsOSPlatform(OSPlatform.Windows)}");
        Console.WriteLine($"  This is Linux: {RuntimeInformation.IsOSPlatform(OSPlatform.Linux)}");
        Console.WriteLine($"  This is MacOS: {RuntimeInformation.IsOSPlatform(OSPlatform.OSX)}");
        Console.WriteLine($"This is FreeBSD: {RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD)}");
    }
}
