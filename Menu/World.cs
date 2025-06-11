using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using easyInputs;
using GorillaLocomotion;
using GorillaNetworking;
using Photon.Pun;
using UnityEngine;
using static IIDKQuest.Menu.Main;
using static IIDKQuest.Settings;
namespace IIDKQuest.Menu
{
    internal class World
    {
        public static void EnterWorld()
        {
            buttonsType = 5;
        }

        #region Prefabs
        public static void ClearSelfPrefabs()
        {
            foreach (Photon.Realtime.Player player in PhotonNetwork.PlayerList)
            {
                PhotonNetwork.DestroyPlayerObjects(player);
            }
        }
        public static void Cheetah()
        {
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                Vector3 SP = GorillaLocomotion.Player.Instance.rightHandTransform.transform.position;
                Quaternion SR = GorillaLocomotion.Player.Instance.rightHandTransform.transform.rotation;
                PhotonNetwork.Instantiate("Network Player", SP, SR, 0, null);
            }
        }
        public static void MenuBall()
        {
            string[] array = new string[]
{
      "<size=20.6><color=#ffffff>n</color><color=#e3f1fa>o</color><color=#d4edfc>r</color><color=#c2e7fc>t</color><color=#b3e3ff>h</color><color=#a2dcfc>s</color><color=#92d6fc>t</color><color=#81d0fc>a</color><color=#6fc9fc>r</color></size> <color=#68c7fc>r</color><color=#59c3ff>e</color><color=#4bbbfa>b</color><color=#3cb5fa>o</color><color=#2daef7>r</color><color=#1ba8f7>n</color>\n<size=20.6><color=#75cbfa>v5.0</color> | <color=#68c8fc>discord.gg/2A7JAbN9</color></size>",
};
            int num = new System.Random().Next(array.Length);
            PhotonNetwork.LocalPlayer.NickName = array[num];
            GorillaComputer.instance.currentName = array[num];
            PlayerPrefs.SetString("GorillaLocomotion.PlayerName", array[num]);
            string userId = "NU UH";
            PhotonNetwork.LocalPlayer.UserId = userId;
            PlayerPrefs.Save();
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                Vector3 SP = GorillaLocomotion.Player.Instance.rightHandTransform.transform.position;
                Quaternion SR = GorillaLocomotion.Player.Instance.rightHandTransform.transform.rotation;
                PhotonNetwork.Instantiate("Network Player", SP, SR, 0, null);
            }
        }
        public static void BigRGB()
        {
            string[] array = new string[]
{
      "<size=200.6><color=yellow>000000000000000000000000000000000000</color></size>",
      "<size=200.6><color=green>0000000000000000000000000000000000000000000000000</color></size>",
      "<size=200.6><color=blue>000000000000000000000000000000000000000000000</color></size>",
      "<size=200.6><color=violet>00000000000000000000</color></size>",
      "<size=200.6><color=red>000000000000000000000000000000000000</color></size>",
      "<size=200.6><color=orange>00000000000000000000000000000000000000000000000000000000000000000000000</color></size>",
      "<size=200.6><color=cyan>00000000000000000000000000000</color></size>"
};
            int num = new System.Random().Next(array.Length);
            PhotonNetwork.LocalPlayer.NickName = array[num];
            GorillaComputer.instance.currentName = array[num];
            PlayerPrefs.SetString("GorillaLocomotion.PlayerName", array[num]);
            string userId = "NU UH";
            PhotonNetwork.LocalPlayer.UserId = userId;
            PlayerPrefs.Save();
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                Vector3 SP = GorillaLocomotion.Player.Instance.rightHandTransform.transform.position;
                Quaternion SR = GorillaLocomotion.Player.Instance.rightHandTransform.transform.rotation;
                PhotonNetwork.Instantiate("Network Player", SP, SR, 0, null);
            }
        }
        public static void TinyRGB()
        {
            string[] array = new string[]
{
      "<size=20.6><color=yellow>000000000000000000000000000000000000</color></size>",
      "<size=20.6><color=green>0000000000000000000000000000000000000000000000000</color></size>",
      "<size=20.6><color=blue>000000000000000000000000000000000000000000000</color></size>",
      "<size=20.6><color=violet>00000000000000000000</color></size>",
      "<size=20.6><color=red>000000000000000000000000000000000000</color></size>",
      "<size=20.6><color=orange>00000000000000000000000000000000000000000000000000000000000000000000000</color></size>",
      "<size=20.6><color=cyan>00000000000000000000000000000</color></size>"
};
            int num = new System.Random().Next(array.Length);
            PhotonNetwork.LocalPlayer.NickName = array[num];
            GorillaComputer.instance.currentName = array[num];
            PlayerPrefs.SetString("GorillaLocomotion.PlayerName", array[num]);
            string userId = "NU UH";
            PhotonNetwork.LocalPlayer.UserId = userId;
            PlayerPrefs.Save();
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                Vector3 SP = GorillaLocomotion.Player.Instance.rightHandTransform.transform.position;
                Quaternion SR = GorillaLocomotion.Player.Instance.rightHandTransform.transform.rotation;
                PhotonNetwork.Instantiate("Network Player", SP, SR, 0, null);
            }
        }
        public static void RelBigRGB()
        {
            string[] array = new string[]
{
      "<size=300.6><color=yellow>000000000000000000000000000000000000</color></size>",
      "<size=300.6><color=green>0000000000000000000000000000000000000000000000000</color></size>",
      "<size=300.6><color=blue>000000000000000000000000000000000000000000000</color></size>",
      "<size=300.6><color=violet>00000000000000000000</color></size>",
      "<size=300.6><color=red>000000000000000000000000000000000000</color></size>",
      "<size=300.6><color=orange>00000000000000000000000000000000000000000000000000000000000000000000000</color></size>",
      "<size=300.6><color=cyan>00000000000000000000000000000</color></size>"
};
            int num = new System.Random().Next(array.Length);
            PhotonNetwork.LocalPlayer.NickName = array[num];
            GorillaComputer.instance.currentName = array[num];
            PlayerPrefs.SetString("GorillaLocomotion.PlayerName", array[num]);
            string userId = "NU UH";
            PhotonNetwork.LocalPlayer.UserId = userId;
            PlayerPrefs.Save();
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                Vector3 SP = GorillaLocomotion.Player.Instance.rightHandTransform.transform.position;
                Quaternion SR = GorillaLocomotion.Player.Instance.rightHandTransform.transform.rotation;
                PhotonNetwork.Instantiate("Network Player", SP, SR, 0, null);
            }
        }
        public static void RelRelBigRGB()
        {
            string[] array = new string[]
{
      "<size=5000><color=yellow>000000000000000000000000000000000000</color></size>",
      "<size=5000><color=green>0000000000000000000000000000000000000000000000000</color></size>",
      "<size=5000><color=blue>000000000000000000000000000000000000000000000</color></size>",
      "<size=5000><color=violet>00000000000000000000</color></size>",
      "<size=5000><color=red>000000000000000000000000000000000000</color></size>",
      "<size=5000><color=orange>00000000000000000000000000000000000000000000000000000000000000000000000</color></size>",
      "<size=5000><color=cyan>00000000000000000000000000000</color></size>"
};
            int num = new System.Random().Next(array.Length);
            PhotonNetwork.LocalPlayer.NickName = array[num];
            GorillaComputer.instance.currentName = array[num];
            PlayerPrefs.SetString("GorillaLocomotion.PlayerName", array[num]);
            string userId = "00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            PhotonNetwork.LocalPlayer.UserId = userId;
            PlayerPrefs.Save();
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                Vector3 SP = GorillaLocomotion.Player.Instance.rightHandTransform.transform.position;
                Quaternion SR = GorillaLocomotion.Player.Instance.rightHandTransform.transform.rotation;
                PhotonNetwork.Instantiate("Network Player", SP, SR, 0, null);
            }
        }
        public static void CubeSpam()
        {
            {
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.rightHandTransform.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.rightHandTransform.transform.rotation;
                    PhotonNetwork.Instantiate("bulletPrefab", SP, SR, 0, null);
                }

                if (EasyInputs.GetGripButtonDown(EasyHand.LeftHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.leftHandTransform.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.leftHandTransform.transform.rotation;
                    PhotonNetwork.Instantiate("bulletPrefab", SP, SR, 0, null);
                }
            }
        }

        public static void Erupt()
        {
            {

                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.bodyCollider.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.bodyCollider.transform.rotation;
                    PhotonNetwork.Instantiate("bulletPrefab", SP, SR, 0, null);
                }

                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.bodyCollider.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.bodyCollider.transform.rotation;
                    PhotonNetwork.Instantiate("bulletPrefab", SP, SR, 1, null);
                }
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.bodyCollider.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.bodyCollider.transform.rotation;
                    PhotonNetwork.Instantiate("bulletPrefab", SP, SR, 2, null);
                }
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.bodyCollider.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.bodyCollider.transform.rotation;
                    PhotonNetwork.Instantiate("bulletPrefab", SP, SR, 3, null);
                }
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.bodyCollider.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.bodyCollider.transform.rotation;
                    PhotonNetwork.Instantiate("bulletPrefab", SP, SR, 4, null);
                }
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.bodyCollider.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.bodyCollider.transform.rotation;
                    PhotonNetwork.Instantiate("bulletPrefab", SP, SR, 5, null);
                }
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.bodyCollider.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.bodyCollider.transform.rotation;
                    PhotonNetwork.Instantiate("bulletPrefab", SP, SR, 6, null);
                }
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.bodyCollider.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.bodyCollider.transform.rotation;
                    PhotonNetwork.Instantiate("bulletPrefab", SP, SR, 7, null);
                }
            }
        }
        public static void Seman()
        {
            {
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.bodyCollider.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.bodyCollider.transform.rotation;
                    PhotonNetwork.Instantiate("bulletPrefab", SP, SR, 9, null);
                }
            }
        }
        public static void Puke()
        {
            {
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.headCollider.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.headCollider.transform.rotation;
                    PhotonNetwork.Instantiate("bulletPrefab", SP, SR, 9, null);
                }
            }
        }
        public static void CubeShower()
        {
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                Vector3 vector = GorillaTagger.Instance.myVRRig.transform.position + new Vector3(0f, 4f, 0f) + GorillaTagger.Instance.myVRRig.transform.forward.normalized * 0.1f;
                Quaternion quaternion = GorillaTagger.Instance.myVRRig.transform.rotation * Quaternion.Euler(0f, 90f, 0f);
                PhotonNetwork.Instantiate("bulletPrefab", vector, quaternion, 0, null);
            }
        }
        public static void Cylinder()
        {
            {
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.headCollider.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.headCollider.transform.rotation;
                    PhotonNetwork.Instantiate("gorillaprefabs/gorillaenemy", SP, SR, 9, null);
                }
            }
        }
        public static void CylinderErupt()
        {
            {

                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.bodyCollider.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.bodyCollider.transform.rotation;
                    PhotonNetwork.Instantiate("gorillaprefabs/gorillaenemy", SP, SR, 0, null);
                }

                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.bodyCollider.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.bodyCollider.transform.rotation;
                    PhotonNetwork.Instantiate("gorillaprefabs/gorillaenemy", SP, SR, 1, null);
                }
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.bodyCollider.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.bodyCollider.transform.rotation;
                    PhotonNetwork.Instantiate("gorillaprefabs/gorillaenemy", SP, SR, 2, null);
                }
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.bodyCollider.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.bodyCollider.transform.rotation;
                    PhotonNetwork.Instantiate("gorillaprefabs/gorillaenemy", SP, SR, 3, null);
                }
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.bodyCollider.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.bodyCollider.transform.rotation;
                    PhotonNetwork.Instantiate("gorillaprefabs/gorillaenemy", SP, SR, 4, null);
                }
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.bodyCollider.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.bodyCollider.transform.rotation;
                    PhotonNetwork.Instantiate("gorillaprefabs/gorillaenemy", SP, SR, 5, null);
                }
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.bodyCollider.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.bodyCollider.transform.rotation;
                    PhotonNetwork.Instantiate("gorillaprefabs/gorillaenemy", SP, SR, 6, null);
                }
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.bodyCollider.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.bodyCollider.transform.rotation;
                    PhotonNetwork.Instantiate("gorillaprefabs/gorillaenemy", SP, SR, 7, null);
                }
            }
        }
        public static void CumAll()
        {
            {
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    foreach (VRRig vrrig2 in GorillaParent.instance.vrrigs)
                    {
                        {
                            Vector3 vector = vrrig2.transform.position + new Vector3(0f, 1.3f, 0f) + vrrig2.transform.forward.normalized * 0.1f;
                            Quaternion quaternion = vrrig2.transform.rotation * Quaternion.Euler(0f, 90f, 0f);
                            PhotonNetwork.Instantiate("bulletPrefab", vector, quaternion, 0, null);
                        }
                    }
                }
            }
        }
        public static void TargetAll()
        {
            {
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    foreach (VRRig vrrig2 in GorillaParent.instance.vrrigs)
                    {
                        {
                            Vector3 vector = vrrig2.transform.position + new Vector3(0f, 1.3f, 0f) + vrrig2.transform.forward.normalized * 0.1f;
                            Quaternion quaternion = vrrig2.transform.rotation * Quaternion.Euler(0f, 90f, 0f);
                            PhotonNetwork.Instantiate("STICKABLE TARGET", vector, quaternion, 0, null);
                        }
                    }
                }
            }
        }
        public static void TargetSpam()
        {
            {
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.rightHandTransform.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.rightHandTransform.transform.rotation;
                    PhotonNetwork.Instantiate("STICKABLE TARGET", SP, SR, 0, null);
                }

                if (EasyInputs.GetGripButtonDown(EasyHand.LeftHand))
                {
                    Vector3 SP = GorillaLocomotion.Player.Instance.leftHandTransform.transform.position;
                    Quaternion SR = GorillaLocomotion.Player.Instance.leftHandTransform.transform.rotation;
                    PhotonNetwork.Instantiate("STICKABLE TARGET", SP, SR, 0, null);
                }
            }
        }
        public static void ClearObjects()
        {
            PhotonNetwork.DestroyAll();
        }
        public static void FireBall()
        {
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                Vector3 position4 = GorillaLocomotion.Player.Instance.rightHandTransform.transform.position;
                Quaternion rotation4 = GorillaLocomotion.Player.Instance.rightHandTransform.transform.rotation;
                PhotonNetwork.Instantiate("gorillaprefabs/gorillafireball", position4, rotation4, 0, null);
            }
        }
        public static void HuntAll()
        {
            {
                Vector3 objectpostion = GorillaLocomotion.Player.Instance.rightHandTransform.transform.position;
                Quaternion SR = GorillaLocomotion.Player.Instance.rightHandTransform.transform.rotation;
                PhotonNetwork.Instantiate("gorillaprefabs/gorillahuntmanager", objectpostion, SR, 0, null);
            }
        }
        public static void RigSpam()
        {
            {
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    UnityEngine.Object.Destroy(GorillaTagger.Instance.myVRRig);
                    PhotonNetwork.Instantiate("PhotonVR/Player", GorillaLocomotion.Player.Instance.transform.position + new Vector3(0f, 0.4f, 0f), GorillaLocomotion.Player.Instance.transform.rotation, 90, null);
                    PhotonNetwork.Instantiate("PhotonVR/Player", GorillaLocomotion.Player.Instance.transform.position + new Vector3(0f, 0.4f, 0f), GorillaLocomotion.Player.Instance.transform.rotation, 0, null);
                }
            }
        }
        #endregion

        #region Sound
        public static void dirtspammer()
        {
            {
                PlaySound(39, 0f, 0f, 99999999999999999999999999999999999999f);
            }
        }
        public static void GlassSpammer()
        {
            {
                PlaySound(29, 0f, 0f, 99999999999999999999999999999999999999f);
            }
        }
        public static void GrassSpammer()
        {
            {
                PlaySound(7, 0f, 0f, 99999999999999999999999999999999999999f);
            }
        }


        public static void LeafSpammer()
        {
            {
                PlaySound(31, 0f, 0f, 99999999999999999999999999999999999999f);
            }
        }
        public static void RockSpammer()
        {
            {
                PlaySound(1, 0f, 0f, 99999999999999999999999999999999999999f);
            }
        }
        public static void metalSpammer()
        {
            {
                PlaySound(18, 0f, 0f, 99999999999999999999999999999999999999f);
            }
        }
        public static void pillowSpammer()
        {
            {
                PlaySound(3, 0f, 0f, 99999999999999999999999999999999999999f);
            }
        }
        public static void EarrapeSpammer()
        {
            {
                PlaySound(54, 0f, 0f, 99999999999999999999999999999999999999f);
            }
        }
        public static void lowcrystalSpammer()
        {
            {
                PlaySound(49, 0f, 0f, 99999999999999999999999999999999999999f);
            }
        }
        public static void Woodspammer()
        {
            {
                PlaySound(9, 0f, 0f, 99999999999999999999999999999999999999f);
            }
        }
        public static void BarkSpammer()
        {
            {
                PlaySound(8, 0f, 0f, 99999999999999999999999999999999999999f);
            }
        }
        public static void buttonspam()
        {
            {
                PlaySound(53, 0f, 0f, 99999999999999999999999999999999999999f);
            }
        }
        public static void endspam()
        {
            {
                foreach (GorillaTagManager GTM in UnityEngine.Object.FindObjectsOfType<GorillaTagManager>())
                {
                    GTM.EndInfectionGame();
                }
            }
        }
        public static void PlaySound(int SoundID, float tapcooldown, float Dalay, float volume)
        {
            GorillaTagger.Instance.leftHandTouching = true;
            bool inRoom = PhotonNetwork.InRoom;
            if (inRoom)
            {
                GorillaGameManager.instance.stepVolumeMax = 999999f;
            }
            Player.Instance.wasLeftHandTouching = true;
            Player.Instance.IsHandTouching(true);
            GorillaTagger.Instance.leftHandTouching = false;
            GorillaTagger.Instance.tapCoolDown = Dalay;
            GorillaTagger.Instance.handTapVolume = volume;
            GorillaTagger.Instance.lastLeftTap = tapcooldown;
            Player.Instance.inOverlay = false;
            foreach (GorillaSurfaceOverride gorillaSurfaceOverride in UnityEngine.Object.FindObjectsOfType<GorillaSurfaceOverride>())
            {
                gorillaSurfaceOverride.overrideIndex = SoundID;
                Player.Instance.leftHandMaterialTouchIndex = gorillaSurfaceOverride.overrideIndex;
                Player.Instance.leftHandSurfaceOverride = gorillaSurfaceOverride;
            }
        }
        #endregion
    }
}
