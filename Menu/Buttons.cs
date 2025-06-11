using IIDKQuest.Classes;
using IIDKQuest.Mods;
using static IIDKQuest.Settings;

namespace IIDKQuest.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "-settings-", method =() => SettingsMods.EnterConfig(), isTogglable = false},
                new ButtonInfo { buttonText = "-playfab-", method =() => GameMods.EnterGame(), isTogglable = false},
                new ButtonInfo { buttonText = "-world-", method =() => BasicMods.EnterBasic(), isTogglable = false},
                new ButtonInfo { buttonText = "-player-", method =() => GameMods.EnterPlayer(), isTogglable = false},
                new ButtonInfo { buttonText = "-prefabs-", method =() => World.EnterWorld(), isTogglable = false},
                new ButtonInfo { buttonText = "-visual-", method =() => Visual.EnterVisual(), isTogglable = false},
                new ButtonInfo { buttonText = "-power-", method =() => OP.EnterOP(), isTogglable = false},
            },

            //config
            new ButtonInfo[] { // Config
                new ButtonInfo { buttonText = "-back-", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Menu : Returned Home!"},
                new ButtonInfo { buttonText = "Anti Crash", method =() => SettingsMods.AntiCrashLow(), toolTip = "Dsiconnect On Low FPS"},
                new ButtonInfo { buttonText = "Switch Menu Locoation", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand()},
                new ButtonInfo { buttonText = "Fps Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Menu Theme",overlapText = "Menu Theme: aqua",  method =() => SettingsMods.ChangeTheme(), isTogglable = false, toolTip = " "},
                new ButtonInfo { buttonText = "Adjust Flight Speed",overlapText = "Adjust Flight Speed: 1x",  method =() => SettingsMods.ChangeFlightSpeed(), isTogglable = false, toolTip = " "},
                new ButtonInfo { buttonText = "Esp Theme",overlapText = "Esp Color: menu",  method =() => SettingsMods.ChangeEspTheme(), isTogglable = false, toolTip = " "},
                new ButtonInfo { buttonText = "Change Button Sound",overlapText = "Change Button Sound: Leaf", method =() => SettingsMods.ChangeButtonSound(), isTogglable = false},
                new ButtonInfo { buttonText = "Lock Arm Size", method =() => SettingsMods.LockArms(), toolTip = "Turn!", isTogglable = true},
                new ButtonInfo { buttonText = "Iron Monke FX", method =() => SettingsMods.IronMonkeFX(), toolTip = "Turn!", isTogglable = true},
                new ButtonInfo { buttonText = "Visualize Disabled Rig", method =() => SettingsMods.Rigvisuals(), toolTip = "Turn!", isTogglable = true},
                //new ButtonInfo { buttonText = "Toggle Log Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
                //new ButtonInfo { buttonText = "Change Esp Type",overlapText = "Change Esp Type: Casual", method =() => Visual.ChangeVisualColor(), isTogglable = false},
            },

             //game
             new ButtonInfo[] { // Game
                new ButtonInfo { buttonText = "-back-", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Menu : Returned Home!"},
                new ButtonInfo { buttonText = "Northstar Nametag", method =() => GameMods.eName(), isTogglable = true, toolTip = "Sets Name To northstar!"},
                new ButtonInfo { buttonText = "Tranq's Nametag", method =() => GameMods.TranqName(), isTogglable = true, toolTip = "Sets Name To RGB arctic!"},
                new ButtonInfo { buttonText = "Blank Nametag", method =() => GameMods.BlankName(), isTogglable = true, toolTip = "Sets Name To RGB arctic!"},
                new ButtonInfo { buttonText = "Activate Turning [J]", method =() => BasicMods.Turn(), toolTip = "Turn!", isTogglable = true},
                new ButtonInfo { buttonText = "Leave", method =() => GameMods.Disconnect(), toolTip = "Loged!", isTogglable = false},
                new ButtonInfo { buttonText = "Join Public", method =() => GameMods.JoinRand(), toolTip = "Loged!", isTogglable = false},
                new ButtonInfo { buttonText = "Join Modding Room", method =() => GameMods.JoinNorthPriv(), toolTip = "Loged!", isTogglable = false},
                new ButtonInfo { buttonText = "Cosemtix", method =() => OP.GiveAllCos(), toolTip = "Cosmetixs fr!", isTogglable = false},
                new ButtonInfo { buttonText = "Give All Watch [SS]", method =() => OP.HuntAll(), toolTip = "Loged!", isTogglable = false},
                new ButtonInfo { buttonText = "Disable Network Triggs [SS]", method =() => OP.SSNoTriggs(), toolTip = "Remove Everyones Network Triggs!", isTogglable = true},
            },

            //basic
             new ButtonInfo[] { // Basic
                new ButtonInfo { buttonText = "-back-", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Menu : Returned Home!"},
                new ButtonInfo { buttonText = "Platforms [G]", method =() => BasicMods.BetterPlatforms("Normal"), isTogglable = true},
                new ButtonInfo { buttonText = "Trigger Platforms [T]", method =() => BasicMods.BetterTPlatforms("Normal"), isTogglable = true},
                new ButtonInfo { buttonText = "Flight [A]", method =() => BasicMods.Flight(), isTogglable = true},
                new ButtonInfo { buttonText = "Trigger Flight [T]", method =() => BasicMods.TFlight(), isTogglable = true},
                new ButtonInfo { buttonText = "Directional Flight [A]", method =() => BasicMods.HandFlight(), isTogglable = true},
                new ButtonInfo { buttonText = "Slingshot [T]", method =() => BasicMods.Slingshot(), isTogglable = true},
                new ButtonInfo { buttonText = "Iron Monk [G]", method =() => BasicMods.IronMonk(), isTogglable = true},
                new ButtonInfo { buttonText = "Teleport Gun [G/T]", method =() => GunMods.TPGun(), toolTip = "A Gun To TP With!", isTogglable = true},
                new ButtonInfo { buttonText = "Boost Rig", method =() => BasicMods.SpeedBoost(), toolTip = "A Speed Boost!", isTogglable = true},
                new ButtonInfo { buttonText = "Break Boost Rig", method =() => BasicMods.SpeedBoost(), toolTip = "A Speed Boost!", isTogglable = true},
                new ButtonInfo { buttonText = "Slow Rig", method =() => BasicMods.SpeedBoost(), toolTip = "A Speed Boost!", isTogglable = true},
                new ButtonInfo { buttonText = "Remove Gravity", method =() => BasicMods.ZeroGravity(),disableMethod =() => BasicMods.FixGravity(), toolTip = "Astronaut!", isTogglable = true},
                new ButtonInfo { buttonText = "Deacrease Gravity", method =() => BasicMods.LowGravity(), disableMethod =() => BasicMods.FixGravity(), toolTip = "The Moon!", isTogglable = true},
                new ButtonInfo { buttonText = "Increases Gravity", method =() => BasicMods.HighGravity(), disableMethod =() => BasicMods.FixGravity(), toolTip = "The Sun!", isTogglable = true},
                new ButtonInfo { buttonText = "Fixed Sliding", method =() => BasicMods.SlideControll(),toolTip = "Controll Over Slideing!", isTogglable = true},
                new ButtonInfo { buttonText = "Teleport To Stump [T]", method =() => BasicMods.TPtoStump(), toolTip = "TP To The Main Stump!", isTogglable = true},
                new ButtonInfo { buttonText = "Phase [T]", method =() => BasicMods.Noclip(), toolTip = "Clip Through Anything!", isTogglable = true},
                new ButtonInfo { buttonText = "Bomb [G/A]", method =() => BasicMods.Bomb(), disableMethod =() => BasicMods.DisableBomb(), toolTip = "A Block Gun!", isTogglable = true},
                new ButtonInfo { buttonText = "Save Point [G/T]", method =() => BasicMods.CheckPoint(), disableMethod =() => BasicMods.DisableCheckPoint(), toolTip = "A Block Gun!", isTogglable = true},
                new ButtonInfo { buttonText = "Wall Assist [G]", method =() => BasicMods.WallAssist(), toolTip = "Wall Assist!", isTogglable = true},
            },

             //player
              new ButtonInfo[] { // player
                new ButtonInfo { buttonText = "-back-", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Menu : Returned Home!"},
                new ButtonInfo { buttonText = "Ghost [B]", method =() => GameMods.GhostMonke(), toolTip = "Become A Ghost!", isTogglable = true},
                new ButtonInfo { buttonText = "Invisibillity [T]", method =() => GameMods.InvisMonke(), toolTip = "Go Invisable!", isTogglable = true},
                new ButtonInfo { buttonText = "Grab Rig [G]", method =() => GameMods.GrabRig(), toolTip = "Go Invisable!", isTogglable = true},
                new ButtonInfo { buttonText = "Apache Monke [T]", method =() => GameMods.Helicopter(), toolTip = "Go Invisable!", isTogglable = true},
                new ButtonInfo { buttonText = "Spaz Rig", method =() => GameMods.Spaz(),disableMethod =() => GameMods.FixHead(), toolTip = "METH!", isTogglable = true},
                new ButtonInfo { buttonText = "Spaz Head", method =() => GameMods.SpinHead(),disableMethod =() => GameMods.FixHead(), toolTip = "METH!", isTogglable = true},
                new ButtonInfo { buttonText = "Customize Arm Length [LT/RT]", method =() => GameMods.GrowArm(), toolTip = "Go Invisable!", isTogglable = true},
                new ButtonInfo { buttonText = "Tag Gun [G/T]", method =() => GunMods.TagGun(), toolTip = "A Gun To Tag Someone!", isTogglable = true},
                new ButtonInfo { buttonText = "Flick Gun [G/T]", method =() => GunMods.FlickGun(), toolTip = "A Gun To Flick Someone!", isTogglable = true},
                new ButtonInfo { buttonText = "Tag Aura", method =() => GameMods.TagAura(),disableMethod =() => GameMods.TagAuraOFF(), toolTip = "Tag People That Are Close To You!", isTogglable = true},
                new ButtonInfo { buttonText = "Smaller Tag Aura", method =() => GameMods.TagAuraS(),disableMethod =() => GameMods.TagAuraOFF(), toolTip = "Tag People That Are Close To You!", isTogglable = true},
                new ButtonInfo { buttonText = "Toggle Tag Aura [B]", method =() => GameMods.TTagAura(),disableMethod =() => GameMods.TagAuraOFF(), toolTip = "Tag People That Are Close To You!", isTogglable = true},
                new ButtonInfo { buttonText = "Smaller Toggle Tag Aura [B]", method =() => GameMods.TTagAuraS(),disableMethod =() => GameMods.TagAuraOFF(), toolTip = "Tag People That Are Close To You!", isTogglable = true},
                new ButtonInfo { buttonText = "Strobe Rig Self", method =() => OP.STROBE(), toolTip = "Go Invisable!", isTogglable = true},
            },

             //world
              new ButtonInfo[] { // World
                 new ButtonInfo { buttonText = "-back-", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Menu : Returned Home!"},
                 new ButtonInfo { buttonText = "Clear Prefabs", method =() => World.ClearSelfPrefabs(), toolTip = "Spawn Cubes!", isTogglable = false},
                 new ButtonInfo { buttonText = "Dupe VRRig [G]", method =() => World.RigSpam(), toolTip = "Shadow Clone Jitshot", isTogglable = true},
                 new ButtonInfo { buttonText = "Cube Spam [G]", method =() => World.CubeSpam(), toolTip = "Spawn Cubes!", isTogglable = true},
                 new ButtonInfo { buttonText = "Cube Shower [G]", method =() => World.CubeShower(), toolTip = "Take A Shower In Cubes!", isTogglable = true},
                 new ButtonInfo { buttonText = "Erupt Cubes [G]", method =() => World.Erupt(), toolTip = "Erupt Cubes!", isTogglable = true},
                 new ButtonInfo { buttonText = "Puke Cubes [G]", method =() => World.Puke(), toolTip = "Puke Cubes!", isTogglable = true},
                 new ButtonInfo { buttonText = "Cum Cubes [G]", method =() => World.Seman(), toolTip = "Cum Cubes!", isTogglable = true},
                 new ButtonInfo { buttonText = "Cum Cubes All [G]", method =() => World.CumAll(), toolTip = "Seman All!", isTogglable = true},
                 new ButtonInfo { buttonText = "Cube Gun [G/T]", method =() => GunMods.CubeGun(), toolTip = "Spawn Cubes With A Gun!", isTogglable = true},
                 new ButtonInfo { buttonText = "Give Cube Shower Gun [G/T]", method =() => GunMods.GiveCubeGun(), toolTip = "Give Cubes Out Of A Gun!", isTogglable = true},
                 new ButtonInfo { buttonText = "Target Spam [G]", method =() => World.TargetSpam(), toolTip = "Spam Targets Out Of Your Hands!", isTogglable = true},
                 new ButtonInfo { buttonText = "Target Spam All [G]", method =() => World.TargetAll(), toolTip = "Cover Everyone With Targets!", isTogglable = true},
                 new ButtonInfo { buttonText = "Target Gun [G/T]", method =() => GunMods.TargetGun(), toolTip = "Spam Targets Out Of A Gun!", isTogglable = true},
                 new ButtonInfo { buttonText = "Give Target Spam Gun [G/T]", method =() => GunMods.GiveTargetGun(), toolTip = "Give Targets Out Of A Gun!", isTogglable = true},
                 new ButtonInfo { buttonText = "Enemy Spam [G]", method =() => World.Cylinder(),toolTip = "Enemy Weapon!", isTogglable = true},
                 new ButtonInfo { buttonText = "Enemy Erupt [G]", method =() => World.CylinderErupt(), toolTip = "Erupt Like A Valocanon With CyCy!", isTogglable = true},
                 new ButtonInfo { buttonText = "Network Player [G]", method =() => World.Cheetah(), toolTip = "Erupt Like A Valocanon With CyCy!", isTogglable = true},
                 new ButtonInfo { buttonText = "Menu Network Player [G]", method =() => World.MenuBall(), toolTip = "Spawn Big RGB Text", isTogglable = true},
                 new ButtonInfo { buttonText = "RGB Network Player [G]", method =() => World.TinyRGB(), toolTip = "Spawn RGB Text", isTogglable = true},
                 new ButtonInfo { buttonText = "Big Network Player [G]", method =() => World.BigRGB(), toolTip = "Spawn Big RGB Text", isTogglable = true},
                 new ButtonInfo { buttonText = "Crazy Network Player [G]", method =() => World.RelRelBigRGB(), toolTip = "Spawn Really Big RGB Text", isTogglable = true},
                 new ButtonInfo { buttonText = "Fire Ball [G]", method =() => World.FireBall(), toolTip = "Spawn Fireball", isTogglable = true},
                 new ButtonInfo { buttonText = "Dirt Sound", method =() => World.dirtspammer(), toolTip = "Dirt!", isTogglable = true},
                 new ButtonInfo { buttonText = "Bark Sound", method =() => World.BarkSpammer(), toolTip = "Bark!", isTogglable = true},
                 new ButtonInfo { buttonText = "Metal Sound", method =() => World.metalSpammer(), toolTip = "Metal!", isTogglable = true},
                 new ButtonInfo { buttonText = "Pillow Sound", method =() => World.pillowSpammer(), toolTip = "Pillow!", isTogglable = true},
                 new ButtonInfo { buttonText = "Glass Sound", method =() => World.GlassSpammer(), toolTip = "Grass!", isTogglable = true},
                 new ButtonInfo { buttonText = "Leaf Sound", method =() => World.LeafSpammer(), toolTip = "Leaf!", isTogglable = true},
                 new ButtonInfo { buttonText = "Low Crystal Sound", method =() => World.lowcrystalSpammer(), toolTip = "Crystal!", isTogglable = true},
                 new ButtonInfo { buttonText = "Wood Sound", method =() => World.Woodspammer(), toolTip = "Wood!", isTogglable = true},
                 new ButtonInfo { buttonText = "High Crystal Sound", method =() => World.EarrapeSpammer(), toolTip = "Earrape!", isTogglable = true},
            },

              //visual
                new ButtonInfo[] { // Visual
                new ButtonInfo { buttonText = "-back-", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Menu : Returned Home!"},
                new ButtonInfo { buttonText = "Tracers", method =() => Visual.Tracers(), isTogglable = true},
                new ButtonInfo { buttonText = "Camera Mod [G]", method =() => Visual.CameraMod(), isTogglable = true},
                new ButtonInfo { buttonText = "Enable Stump Mirror", method =() => Visual.EnabledMirror(), isTogglable = false},
                new ButtonInfo { buttonText = "Disable Stump Mirror", method =() => Visual.DisableMirror(), isTogglable = false},
            },

                  //overpowerd
                new ButtonInfo[] { // power
                new ButtonInfo { buttonText = "-back-", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Menu : Returned Home!"},
                new ButtonInfo { buttonText = "Unban Self", method =() => OP.unbanself(), toolTip = "Cosmetixs fr!", isTogglable = false},
                new ButtonInfo { buttonText = "Slow All", method =() => OP.SlowAll(), toolTip = "Slow Everyone!", isTogglable = true},
                new ButtonInfo { buttonText = "Slow Gun [G/T]", method =() => GunMods.SlowGun(), toolTip = "Vibrate Everyone!", isTogglable = true},
                new ButtonInfo { buttonText = "Vibrate All", method =() => OP.VibrateAll(), toolTip = "Vibrate Everyone!", isTogglable = true},
                new ButtonInfo { buttonText = "Vibrate Gun [G/T]", method =() => GunMods.VibrateGun(), toolTip = "Vibrate Everyone!", isTogglable = true},
                new ButtonInfo { buttonText = "Mat All", method =() => OP.MatAll(), toolTip = "Sussy All FR!", isTogglable = true},
                new ButtonInfo { buttonText = "Round End Spam", method =() => World.endspam(), toolTip = "Round-End!", isTogglable = true},
                new ButtonInfo { buttonText = "Destroy Gun [G/T]", method =() => GunMods.LagGun(), toolTip = "A Gun To Lag Someone!", isTogglable = true},
                new ButtonInfo { buttonText = "Touch To Destroy", method =() => OP.LagWithaHand(), toolTip = "Lag With Your Hands!", isTogglable = true},
                new ButtonInfo { buttonText = "Destroy All [T]", method =() => OP.LagAll(), toolTip = "Lags Everyone!", isTogglable = true},
                new ButtonInfo { buttonText = "Lag Gun [G/T]", method =() => GunMods.CrashGun(), toolTip = "A Gun To Crash Someone!", isTogglable = true},
                new ButtonInfo { buttonText = "Touch To Lag", method =() => OP.CrashWithaHand(), toolTip = "Crash With Your Hands!", isTogglable = true},
                new ButtonInfo { buttonText = "Lag All", method =() => OP.PhotonCrashAll(), toolTip = "Crashes Everyone!", isTogglable = true},
                new ButtonInfo { buttonText = "Enemey Crash All [T/G]", method =() => OP.EnemyCrashAll(), toolTip = "Crashes Everyone!", isTogglable = true},
                new ButtonInfo { buttonText = "Crash All [T]", method =() => OP.instacrashall(), toolTip = "Crashes Everyone!", isTogglable = true},
            },

        };
    }
}
