using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using easyInputs;
using Photon.Pun;
using UnityEngine;
using static IIDKQuest.Menu.Main;
using static IIDKQuest.Settings;
using static StupidTemplate.Classes.ColorLib;
using static IIDKQuest.Mods.SettingsMods;

namespace IIDKQuest.Mods
{
    internal class BasicMods
    {
        public static GameObject BombObject = null;
        public static GameObject PointObject = null;
        public static void EnterBasic()
        {
            buttonsType = 3;
        }

        #region Bools
        public static GameObject BetterplatformR = null;
        public static GameObject BetterplatformL = null;
        public static bool BetterplatformLSpawned = false;
        public static bool BetterplatformRSpawned = false;
        #endregion

        #region SetMaster
        public static void SetMaster()
        {
            {
                GorillaGameManager.instance.currentMasterClient = PhotonNetwork.LocalPlayer;
                GorillaGameManager.instance.takeMaster = true;
                PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
            }
            if (!PhotonNetwork.InLobby)
            {
                if (!PhotonNetwork.LocalPlayer.IsMasterClient)
                {
                    GorillaGameManager.instance.currentMasterClient = PhotonNetwork.LocalPlayer;
                    GorillaGameManager.instance.takeMaster = true;
                    PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
                }
                if (!PhotonNetwork.LocalPlayer.IsMasterClient)
                {
                    GorillaGameManager.instance.currentMasterClient = PhotonNetwork.LocalPlayer;
                    GorillaGameManager.instance.takeMaster = true;
                    PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
                }
                {
                    GorillaGameManager.instance.currentMasterClient = PhotonNetwork.LocalPlayer;
                    GorillaGameManager.instance.takeMaster = true;
                    PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
                }
            }
            {
                {
                    GorillaGameManager.instance.currentMasterClient = PhotonNetwork.LocalPlayer;
                    GorillaGameManager.instance.takeMaster = true;
                    PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
                }
            }
            if (!PhotonNetwork.LocalPlayer.IsMasterClient)
            {
                GorillaGameManager.instance.currentMasterClient = PhotonNetwork.LocalPlayer;
                GorillaGameManager.instance.takeMaster = true;
                PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
            }
            {
                GorillaGameManager.instance.currentMasterClient = PhotonNetwork.LocalPlayer;
                GorillaGameManager.instance.takeMaster = true;
                PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
            }
        }
        #endregion

