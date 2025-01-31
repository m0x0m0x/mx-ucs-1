// Interaction with contracts 

using Pastel;
using System.Drawing;
using Nethereum.Web3;

namespace jang.src {
    public class MainRun {
        public static void TopLevelFunction() {
            System.Console.WriteLine("TopLevelFunction".Pastel(Color.FromArgb(255, 0, 0)));
        }

        public static async Task<decimal> GetEthBalance(string accountAddress) 
        {
            var rpcUrl = "https://rpc.ankr.com/eth_holesky";
            var web3 = new Web3(rpcUrl);
            var balance = await web3.Eth.GetBalance.SendRequestAsync(accountAddress);
            return Web3.Convert.FromWei(balance.Value);
        }

    }
}