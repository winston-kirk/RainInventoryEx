using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;

namespace RainInventoryEx
{
    [BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
    public class RainInventoryExMain : BaseUnityPlugin
    {
        public const string PLUGIN_GUID = "winston_kirk.raininventoryex";
        public const string PLUGIN_NAME = "RainInventoryEx - Inventory System";
        public const string PLUGIN_VERSION = "0.0.1";

        private void OnEnable()
        {
            Console.WriteLine("RainInventoryEx - Hello RainCraftEx! Yes my dear friend, I'm here to help you out!");
        }
    }
}
