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
using static StupidTemplate.Classes.ColorLib;

namespace IIDKQuest.Menu
{
    internal class GameMods
    {
        public static void EnterGame()
        {
            buttonsType = 2;
        }
        public static void EnterPlayer()
        {
            buttonsType = 4;
        }

        #region player
        public static void GrowArm()
        {
            if (GetIndex("Lock Arm Size").enabled == true)
            {
                if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                {
                    Player.Instance.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
                    Player.Instance.maxArmLength = 100000f;
                }
                if (EasyInputs.GetTriggerButtonDown(EasyHand.LeftHand))
                {
                    Player.Instance.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
                    Player.Instance.maxArmLength = 100000f;
                }
            }
            if (GetIndex("Lock Arm Size").enabled == false)
            {
                if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                {
                    Player.Instance.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
                    Player.Instance.maxArmLength = 100000f;
                }
                if (EasyInputs.GetTriggerButtonDown(EasyHand.LeftHand))
                {
                    Player.Instance.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
                    Player.Instance.maxArmLength = 100000f;
                }
                if (EasyInputs.GetSecondaryButtonDown(EasyHand.LeftHand))
                {
                    Player.Instance.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
                    Player.Instance.maxArmLength = 100000f;
                }
            }
        }
        public static void GhostMonke()
        {
            
                if (EasyInputs.GetSecondaryButtonDown(EasyHand.RightHand))
                {
                    GorillaTagger.Instance.myVRRig.enabled = false;
                    if (GetIndex("Visualize Disabled Rig").enabled == true)
                    {
                        GameObject l = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                        UnityEngine.Object.Destroy(l.GetComponent<Rigidbody>());
                        UnityEngine.Object.Destroy(l.GetComponent<SphereCollider>());

                        l.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                        l.transform.position = GorillaTagger.Instance.leftHandTransform.position;

                        GameObject r = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                        UnityEngine.Object.Destroy(r.GetComponent<Rigidbody>());
                        UnityEngine.Object.Destroy(r.GetComponent<SphereCollider>());


                        r.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                        r.transform.position = GorillaTagger.Instance.rightHandTransform.position;

                        l.GetComponent<Renderer>().material.color = backgroundColor.colors[0].color;
                        r.GetComponent<Renderer>().material.color = backgroundColor.colors[0].color;

                        UnityEngine.Object.Destroy(l, Time.deltaTime);
                        UnityEngine.Object.Destroy(r, Time.deltaTime);
                        return;
                    }
                    if (GetIndex("Visualize Disabled Rig").enabled == false)
                    {
   
                    }
                }
                else
                {
                    GorillaTagger.Instance.myVRRig.enabled = true;
                }
            
        }
        public static void InvisMonke()
        {
            
                if (EasyInputs.GetTriggerButtonDown(EasyHand.LeftHand))
                {
                    if (GetIndex("Visualize Disabled Rig").enabled == true)
                    {
                        GameObject l = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                        UnityEngine.Object.Destroy(l.GetComponent<Rigidbody>());
                        UnityEngine.Object.Destroy(l.GetComponent<SphereCollider>());

                        l.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                        l.transform.position = GorillaTagger.Instance.leftHandTransform.position;

                        GameObject r = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                        UnityEngine.Object.Destroy(r.GetComponent<Rigidbody>());
                        UnityEngine.Object.Destroy(r.GetComponent<SphereCollider>());


                        r.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                        r.transform.position = GorillaTagger.Instance.rightHandTransform.position;

                        l.GetComponent<Renderer>().material.color = backgroundColor.colors[0].color;
                        r.GetComponent<Renderer>().material.color = backgroundColor.colors[0].color;

                        UnityEngine.Object.Destroy(l, Time.deltaTime);
                        UnityEngine.Object.Destroy(r, Time.deltaTime);
                        return;
                    }
                    if (GetIndex("Visualize Disabled Rig").enabled == false)
                    {
         
                    }
                GorillaTagger.Instance.offlineVRRig.transform.position = new Vector3(100f, 100f, 100f);
                GorillaTagger.Instance.offlineVRRig.enabled = false;
            }
                else
                {
                    GorillaTagger.Instance.myVRRig.enabled = true;
                }
            
        }
        public static void GrabRig()
        {
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GorillaTagger.Instance.myVRRig.enabled = false;

                GorillaTagger.Instance.myVRRig.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                GorillaTagger.Instance.myVRRig.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
                {
                    GorillaTagger.Instance.offlineVRRig.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                    GorillaTagger.Instance.offlineVRRig.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
                }

                GorillaTagger.Instance.offlineVRRig.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                GorillaTagger.Instance.offlineVRRig.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
                try
                {
                    GorillaTagger.Instance.myVRRig.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                    GorillaTagger.Instance.myVRRig.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
                }

                catch { }

                if (GetIndex("Visualize Disabled Rig").enabled == true)
                {
                    GameObject l = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    UnityEngine.Object.Destroy(l.GetComponent<Rigidbody>());
                    UnityEngine.Object.Destroy(l.GetComponent<SphereCollider>());

                    l.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    l.transform.position = GorillaTagger.Instance.leftHandTransform.position;

                    GameObject r = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    UnityEngine.Object.Destroy(r.GetComponent<Rigidbody>());
                    UnityEngine.Object.Destroy(r.GetComponent<SphereCollider>());


                    r.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    r.transform.position = GorillaTagger.Instance.rightHandTransform.position;

                    l.GetComponent<Renderer>().material.color = backgroundColor.colors[0].color;
                    r.GetComponent<Renderer>().material.color = backgroundColor.colors[0].color;

                    UnityEngine.Object.Destroy(l, Time.deltaTime);
                    UnityEngine.Object.Destroy(r, Time.deltaTime);
                    return;
                }
                if (GetIndex("Visualize Disabled Rig").enabled == false)
                {

                }
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
                GorillaTagger.Instance.myVRRig.enabled = true;
            }
        }
        public static void Helicopter()
        {
            if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.transform.position += new Vector3(0f, 0.075f, 0f);
                GorillaTagger.Instance.offlineVRRig.transform.rotation = Quaternion.Euler(GorillaTagger.Instance.offlineVRRig.transform.rotation.eulerAngles + new Vector3(0f, 10f, 0f));
                GorillaTagger.Instance.myVRRig.head.rigTarget.transform.rotation = GorillaTagger.Instance.offlineVRRig.transform.rotation;
                GorillaTagger.Instance.myVRRig.enabled = false;
                GorillaTagger.Instance.myVRRig.transform.position += new Vector3(0f, 0.075f, 0f);
                GorillaTagger.Instance.myVRRig.transform.rotation = Quaternion.Euler(GorillaTagger.Instance.offlineVRRig.transform.rotation.eulerAngles + new Vector3(0f, 10f, 0f));
                GorillaTagger.Instance.myVRRig.head.rigTarget.transform.rotation = GorillaTagger.Instance.offlineVRRig.transform.rotation;
                if (GetIndex("Visualize Disabled Rig").enabled == true)
                {
                    GameObject l = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    UnityEngine.Object.Destroy(l.GetComponent<Rigidbody>());
                    UnityEngine.Object.Destroy(l.GetComponent<SphereCollider>());

                    l.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    l.transform.position = GorillaTagger.Instance.leftHandTransform.position;

                    GameObject r = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    UnityEngine.Object.Destroy(r.GetComponent<Rigidbody>());
                    UnityEngine.Object.Destroy(r.GetComponent<SphereCollider>());


                    r.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    r.transform.position = GorillaTagger.Instance.rightHandTransform.position;

                    l.GetComponent<Renderer>().material.color = backgroundColor.colors[0].color;
                    r.GetComponent<Renderer>().material.color = backgroundColor.colors[0].color;

                    UnityEngine.Object.Destroy(l, Time.deltaTime);
                    UnityEngine.Object.Destroy(r, Time.deltaTime);
                    return;
                }
                if (GetIndex("Visualize Disabled Rig").enabled == false)
                {

                }
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
                GorillaTagger.Instance.myVRRig.enabled = true;
            }
        }
        public static void SpinHead()
        {
            GorillaTagger.Instance.myVRRig.head.trackingRotationOffset = GorillaTagger.Instance.myVRRig.head.trackingRotationOffset + new Vector3(15f, 15f, 15f);
        }
        public static void FixHead()
        {
            GorillaTagger.Instance.myVRRig.head.trackingRotationOffset = new Vector3(0f, 0f, 0f);
            GorillaTagger.Instance.offlineVRRig.enabled = true;
            GorillaTagger.Instance.myVRRig.enabled = true;
        }
        public static void Spaz()
        {
            {
                GorillaTagger.Instance.myVRRig.head.trackingRotationOffset = GorillaTagger.Instance.myVRRig.head.trackingRotationOffset + new Vector3(15f, 15f, 15f);
                GorillaTagger.Instance.myVRRig.head.rigTarget.eulerAngles = new Vector3((float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 360));
                GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 180), (float)UnityEngine.Random.Range(0, 180));
            }
        }
        #endregion

        #region game
        public static void eName()
        {
            string[] array = new string[]
{
           "<size=20.6><color=#ffffff>n</color><color=#e3f1fa>o</color><color=#d4edfc>r</color><color=#c2e7fc>t</color><color=#b3e3ff>h</color><color=#a2dcfc>s</color><color=#92d6fc>t</color><color=#81d0fc>a</color><color=#6fc9fc>r</color></size> <color=#68c7fc>r</color><color=#59c3ff>e</color><color=#4bbbfa>b</color><color=#3cb5fa>o</color><color=#2daef7>r</color><color=#1ba8f7>n</color>\n<size=20.6><color=#75cbfa>v5.0</color> | <color=#68c8fc>discord.gg/2A7JAbN9</color></size>",
};
            int num = new System.Random().Next(array.Length);
            PhotonNetwork.LocalPlayer.NickName = array[num];
            GorillaComputer.instance.currentName = array[num];
            PlayerPrefs.SetString("GorillaLocomotion.PlayerName", array[num]);
            string userId = "Get Freaked by <color=#ffffff>n</color><color=#e3f1fa>o</color><color=#d4edfc>r</color><color=#c2e7fc>t</color><color=#b3e3ff>h</color><color=#a2dcfc>s</color><color=#92d6fc>t</color><color=#81d0fc>a</color><color=#6fc9fc>r</color>";
            PhotonNetwork.LocalPlayer.UserId = userId;
            PlayerPrefs.Save();
        }
        public static void TranqName()
        {
            string[] array = new string[]
{
           "<size=20.6><color=green>Tranq</color></size>\n<size=20.6><color=green>Nu Uh</color></size>",
};
            int num = new System.Random().Next(array.Length);
            PhotonNetwork.LocalPlayer.NickName = array[num];
            GorillaComputer.instance.currentName = array[num];
            PlayerPrefs.SetString("GorillaLocomotion.PlayerName", array[num]);
            string userId = "Hi my names tranq :)";
            PhotonNetwork.LocalPlayer.UserId = userId;
            PlayerPrefs.Save();
        }
        public static void BlankName()
        {
            string[] array = new string[]
{
           "<size=100.6><color=white> </color></size>\n<size=100.6><color=white> </color></size>",
};
            int num = new System.Random().Next(array.Length);
            PhotonNetwork.LocalPlayer.NickName = array[num];
            GorillaComputer.instance.currentName = array[num];
            PlayerPrefs.SetString("GorillaLocomotion.PlayerName", array[num]);
            string userId = "I have no id :(";
            PhotonNetwork.LocalPlayer.UserId = userId;
            PlayerPrefs.Save();
        }
        public static void Disconnect()
        {
            PhotonNetwork.Disconnect();
        }
        public static void JoinRand()
        {
            PhotonNetwork.JoinRandomRoom();
        }
        public static void JoinNorthPriv()
        {
            GorillaNetworking.GorillaComputer.instance.roomToJoin = "<color=#68c8fc>northstar</color>";
        }
        public static void TagAura()
        {
            {
                GorillaTagger.Instance.sphereCastRadius = 4;
            }
        }
        public static void TagAuraS()
        {
            {
                GorillaTagger.Instance.sphereCastRadius = 2;
            }
        }
        public static void TTagAura()
        {
            if (EasyInputs.GetSecondaryButtonDown(EasyHand.RightHand))
            {
                GorillaTagger.Instance.sphereCastRadius = 4;
            }
        }
        public static void TTagAuraS()
        {
            if (EasyInputs.GetSecondaryButtonDown(EasyHand.RightHand))
            {
                GorillaTagger.Instance.sphereCastRadius = 2;
            }
        }
        public static void TagAuraOFF()
        {
            {
                GorillaTagger.Instance.sphereCastRadius = 0;
            }
        }
        #endregion
    }
}
