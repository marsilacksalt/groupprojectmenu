using IIDKQuest.Classes;
using UnityEngine;
using static IIDKQuest.Menu.Main;
using static StupidTemplate.Classes.ColorLib;

namespace IIDKQuest
{
    internal class Settings
    {
        public static ExtGradient pointerColor = new ExtGradient { colors = GetSolidGradient(LightWhiteTransparent) };
        public static ExtGradient rBorderColor = new ExtGradient { colors = GetSolidGradient(White) };
        public static ExtGradient lBorderColor = new ExtGradient { colors = GetSolidGradient(White) };
        public static ExtGradient bBorderColor = new ExtGradient { colors = GetSolidGradient(White) };
        public static ExtGradient tBorderColor = new ExtGradient { colors = GetSolidGradient(White) };
        public static ExtGradient backgroundColor = new ExtGradient { colors = GetSolidGradient(DodgerBlue) };
        public static ExtGradient[] buttonColors = new ExtGradient[]
        {
            new ExtGradient{colors = GetSolidGradient(DarkDodgerBlue) }, // Disabled
            new ExtGradient{colors = GetSolidGradient(DarkDodgerBlue)} // Enabled
        };
        public static Color[] textColors = new Color[]
        {
            White, // Disabled
            Red // Enabled
        };

        public static Font currentFont = (Resources.GetBuiltinResource<Font>("Arial.ttf") as Font);

        public static bool fpsCounter = false;
        public static bool disconnectButton = true;
        public static bool rightHanded = false;
        public static bool leftHanded = false;
        public static bool returnButton = true;
        public static bool disableNotifications = false;

        public static KeyCode keyboardButton = KeyCode.Q;

        public static Vector3 menuSize = new Vector3(0.1f, 1f, 1f); // Depth, Width, Height
        public static int buttonsPerPage = 8;
    }
}
