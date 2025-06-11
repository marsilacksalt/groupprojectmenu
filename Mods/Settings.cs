using GorillaNetworking;
using IIDKQuest.Classes;
using IIDKQuest.Menu;
using Il2CppSystem.Xml;
using Il2CppSystem;
using Photon.Pun;
using UnityEngine;
using UnityEngine.Device;
using static IIDKQuest.Menu.Main;
using static IIDKQuest.Settings;
using static StupidTemplate.Classes.ColorLib;
using System.Diagnostics.Eventing.Reader;

namespace IIDKQuest.Mods
{
    internal class SettingsMods
    {
        public static int changebuttonS = 0;
        public static int MenuTheme = 0;
        public static int FlightSpeed = 0;
        public static int EspTheme = 0;
        #region Menu Config
        public static void ChangeTheme()
        {
            {
                MenuTheme++;
                if (MenuTheme > 9)
                {
                    MenuTheme = 0;
                }
                if (MenuTheme == 0)
                {
                    rBorderColor = new ExtGradient { colors = GetSolidGradient(White) };
                    lBorderColor = new ExtGradient { colors = GetSolidGradient(White) };
                    tBorderColor = new ExtGradient { colors = GetSolidGradient(White) };
                    bBorderColor = new ExtGradient { colors = GetSolidGradient(White) };
                    backgroundColor = new ExtGradient { colors = GetSolidGradient(DodgerBlue) };
                    buttonColors = new ExtGradient[]
        {
            new ExtGradient{colors = GetSolidGradient(DarkDodgerBlue) }, // Disabled
            new ExtGradient{colors = GetSolidGradient(DarkDodgerBlue)} // Enabled
        };
                    textColors = new Color[]
        {
            White, // Disabled
            Red // Enabled
        };
                }
                if (MenuTheme == 1)
                {
                    rBorderColor = new ExtGradient { colors = GetSolidGradient(SkyBlue) };
                    lBorderColor = new ExtGradient { colors = GetSolidGradient(SkyBlue) };
                    tBorderColor = new ExtGradient { colors = GetSolidGradient(SkyBlue) };
                    bBorderColor = new ExtGradient { colors = GetSolidGradient(SkyBlue) };
                    backgroundColor = new ExtGradient { colors = GetSolidGradient(SteelBlue) };
                    buttonColors = new ExtGradient[]
        {
            new ExtGradient{colors = GetSolidGradient(SkyBlue) }, // Disabled
            new ExtGradient{colors = GetSolidGradient(SkyBlue)} // Enabled
        };
                    textColors = new Color[]
        {
            White, // Disabled
            Red // Enabled
        };
                }
                if (MenuTheme == 2)
                {
                    rBorderColor = new ExtGradient { colors = GetSolidGradient(DarkGreen) };
                    lBorderColor = new ExtGradient { colors = GetSolidGradient(DarkGreen) };
                    tBorderColor = new ExtGradient { colors = GetSolidGradient(DarkGreen) };
                    bBorderColor = new ExtGradient { colors = GetSolidGradient(DarkGreen) };
                    backgroundColor = new ExtGradient { colors = GetSolidGradient(Green) };
                    buttonColors = new ExtGradient[]
        {
            new ExtGradient{colors = GetSolidGradient(DarkGreen) }, // Disabled
            new ExtGradient{colors = GetSolidGradient(DarkGreen)} // Enabled
        };
                    textColors = new Color[]
        {
            White, // Disabled
            Red // Enabled
        };
                }
                if (MenuTheme == 3)
                {
                    rBorderColor = new ExtGradient { colors = GetSolidGradient(Purple) };
                    lBorderColor = new ExtGradient { colors = GetSolidGradient(Purple) };
                    tBorderColor = new ExtGradient { colors = GetSolidGradient(Purple) };
                    bBorderColor = new ExtGradient { colors = GetSolidGradient(Purple) };
                    backgroundColor = new ExtGradient { colors = GetSolidGradient(Indigo) };
                    buttonColors = new ExtGradient[]
        {
            new ExtGradient{colors = GetSolidGradient(Purple) }, // Disabled
            new ExtGradient{colors = GetSolidGradient(Purple)} // Enabled
        };
                    textColors = new Color[]
        {
            White, // Disabled
            Red // Enabled
        };
                }
                if (MenuTheme == 4)
                {
                    rBorderColor = new ExtGradient { colors = GetSolidGradient(White) };
                    lBorderColor = new ExtGradient { colors = GetSolidGradient(White) };
                    tBorderColor = new ExtGradient { colors = GetSolidGradient(White) };
                    bBorderColor = new ExtGradient { colors = GetSolidGradient(White) };
                    backgroundColor = new ExtGradient { colors = GetSolidGradient(Maroon) };
                    buttonColors = new ExtGradient[]
        {
            new ExtGradient{colors = GetSolidGradient(DarkRed) }, // Disabled
            new ExtGradient{colors = GetSolidGradient(DarkRed)} // Enabled
        };
                    textColors = new Color[]
        {
            White, // Disabled
            SkyBlue // Enabled
        };
                }
                if (MenuTheme == 5)
                {
                    rBorderColor = new ExtGradient { colors = GetSolidGradient(DarkRed) };
                    lBorderColor = new ExtGradient { colors = GetSolidGradient(DarkRed) };
                    tBorderColor = new ExtGradient { colors = GetSolidGradient(DarkRed) };
                    bBorderColor = new ExtGradient { colors = GetSolidGradient(DarkRed) };
                    backgroundColor = new ExtGradient { colors = GetSolidGradient(Red) };
                    buttonColors = new ExtGradient[]
        {
            new ExtGradient{colors = GetSolidGradient(DarkRed) }, // Disabled
            new ExtGradient{colors = GetSolidGradient(DarkRed)} // Enabled
        };
                    textColors = new Color[]
        {
            White, // Disabled
            Black // Enabled
        };
                }
                if (MenuTheme == 6)
                {
                    rBorderColor = new ExtGradient { colors = GetSolidGradient(White) };
                    lBorderColor = new ExtGradient { colors = GetSolidGradient(White) };
                    tBorderColor = new ExtGradient { colors = GetSolidGradient(White) };
                    bBorderColor = new ExtGradient { colors = GetSolidGradient(White) };
                    backgroundColor = new ExtGradient { colors = GetSolidGradient(Orange) };
                    buttonColors = new ExtGradient[]
        {
            new ExtGradient{colors = GetSolidGradient(DarkOrange) }, // Disabled
            new ExtGradient{colors = GetSolidGradient(Orange)} // Enabled
        };
                    textColors = new Color[]
        {
            White, // Disabled
            White // Enabled
        };
                }
                if (MenuTheme == 7)
                {
                    rBorderColor = new ExtGradient { colors = GetSolidGradient(DarkOrange) };
                    lBorderColor = new ExtGradient { colors = GetSolidGradient(DarkOrange) };
                    tBorderColor = new ExtGradient { colors = GetSolidGradient(DarkOrange) };
                    bBorderColor = new ExtGradient { colors = GetSolidGradient(DarkOrange) };
                    backgroundColor = new ExtGradient { colors = GetSolidGradient(Orange) };
                    buttonColors = new ExtGradient[]
        {
            new ExtGradient{colors = GetSolidGradient(Orange) }, // Disabled
            new ExtGradient{colors = GetSolidGradient(DarkOrange)} // Enabled
        };
                    textColors = new Color[]
        {
            White, // Disabled
            White // Enabled
        };
                }
                if (MenuTheme == 8)
                {
                    rBorderColor = new ExtGradient { colors = GetSolidGradient(White) };
                    lBorderColor = new ExtGradient { colors = GetSolidGradient(White) };
                    tBorderColor = new ExtGradient { colors = GetSolidGradient(White) };
                    bBorderColor = new ExtGradient { colors = GetSolidGradient(White) };
                    backgroundColor = new ExtGradient { colors = GetSolidGradient(DarkerGrey) };
                    buttonColors = new ExtGradient[]
        {
            new ExtGradient{colors = GetSolidGradient(DarkGrey) }, // Disabled
            new ExtGradient{colors = GetSolidGradient(DarkGrey)} // Enabled
        };
                    textColors = new Color[]
        {
            White, // Disabled
            Red // Enabled
        };
                }
                if (MenuTheme == 9)
                {
                    rBorderColor = new ExtGradient { colors = GetSolidGradient(Grey) };
                    lBorderColor = new ExtGradient { colors = GetSolidGradient(Grey) };
                    tBorderColor = new ExtGradient { colors = GetSolidGradient(Grey) };
                    bBorderColor = new ExtGradient { colors = GetSolidGradient(Grey) };
                    backgroundColor = new ExtGradient { colors = GetSolidGradient(DarkerGrey) };
                    buttonColors = new ExtGradient[]
        {
            new ExtGradient{colors = GetSolidGradient(DarkGrey) }, // Disabled
            new ExtGradient{colors = GetSolidGradient(DarkGrey)} // Enabled
        };
                    textColors = new Color[]
        {
            White, // Disabled
            Red // Enabled
        };
                }

                string[] LayoutNames = new string[] {
                "aqua",
                "mako",
                "forest",
                "indigo",
                "maroon",
                "wine",
                "mango",
                "mango+",
                "dark",
                "dark+",


            };

                GetIndex("Menu Theme").overlapText = "Menu Theme: " + LayoutNames[MenuTheme];
            }
        }
        public static void ChangeEspTheme()
        {
            {
                EspTheme++;
                if (EspTheme > 1)
                {
                    EspTheme = 0;
                }

                string[] LayoutNames = new string[] {
                "menu",
                "infection",


            };

                GetIndex("Esp Theme").overlapText = "Esp Theme: " + LayoutNames[EspTheme];
            }
        }
        public static void ChangeFlightSpeed()
        {
            {
                FlightSpeed++;
                if (FlightSpeed > 5)
                {
                    FlightSpeed = 0;
                }

                string[] LayoutNames = new string[] {
                "1x",
                "2x",
                "3x",
                "4x",
                "5x",


            };

                GetIndex("Adjust Flight Speed").overlapText = "Adjust Flight Speed: " + LayoutNames[FlightSpeed];
            }
        }
        public static void ChangeButtonSound()
        {
            changebuttonS++;
            if (changebuttonS > 6)
            {
                changebuttonS = 0;
            }
            string[] LayoutNames = new string[] {
                "Leaf",
                "Dirt",
                "Glass",
                "Link",
                "Bark",
                "Metal",
            };

            GetIndex("Change Button Sound").overlapText = "Change Button Sound: " + LayoutNames[changebuttonS];
        }
        public static void AntiCrashLow()
        {
            float deltaTime = 0.0f;
            deltaTime = Time.deltaTime;
            float fps = 1.0f / deltaTime;
            if (fps <= 2)
            {
                PhotonNetwork.Disconnect();
            }
        }
        public static void EnterConfig()
        {
            buttonsType = 1;
        }
        public static void LockArms()
        {
           
        }
        public static void IronMonkeFX()
        {
            
        }
        public static void Rigvisuals()
        {
            
        }
        public static void RightHand()
        {
            rightHanded = true;
        }

        public static void LeftHand()
        {
            rightHanded = false;
        }

        public static void EnableFPSCounter()
        {
            fpsCounter = true;
        }

        public static void DisableFPSCounter()
        {
            fpsCounter = false;
        }

        public static void EnableNotifications()
        {
            disableNotifications = false;
        }

        public static void DisableNotifications()
        {
            disableNotifications = true;
        }

        public static void EnableDisconnectButton()
        {
            disconnectButton = true;
        }

        public static void DisableDisconnectButton()
        {
            disconnectButton = false;
        }
        #endregion
    }
}
