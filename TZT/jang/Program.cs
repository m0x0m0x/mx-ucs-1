// Csharp Tezt 

using Pastel;
using System.Drawing;
using jang.src;

namespace jang {
    class Program {
         static async Task Main(string[] args)
        {
        try
        {
            string ethAddress = "0x742d35Cc6634C0532925a3b844Bc454e4438f44e"; // Example ETH address
            decimal balance = await MainRun.GetEthBalance(ethAddress);
            Console.WriteLine($"ETH Balance: {balance.ToString()}".Pastel(Color.FromArgb(0, 255, 0)));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message.ToString()}".Pastel(Color.FromArgb(255, 0, 0)));
        }
    }
    }

}