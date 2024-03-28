namespace Packages.Plugins.GamePush.Runtime.Modules
{
    using System.Runtime.InteropServices;
    using Packages.Plugins.GamePush.Runtime.Utilities;
    using UnityEngine;
    using Console = Packages.Plugins.GamePush.Runtime.Utilities.Console;

    public class GP_Experiments : MonoBehaviour
    {
        [DllImport("__Internal")]
        private static extern string GP_Experiments_Map();
        public static string Map()
        {
#if !UNITY_EDITOR && UNITY_WEBGL
            string map = GP_Experiments_Map();
            Debug.Log(map);
            return map;
#else
            if (GP_ConsoleController.Instance.ChannelConsoleLogs)
                Console.Log("EXPERIMENTS: ", "MAP");

            return null;
#endif
        }

        [DllImport("__Internal")]
        private static extern string GP_Experiments_Has(string tag, string cohort);
        public static bool Has(string tag, string cohort)
        {
#if !UNITY_EDITOR && UNITY_WEBGL
            return GP_Experiments_Has(tag, cohort) == "true";
#else
            if (GP_ConsoleController.Instance.AdsConsoleLogs)
                Console.Log("EXPERIMENTS: ", tag + " | " + cohort);
            return false;
#endif
        }
    }
}
