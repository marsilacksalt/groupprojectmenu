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
using static IIDKQuest.Mods.SettingsMods;
using static StupidTemplate.Classes.ColorLib;
using UnityEngine.UIElements;

namespace IIDKQuest.Menu
{
    internal class Visual
    {
        public static bool SpawnedCamera = false;
        public static GameObject CameraHolder;
        public static GameObject CameraObject;
        public static void EnterVisual()
        {
            buttonsType = 6;
        }

        #region Esp
        public static void Tracers()
        {
            GameObject gameObject = GameObject.Find("RightHand Controller");
            if (PhotonNetwork.CurrentRoom != null)
            {
                foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                {
                    if (!vrrig.isOfflineVRRig)
                    {
                        GameObject gameObject2 = new GameObject("Line");
                        LineRenderer lineRenderer = gameObject2.AddComponent<LineRenderer>();
                        lineRenderer.startWidth = (lineRenderer.endWidth = 0.01f);
                        lineRenderer.positionCount = 2;
                        lineRenderer.SetPositions(new Vector3[]
                        {
                            gameObject.transform.position,
                            vrrig.headMesh.transform.position
                        });
                        lineRenderer.material.shader = Shader.Find("GUI/Text Shader");
                        if (EspTheme == 0)
                        {
                            lineRenderer.startColor = backgroundColor.colors[0].color;
                            lineRenderer.endColor = pointerColor.colors[0].color;
                        }
                        if (EspTheme == 1)
                        {
                            if (((Renderer)vrrig.mainSkin).material.name.Contains("fected"))
                            {
                                lineRenderer.startColor = MaroonTransparent;
                                lineRenderer.endColor = pointerColor.colors[0].color;
                            }
                            else
                            {
                                lineRenderer.startColor = ForestGreenTransparent;
                                lineRenderer.endColor = pointerColor.colors[0].color;
                            }
                        }
                        UnityEngine.Object.Destroy(gameObject2, Time.deltaTime);
                    }
                }
            }
        }
        #endregion

        #region Game
        public static void CameraMod()
        {
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                if (SpawnedCamera == false)
                {
                    CameraHolder = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    UnityEngine.Object.Destroy(CameraHolder.GetComponent<BoxCollider>());
                    CameraObject = new GameObject("Main Camera");
                    Camera camera = CameraObject.AddComponent<Camera>();
                    CameraObject.transform.parent = CameraHolder.transform;
                    CameraObject.tag = "MainCamera";
                    CameraHolder.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    CameraHolder.transform.position = GorillaLocomotion.Player.Instance.rightHandTransform.position;
                    CameraObject.transform.Rotate(0f, 180f, 0f);
                    camera.nearClipPlane = 0.01f;
                    SpawnedCamera = true;
                }

                CameraHolder.transform.position = GorillaLocomotion.Player.Instance.rightHandTransform.position;
                CameraHolder.transform.rotation = GorillaLocomotion.Player.Instance.rightHandTransform.rotation;

            }
            if (EasyInputs.GetGripButtonDown(EasyHand.LeftHand))
            {
                if (SpawnedCamera == true)
                {
                    GameObject.Destroy(CameraHolder);
                    SpawnedCamera = false;
                }
            }

        }
        public static void EnabledMirror()
        {
            {
                GameObject[] allobjs = Resources.FindObjectsOfTypeAll<GameObject>();
                foreach (GameObject obj in allobjs)
                {
                    if (obj.name == "mirror (1)") { obj.SetActive(true); }
                }
            }
        }
        public static void DisableMirror()
        {
            {
                GameObject[] allobjs = Resources.FindObjectsOfTypeAll<GameObject>();
                foreach (GameObject obj in allobjs)
                {
                    if (obj.name == "mirror (1)") { obj.SetActive(false); }
                }
            }
        }
        #endregion
    }
}