        #region Platforms
        public static void DrawPlatL()
        {
            Color[] colors = new Color[]
                        {
              backgroundColor.colors[0].color,
            pointerColor.colors[0].color
        };


            float duration = 3.0f;
            float t = (Time.time % duration) / duration;
            int fromIndex = (int)(t * (colors.Length - 1));
            int toIndex = (fromIndex + 1) % colors.Length;
            float lerpT = (t * (colors.Length - 1)) % 1.0f;

            Color lerpedColor = Color.Lerp(colors[fromIndex], colors[toIndex], lerpT);
            BetterplatformL = GameObject.CreatePrimitive(PrimitiveType.Cube);
            UnityEngine.Object.Destroy(BetterplatformL.GetComponent<Rigidbody>());
            UnityEngine.Object.Destroy(BetterplatformL.GetComponent<BoxCollider>());
            UnityEngine.Object.Destroy(BetterplatformL.GetComponent<Renderer>());
            BetterplatformL.transform.localScale = new Vector3(0.30f, 0.3f, 0.30f);
            GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
            UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
            //UnityEngine.Object.Destroy(gameObject.GetComponent<BoxCollider>());
            gameObject.transform.parent = BetterplatformL.transform;
            gameObject.transform.rotation = Quaternion.identity;
            gameObject.transform.localScale = new Vector3(0.1f, 1f, 1f);
            gameObject.GetComponent<Renderer>().material.color = lerpedColor;
            gameObject.transform.position = new Vector3(0.02f, 0f, 0f);
        }
        public static void BetterPlatforms(string type)
        {
            if (type == "Normal")
            {
                if (EasyInputs.GetGripButtonDown(EasyHand.LeftHand) && BetterplatformL == null)
                { DrawPlatL(); }
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand) && BetterplatformR == null)
                { DrawPlatR(); }
                if (EasyInputs.GetGripButtonDown(EasyHand.LeftHand) && BetterplatformL != null && !BetterplatformLSpawned)
                {
                    BetterplatformL.transform.position = GorillaLocomotion.Player.Instance.leftHandTransform.position;
                    BetterplatformL.transform.rotation = GorillaLocomotion.Player.Instance.leftHandTransform.rotation;

                    BetterplatformLSpawned = true;
                }
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand) && BetterplatformR != null && !BetterplatformRSpawned)
                {
                    BetterplatformR.transform.position = GorillaLocomotion.Player.Instance.rightHandTransform.position;
                    BetterplatformR.transform.rotation = GorillaLocomotion.Player.Instance.rightHandTransform.rotation;

                    BetterplatformRSpawned = true;
                }
                if (!EasyInputs.GetGripButtonDown(EasyHand.LeftHand) && BetterplatformL != null)
                {
                    BetterplatformL.AddComponent<Rigidbody>();
                    UnityEngine.Object.Destroy(BetterplatformL, 3f);
                    BetterplatformL = null;
                    BetterplatformLSpawned = false;

                }
                if (!EasyInputs.GetGripButtonDown(EasyHand.RightHand) && BetterplatformR != null)
                {
                    BetterplatformR.AddComponent<Rigidbody>();
                    UnityEngine.Object.Destroy(BetterplatformR, 3f);
                    BetterplatformR = null;
                    BetterplatformRSpawned = false;

                }
            }
        }
        public static void DrawPlatR()
        {
            Color[] colors = new Color[]
                       {
           backgroundColor.colors[0].color,
            pointerColor.colors[0].color
                       };


            float duration = 3.0f;
            float t = (Time.time % duration) / duration;
            int fromIndex = (int)(t * (colors.Length - 1));
            int toIndex = (fromIndex + 1) % colors.Length;
            float lerpT = (t * (colors.Length - 1)) % 1.0f;

            Color lerpedColor = Color.Lerp(colors[fromIndex], colors[toIndex], lerpT);
            BetterplatformR = GameObject.CreatePrimitive(PrimitiveType.Cube);
            UnityEngine.Object.Destroy(BetterplatformR.GetComponent<Rigidbody>());
            UnityEngine.Object.Destroy(BetterplatformR.GetComponent<BoxCollider>());
            UnityEngine.Object.Destroy(BetterplatformR.GetComponent<Renderer>());
            BetterplatformR.transform.localScale = new Vector3(0.27f, 0.3f, 0.27f);
            GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
            UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
            //UnityEngine.Object.Destroy(gameObject.GetComponent<BoxCollider>());
            gameObject.transform.parent = BetterplatformR.transform;
            gameObject.transform.rotation = Quaternion.identity;
            gameObject.transform.localScale = new Vector3(0.1f, 1f, 1f);
            gameObject.GetComponent<Renderer>().material.color = lerpedColor;
            gameObject.transform.position = new Vector3(-0.02f, 0f, 0f);
        }


        
        public static void DrawTPlatL()
        {
            Color[] colors = new Color[]
                        {
              backgroundColor.colors[0].color,
            pointerColor.colors[0].color
        };


            float duration = 3.0f;
            float t = (Time.time % duration) / duration;
            int fromIndex = (int)(t * (colors.Length - 1));
            int toIndex = (fromIndex + 1) % colors.Length;
            float lerpT = (t * (colors.Length - 1)) % 1.0f;

            Color lerpedColor = Color.Lerp(colors[fromIndex], colors[toIndex], lerpT);
            BetterplatformL = GameObject.CreatePrimitive(PrimitiveType.Cube);
            UnityEngine.Object.Destroy(BetterplatformL.GetComponent<Rigidbody>());
            UnityEngine.Object.Destroy(BetterplatformL.GetComponent<BoxCollider>());
            UnityEngine.Object.Destroy(BetterplatformL.GetComponent<Renderer>());
            BetterplatformL.transform.localScale = new Vector3(0.30f, 0.3f, 0.30f);
            GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
            UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
            //UnityEngine.Object.Destroy(gameObject.GetComponent<BoxCollider>());
            gameObject.transform.parent = BetterplatformL.transform;
            gameObject.transform.rotation = Quaternion.identity;
            gameObject.transform.localScale = new Vector3(0.1f, 1f, 1f);
            gameObject.GetComponent<Renderer>().material.color = lerpedColor;
            gameObject.transform.position = new Vector3(0.02f, 0f, 0f);
        }
        public static void BetterTPlatforms(string type)
        {
            if (type == "Normal")
            {
                if (EasyInputs.GetTriggerButtonDown(EasyHand.LeftHand) && BetterplatformL == null)
                { DrawTPlatL(); }
                if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand) && BetterplatformR == null)
                { DrawTPlatR(); }
                if (EasyInputs.GetTriggerButtonDown(EasyHand.LeftHand) && BetterplatformL != null && !BetterplatformLSpawned)
                {
                    BetterplatformL.transform.position = GorillaLocomotion.Player.Instance.leftHandTransform.position;
                    BetterplatformL.transform.rotation = GorillaLocomotion.Player.Instance.leftHandTransform.rotation;

                    BetterplatformLSpawned = true;
                }
                if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand) && BetterplatformR != null && !BetterplatformRSpawned)
                {
                    BetterplatformR.transform.position = GorillaLocomotion.Player.Instance.rightHandTransform.position;
                    BetterplatformR.transform.rotation = GorillaLocomotion.Player.Instance.rightHandTransform.rotation;

                    BetterplatformRSpawned = true;
                }
                if (!EasyInputs.GetTriggerButtonDown(EasyHand.LeftHand) && BetterplatformL != null)
                {
                    BetterplatformL.AddComponent<Rigidbody>();
                    UnityEngine.Object.Destroy(BetterplatformL, 3f);
                    BetterplatformL = null;
                    BetterplatformLSpawned = false;

                }
                if (!EasyInputs.GetTriggerButtonDown(EasyHand.RightHand) && BetterplatformR != null)
                {
                    BetterplatformR.AddComponent<Rigidbody>();
                    UnityEngine.Object.Destroy(BetterplatformR, 3f);
                    BetterplatformR = null;
                    BetterplatformRSpawned = false;

                }
            }
        }
        public static void DrawTPlatR()
        {
            Color[] colors = new Color[]
                       {
           backgroundColor.colors[0].color,
            pointerColor.colors[0].color
                       };


            float duration = 3.0f;
            float t = (Time.time % duration) / duration;
            int fromIndex = (int)(t * (colors.Length - 1));
            int toIndex = (fromIndex + 1) % colors.Length;
            float lerpT = (t * (colors.Length - 1)) % 1.0f;

            Color lerpedColor = Color.Lerp(colors[fromIndex], colors[toIndex], lerpT);
            BetterplatformR = GameObject.CreatePrimitive(PrimitiveType.Cube);
            UnityEngine.Object.Destroy(BetterplatformR.GetComponent<Rigidbody>());
            UnityEngine.Object.Destroy(BetterplatformR.GetComponent<BoxCollider>());
            UnityEngine.Object.Destroy(BetterplatformR.GetComponent<Renderer>());
            BetterplatformR.transform.localScale = new Vector3(0.27f, 0.3f, 0.27f);
            GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
            UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
            //UnityEngine.Object.Destroy(gameObject.GetComponent<BoxCollider>());
            gameObject.transform.parent = BetterplatformR.transform;
            gameObject.transform.rotation = Quaternion.identity;
            gameObject.transform.localScale = new Vector3(0.1f, 1f, 1f);
            gameObject.GetComponent<Renderer>().material.color = lerpedColor;
            gameObject.transform.position = new Vector3(-0.02f, 0f, 0f);
        }
        #endregion

        #region Flys
        public static void WallAssist()
        {
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(GorillaLocomotion.Player.Instance.bodyCollider.transform.right * (Time.deltaTime * (3f / Time.deltaTime)), ForceMode.Acceleration);
            }

            if (EasyInputs.GetGripButtonDown(EasyHand.LeftHand))
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(GorillaLocomotion.Player.Instance.bodyCollider.transform.right * (Time.deltaTime * (-3f / Time.deltaTime)), ForceMode.Acceleration);
            }

            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand) && EasyInputs.GetGripButtonDown(EasyHand.LeftHand))
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(GorillaLocomotion.Player.Instance.bodyCollider.transform.forward * (Time.deltaTime * (3f / Time.deltaTime)), ForceMode.Acceleration);
            }
        }
        public static void HandFlight()
        {
            if (FlightSpeed == 0)
            {
                if (EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.rightHandTransform.transform.forward * 0.1f;
                    GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
                }
            }
            if (FlightSpeed == 1)
            {
                if (EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.rightHandTransform.transform.forward * 0.3f;
                    GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
                }
            }
            if (FlightSpeed == 2)
            {
                if (EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.rightHandTransform.transform.forward * 0.5f;
                    GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
                }
            }
            if (FlightSpeed == 3)
            {
                if (EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.rightHandTransform.transform.forward * 0.7f;
                    GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
                }
            }
            if (FlightSpeed == 4)
            {
                if (EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.rightHandTransform.transform.forward * 0.9f;
                    GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
                }
            }
            if (FlightSpeed == 5)
            {
                if (EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.rightHandTransform.transform.forward * 0.12f;
                    GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
                }
            }
        }
        public static void Flight()
        {
            if (FlightSpeed == 0)
            {
                if (EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * 0.1f;
                    GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
                }
            }
            if (FlightSpeed == 1)
            {
                if (EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * 0.3f;
                    GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
                }
            }
            if (FlightSpeed == 2)
            {
                if (EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * 0.5f;
                    GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
                }
            }
            if (FlightSpeed == 3)
            {
                if (EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * 0.7f;
                    GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
                }
            }
            if (FlightSpeed == 4)
            {
                if (EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * 0.9f;
                    GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
                }
            }
            if (FlightSpeed == 5)
            {
                if (EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * 0.12f;
                    GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
                }
            }
        }
        public static void TFlight()
        {
            if (FlightSpeed == 0)
            {
                if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * 0.1f;
                    GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
                }
            }
            if (FlightSpeed == 1)
            {
                if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * 0.3f;
                    GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
                }
            }
            if (FlightSpeed == 2)
            {
                if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * 0.5f;
                    GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
                }
            }
            if (FlightSpeed == 3)
            {
                if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * 0.7f;
                    GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
                }
            }
            if (FlightSpeed == 4)
            {
                if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * 0.9f;
                    GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
                }
            }
            if (FlightSpeed == 5)
            {
                if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * 0.12f;
                    GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
                }
            }
        }
        public static void Slingshot()
        {
            if (FlightSpeed == 0)
            {
                if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity += GorillaLocomotion.Player.Instance.headCollider.transform.forward * (0.3f);
                }
            }
            if (FlightSpeed == 1)
            {
                if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity += GorillaLocomotion.Player.Instance.headCollider.transform.forward * (0.5f);
                }
            }
            if (FlightSpeed == 2)
            {
                if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity += GorillaLocomotion.Player.Instance.headCollider.transform.forward * (0.7f);
                }
            }
            if (FlightSpeed == 3)
            {
                if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity += GorillaLocomotion.Player.Instance.headCollider.transform.forward * (0.9f);
                }
            }
            if (FlightSpeed == 4)
            {
                if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity += GorillaLocomotion.Player.Instance.headCollider.transform.forward * (0.12f);
                }
            }
            if (FlightSpeed == 5)
            {
                if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity += GorillaLocomotion.Player.Instance.headCollider.transform.forward * (0.15f);
                }
            }
        }
        public static void IronMonk()
        {
            if (GetIndex("Iron Monke FX").enabled == false)
            {
                {
                    if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                    {
                        GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity += GorillaLocomotion.Player.Instance.rightHandTransform.right / 3f;
                    }

                    if (EasyInputs.GetGripButtonDown(EasyHand.LeftHand))
                    {
                        GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity += -GorillaLocomotion.Player.Instance.leftHandTransform.right / 3f;
                    }
                }
            }
            if (GetIndex("Iron Monke FX").enabled == true)
            {
                {
                    if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                    {
                        GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity += GorillaLocomotion.Player.Instance.rightHandTransform.right / 3f;
                        GorillaTagger.Instance.StartVibration(rightHanded, GorillaTagger.Instance.tagHapticStrength / 0.2f, GorillaTagger.Instance.tagHapticDuration / 0.2f);
                        GorillaTagger.Instance.offlineVRRig.PlayHandTap(31, rightHanded, 0.1f);
                        GorillaTagger.Instance.offlineVRRig.PlayHandTap(31, rightHanded, 0.1f);
                    }

                    if (EasyInputs.GetGripButtonDown(EasyHand.LeftHand))
                    {
                        GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity += -GorillaLocomotion.Player.Instance.leftHandTransform.right / 3f;
                        GorillaTagger.Instance.StartVibration(leftHanded, GorillaTagger.Instance.tagHapticStrength / 0.2f, GorillaTagger.Instance.tagHapticDuration / 0.2f);
                        GorillaTagger.Instance.offlineVRRig.PlayHandTap(31, leftHanded, 0.1f);
                        GorillaTagger.Instance.offlineVRRig.PlayHandTap(31, leftHanded, 0.1f);
                    }
                }
            }
        }
        #endregion

        #region Misc
        public static void Turn()
        {
            {
                if (EasyInputs.GetThumbStickButtonTouched(EasyHand.RightHand))
                {
                    GorillaLocomotion.Player.Instance.Turn(EasyInputs.GetThumbStick2DAxis(EasyHand.RightHand).x * 5f);
                    GorillaLocomotion.Player.Instance.disableMovement = false;
                }
            }
        }
        public static void SpeedBoost()
        {
            GorillaLocomotion.Player.Instance.jumpMultiplier = 9.2f;
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 9.4f;
        }
        public static void SlowBoost()
        {
            GorillaLocomotion.Player.Instance.jumpMultiplier = 0f;
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 0f;
        }
        public static void CrazyBoost()
        {
            GorillaLocomotion.Player.Instance.jumpMultiplier = 11.5f;
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 11.7f;
        }
        public static void Noclip()
        {
            {
                if (EasyInputs.GetTriggerButtonDown(EasyHand.LeftHand))
                {
                    foreach (MeshCollider meshCollider in Resources.FindObjectsOfTypeAll<MeshCollider>())
                    {
                        meshCollider.enabled = false;
                    }
                }
                else
                {
                    foreach (MeshCollider meshCollider2 in Resources.FindObjectsOfTypeAll<MeshCollider>())
                    {
                        bool Fall = !meshCollider2.enabled;
                        if (!Fall)
                        {
                            break;
                        }
                        meshCollider2.enabled = true;
                    }
                }
            }
        }
        public static void SlideControll()
        {
            {
                GorillaLocomotion.Player.Instance.slideControl = 1;
            }
        }
        public static void TPtoStump()
        {
            {
                if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                {
                    foreach (MeshCollider meshCollider in Resources.FindObjectsOfTypeAll<MeshCollider>())
                    {
                        meshCollider.enabled = false;
                    }
                    GorillaLocomotion.Player.Instance.transform.position = new Vector3(-66.4848f, 11.8871f, -82.6619f);
                }
                else
                {
                    foreach (MeshCollider meshCollider2 in Resources.FindObjectsOfTypeAll<MeshCollider>())
                    {
                        bool Mesh = !meshCollider2.enabled;
                        bool Mesh2 = !Mesh;
                        if (Mesh2)
                        {
                            break;
                        }
                        meshCollider2.enabled = true;
                    }
                }
            }
        }
        public static void ZeroGravity()
        {
            {
                Physics.gravity = new Vector3(0f, 0f, 0f);
            }
        }
        public static void LowGravity()
        {
            {
                Physics.gravity = new Vector3(0f, -3f, 0f);
            }
        }
        public static void HighGravity()
        {
            {
                Physics.gravity = new Vector3(0f, -30f, 0f);
            }
        }
        public static void FixGravity()
        {
            {
                Physics.gravity = new Vector3(0f, -9.81f, 0f);
            }
        }
        public static void Bomb()
        {
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                if (BombObject == null)
                {
                    BombObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    UnityEngine.Object.Destroy(BombObject.GetComponent<Rigidbody>());
                    UnityEngine.Object.Destroy(BombObject.GetComponent<SphereCollider>());
                    BombObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                    BombObject.GetComponent<Renderer>().material.color = backgroundColor.colors[0].color;
                }
                BombObject.transform.position = GorillaTagger.Instance.rightHandTransform.position;
            }
            if (BombObject != null)
            {
                if (EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand))
                {
                    BombObject.GetComponent<Renderer>().material.color = Color.white;
                    Vector3 dir = (GorillaTagger.Instance.bodyCollider.transform.position - BombObject.transform.position);
                    dir.Normalize();
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity += 25f * dir;
                    UnityEngine.Object.Destroy(BombObject);
                    BombObject = null;
                }
                else
                {
                    BombObject.GetComponent<Renderer>().material.color = backgroundColor.colors[0].color;
                }
            }
        }

        public static void DisableBomb()
        {
            if (BombObject != null)
            {
                UnityEngine.Object.Destroy(BombObject);
                BombObject = null;
            }
        }

        public static void CheckPoint()
        {
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                if (PointObject == null)
                {
                    PointObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    UnityEngine.Object.Destroy(PointObject.GetComponent<Rigidbody>());
                    UnityEngine.Object.Destroy(PointObject.GetComponent<SphereCollider>());
                    PointObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                }
                PointObject.transform.position = GorillaTagger.Instance.rightHandTransform.position;
            }
            if (PointObject != null)
            {
                if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                {
                    foreach (MeshCollider meshCollider in Resources.FindObjectsOfTypeAll<MeshCollider>())
                    {
                        meshCollider.enabled = false;
                    }
                    GorillaLocomotion.Player.Instance.transform.position = new Vector3(-66.4848f, 11.8871f, -82.6619f);
                    PointObject.GetComponent<Renderer>().material.color = backgroundColor.colors[0].color;
                    GorillaLocomotion.Player.Instance.transform.position = PointObject.transform.position;
                    UnityEngine.Object.Destroy(PointObject);
                    PointObject = null;
                }
                else
                {
                    foreach (MeshCollider meshCollider2 in Resources.FindObjectsOfTypeAll<MeshCollider>())
                    {
                        bool Mesh = !meshCollider2.enabled;
                        bool Mesh2 = !Mesh;
                        if (Mesh2)
                        {
                            break;
                        }
                        meshCollider2.enabled = true;
                    }
                    PointObject.GetComponent<Renderer>().material.color = backgroundColor.colors[0].color;
                }
            }
        }

        public static void DisableCheckPoint()
        {
            if (PointObject != null)
            {
                UnityEngine.Object.Destroy(PointObject);
                PointObject = null;
            }
        }

        #endregion
    }
}
