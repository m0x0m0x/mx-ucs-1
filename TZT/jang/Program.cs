// Csharp Tezt 

using Pastel;
using System.Drawing;

namespace jang {
    class Program {
        static void Main(string[] args) {
            System.Console.WriteLine("Hello World!");
            TestFunc.Test();
        }
    }

    class TestFunc {
        public static void Test() {
            System.Console.WriteLine("Test".Pastel(Color.FromArgb(255, 0, 0)));
        }
    }
}