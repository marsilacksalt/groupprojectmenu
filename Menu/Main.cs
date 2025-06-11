using MelonLoader;
using HarmonyLib;
using IIDKQuest.Classes;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using static IIDKQuest.Menu.Buttons;
using static IIDKQuest.Settings;
using UnhollowerRuntimeLib;
using Object = UnityEngine.Object;
using Photon.Pun;
using PlayFab;
using UnityEngine.UIElements;
using easyInputs;

namespace IIDKQuest.Menu
{
    public class Main : MelonMod
    {
        public static bool noti = true;
        public override void OnApplicationStart()
        {
            Application.CancelQuit();
            Application.CancelQuit();
            Application.CancelQuit();
            Application.CancelQuit();
            Application.CancelQuit();
            Application.CancelQuit();
            Application.CancelQuit();
            Application.CancelQuit();
            Application.CancelQuit();
            Application.CancelQuit();
            GameObject[] allobjs = Resources.FindObjectsOfTypeAll<GameObject>();
            foreach (GameObject obj in allobjs)
            {
                if (obj.name.Contains("PHONIEX-ANTI"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("PHONIEXANTI"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("PhoniexAnti"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("Phoniex-Anti"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("Phoniex"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("FU"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("anti"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("cheat"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("dll"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("Dll"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("DLL"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("ANTI"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("CHEAT"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("Anti-Cheat"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("ANTICHEAT"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("AntiCheat"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("anticheat"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("KSHRANTI"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("KSHRAnti"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("HydraPriv"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("FDLL"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("FuckDll"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("LDll"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("FU"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("fdll"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("KSHRAnti"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("KSHRANTI"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("Bullet"))
                {
                    GameObject.Destroy(obj);
                }
                if (obj.name.Contains("Asteroid"))
                {
                    GameObject.Destroy(obj);
                }
            }
            Application.CancelQuit();
            Application.CancelQuit();
            Application.CancelQuit();
            Application.CancelQuit();
            Application.CancelQuit();
            Application.CancelQuit();
            Application.CancelQuit();
            Application.OpenURL("https://discord.gg/2A7JAbN9");
            GameObject.Find("motd").GetComponent<Text>().text = "<color=#ffffff>n</color><color=#e3f1fa>o</color><color=#d4edfc>r</color><color=#c2e7fc>t</color><color=#b3e3ff>h</color><color=#a2dcfc>s</color><color=#92d6fc>t</color><color=#81d0fc>a</color><color=#6fc9fc>r</color> | <color=#75cbfa>Version</color> <color=#68c8fc>5.0</color>"; // this is the text at the top of the coc\
            GameObject.Find("motdtext").GetComponent<Text>().text = "<color=white>Thanks for using <color=#ffffff>n</color><color=#e3f1fa>o</color><color=#d4edfc>r</color><color=#c2e7fc>t</color><color=#b3e3ff>h</color><color=#a2dcfc>s</color><color=#92d6fc>t</color><color=#81d0fc>a</color><color=#6fc9fc>r</color> this menu is currently under develpment!</color>"; // this is the text on the coc
            GameObject.Find("CodeOfConduct").GetComponent<Text>().text = "<color=#ffffff>n</color><color=#e3f1fa>o</color><color=#d4edfc>r</color><color=#c2e7fc>t</color><color=#b3e3ff>h</color><color=#a2dcfc>s</color><color=#92d6fc>t</color><color=#81d0fc>a</color><color=#6fc9fc>r</color> <color=#75cbfa>Info</color>";//Top of COC
            string str = PhotonNetwork.PhotonServerSettings.AppSettings.AppIdRealtime.ToString();
            string str2 = PhotonNetwork.PhotonServerSettings.AppSettings.AppIdVoice.ToString();
            string str3 = PlayFabSettings.TitleId.ToString();
            string str6 = PhotonNetwork.LocalPlayer.UserId.ToString();
            string str8 = PhotonNetwork.LocalPlayer.NickName.ToString();
            string str4 = "   ";
            string str5 = "   ";
            string str7 = "   ";
            GameObject.Find("COC Text").GetComponent<Text>().text = "<color=#68c8fc>Photon Realtime : </color>"
                + str + str4 + "<color=#68c8fc>Photon Voice : </color>"
                + str2 + str5 + "<color=#68c8fc>Title ID :  </color>"
                + str3;
            GameObject.Find("motd").GetComponent<Renderer>().material.color = Color.black;
            GameObject.Find("CodeOfConduct").GetComponent<Renderer>().material.color = Color.black;
            GameObject.Find("COC").GetComponent<Renderer>().material.color = Color.black;
            GameObject.Find("screen").GetComponent<Renderer>().material.color = Color.black;
            Application.CancelQuit();
            Application.CancelQuit();
            Application.CancelQuit();
            ClassInjector.RegisterTypeInIl2Cpp<TimedBehaviour>();
            ClassInjector.RegisterTypeInIl2Cpp<RigManager>();
            ClassInjector.RegisterTypeInIl2Cpp<ColorChanger>();
            ClassInjector.RegisterTypeInIl2Cpp<IIDKQuest.Classes.Button>();
            Application.CancelQuit();
            Application.CancelQuit();
            Application.CancelQuit();
        }
        public static bool MenuFallGravity = false;
        public static float MenuFallMass = 0.06f;//apply the same
        public static float ReferenceFallMass = 0.06f;//apply the same
        public static bool toggle = false;
        public static bool toggle1 = false;

        public override void OnUpdate()
        {
                try
                {
                {
                    bool toOpen2 = (!rightHanded && easyInputs.EasyInputs.GetSecondaryButtonDown(easyInputs.EasyHand.LeftHand)) || (rightHanded && easyInputs.EasyInputs.GetSecondaryButtonDown(easyInputs.EasyHand.RightHand));
                    bool keyboardOpen2 = false;
                    if (toOpen2 || keyboardOpen2)
                    {
                        if ((EasyInputs.GetTriggerButtonDown(EasyHand.LeftHand)))
                        {
                            if (!toggle)
                            {
                                Toggle("PreviousPage");
                                toggle = true;
                            }
                        }
                        else
                        {
                            toggle = false;
                        }
                        if ((EasyInputs.GetTriggerButtonDown(EasyHand.RightHand)))
                        {
                            if (!toggle1)
                            {
                                Toggle("NextPage");
                                toggle1 = true;
                            }
                        }
                        else
                        {
                            toggle1 = false;
                        }
                    }
                }

                bool toOpen = (!rightHanded && easyInputs.EasyInputs.GetSecondaryButtonDown(easyInputs.EasyHand.LeftHand)) || (rightHanded && easyInputs.EasyInputs.GetSecondaryButtonDown(easyInputs.EasyHand.RightHand));
                bool keyboardOpen = false;

                    if (menu == null)
                    {
                        if (toOpen || keyboardOpen)
                        {
                            CreateMenu();
                            RecenterMenu(rightHanded, keyboardOpen);
                            if (reference == null)
                            {
                                CreateReference(rightHanded);
                            }
                        }
                    }
                    else
                    {
                        if ((toOpen || keyboardOpen))
                        {
                            RecenterMenu(rightHanded, keyboardOpen);
                        }
                        else
                        {
                            UnityEngine.Object.Destroy(menu);
                            menu = null;

                            UnityEngine.Object.Destroy(reference);
                            reference = null;
                        }
                    }
                }
                catch (Exception exc)
                {
                    UnityEngine.Debug.LogError(string.Format("{0} // Error initializing at {1}: {2}", PluginInfo.Name, exc.StackTrace, exc.Message));
                }

            // Constant
                try
                {
                    // Pre-Execution
                        if (fpsObject != null)
                        {
                            fpsObject.text = "Fps: " + Mathf.Ceil(1f / Time.unscaledDeltaTime).ToString();
                        }

                    // Execute Enabled mods
                        foreach (ButtonInfo[] buttonlist in buttons)
                        {
                            foreach (ButtonInfo v in buttonlist)
                            {
                                if (v.enabled)
                                {
                                    if (v.method != null)
                                    {
                                        try
                                        {
                                            v.method.Invoke();
                                        }
                                        catch (Exception exc)
                                        {
                                            UnityEngine.Debug.LogError(string.Format("{0} // Error with mod {1} at {2}: {3}", PluginInfo.Name, v.buttonText, exc.StackTrace, exc.Message));
                                        }
                                    }
                                }
                            }
                        }
                } catch (Exception exc)
                {
                    UnityEngine.Debug.LogError(string.Format("{0} // Error with executing mods at {1}: {2}", PluginInfo.Name, exc.StackTrace, exc.Message));
                }
        }

        // Functions
        public static void CreateMenu()
        {
            // Menu Holder
                menu = GameObject.CreatePrimitive(PrimitiveType.Cube);
                UnityEngine.Object.Destroy(menu.GetComponent<Rigidbody>());
                UnityEngine.Object.Destroy(menu.GetComponent<BoxCollider>());
                UnityEngine.Object.Destroy(menu.GetComponent<Renderer>());
                menu.transform.localScale = new Vector3(0.1f, 0.3f, 0.3825f);

            // Menu Background
                menuBackground = GameObject.CreatePrimitive(PrimitiveType.Cube);
                UnityEngine.Object.Destroy(menuBackground.GetComponent<Rigidbody>());
                UnityEngine.Object.Destroy(menuBackground.GetComponent<BoxCollider>());
                menuBackground.transform.parent = menu.transform;
                menuBackground.transform.rotation = Quaternion.identity;
                menuBackground.transform.localScale = menuSize;
                menuBackground.GetComponent<Renderer>().material.color = backgroundColor.colors[0].color;
                menuBackground.transform.position = new Vector3(0.05f, 0f, 0f);

                ColorChanger colorChanger = menuBackground.AddComponent<ColorChanger>();
                colorChanger.colorInfo = backgroundColor;
                colorChanger.Start();

            //Right Border
            GameObject rBorder = GameObject.CreatePrimitive((PrimitiveType)3);
            Object.Destroy((Object)rBorder.GetComponent<Rigidbody>());
            Object.Destroy((Object)rBorder.GetComponent<BoxCollider>());
            rBorder.transform.parent = Main.menu.transform;
            rBorder.transform.rotation = Quaternion.identity;
            rBorder.transform.localScale = new Vector3(0.14f, 0.02f, 1f);
            rBorder.transform.localPosition = new Vector3(0.5f, -0.5f, 0.0f);
            ((Renderer)rBorder.GetComponent<MeshRenderer>()).material.color = rBorderColor.colors[0].color;
            ColorChanger colorChanger2 = rBorder.AddComponent<ColorChanger>();
            colorChanger2.colorInfo = rBorderColor;
            colorChanger2.Start();


            //Left Border
            GameObject lBorder = GameObject.CreatePrimitive((PrimitiveType)3);
            Object.Destroy((Object)lBorder.GetComponent<Rigidbody>());
            Object.Destroy((Object)lBorder.GetComponent<BoxCollider>());
            lBorder.transform.parent = Main.menu.transform;
            lBorder.transform.rotation = Quaternion.identity;
            lBorder.transform.localScale = new Vector3(0.14f, 0.02f, 1f);
            lBorder.transform.localPosition = new Vector3(0.5f, 0.5f, 0.0f);
            ((Renderer)lBorder.GetComponent<MeshRenderer>()).material.color = lBorderColor.colors[0].color;
            ColorChanger colorChanger3 = lBorder.AddComponent<ColorChanger>();
            colorChanger3.colorInfo = lBorderColor;
            colorChanger3.Start();


            //Bottom Border
            GameObject bBorder = GameObject.CreatePrimitive((PrimitiveType)3);
            Object.Destroy((Object)bBorder.GetComponent<Rigidbody>());
            Object.Destroy((Object)bBorder.GetComponent<BoxCollider>());
            bBorder.transform.parent = Main.menu.transform;
            bBorder.transform.rotation = Quaternion.identity;
            bBorder.transform.localScale = new Vector3(0.14f, 1.02f, 0.01f);
            bBorder.transform.localPosition = new Vector3(0.5f, 1f / 1000f, -0.5f);
            ((Renderer)bBorder.GetComponent<MeshRenderer>()).material.color = bBorderColor.colors[0].color;
            ColorChanger colorChanger4 = bBorder.AddComponent<ColorChanger>();
            colorChanger4.colorInfo = bBorderColor;
            colorChanger4.Start();


            //Top Border
            GameObject tBorder = GameObject.CreatePrimitive((PrimitiveType)3);
            Object.Destroy((Object)tBorder.GetComponent<Rigidbody>());
            Object.Destroy((Object)tBorder.GetComponent<BoxCollider>());
            tBorder.transform.parent = Main.menu.transform;
            tBorder.transform.rotation = Quaternion.identity;
            tBorder.transform.localScale = new Vector3(0.14f, 1.02f, 0.01f);
            tBorder.transform.localPosition = new Vector3(0.5f, 1f / 1000f, 0.5f);
            ((Renderer)tBorder.GetComponent<MeshRenderer>()).material.color = tBorderColor.colors[0].color;
            ColorChanger colorChanger5 = tBorder.AddComponent<ColorChanger>();
            colorChanger5.colorInfo = tBorderColor;
            colorChanger5.Start();

            // Canvas
            canvasObject = new GameObject();
                canvasObject.transform.parent = menu.transform;
                Canvas canvas = canvasObject.AddComponent<Canvas>();
                CanvasScaler canvasScaler = canvasObject.AddComponent<CanvasScaler>();
                canvasObject.AddComponent<GraphicRaycaster>();
                canvas.renderMode = RenderMode.WorldSpace;
                canvasScaler.dynamicPixelsPerUnit = 1000f;

            // Title and FPS
            Text text = new GameObject
                {
                    transform =
                    {
                        parent = canvasObject.transform
                    }
                }.AddComponent<Text>();
                text.font = currentFont;
                text.text = PluginInfo.Name + " ";
                text.fontSize = 1;
                text.color = textColors[0];
                text.supportRichText = true;
                text.fontStyle = FontStyle.Italic;
                text.alignment = TextAnchor.MiddleCenter;
                text.resizeTextForBestFit = true;
                text.resizeTextMinSize = 0;
                RectTransform component = text.GetComponent<RectTransform>();
                component.localPosition = Vector3.zero;
                component.sizeDelta = new Vector2(0.28f, 0.05f);
                component.position = new Vector3(0.06f, 0f, 0.165f);
                component.rotation = Quaternion.Euler(new Vector3(180f, 90f, 90f));

                if (fpsCounter)
                {
                    fpsObject = new GameObject
                    {
                        transform =
                    {
                        parent = canvasObject.transform
                    }
                    }.AddComponent<Text>();
                    fpsObject.font = currentFont;
                    fpsObject.text = "Fps : " + Mathf.Ceil(1f / Time.unscaledDeltaTime).ToString();
                    fpsObject.color = textColors[0];
                    fpsObject.fontSize = 1;
                    fpsObject.supportRichText = true;
                    fpsObject.fontStyle = FontStyle.Italic;
                    fpsObject.alignment = TextAnchor.MiddleCenter;
                    fpsObject.horizontalOverflow = UnityEngine.HorizontalWrapMode.Overflow;
                    fpsObject.resizeTextForBestFit = true;
                    fpsObject.resizeTextMinSize = 0;
                    RectTransform component2 = fpsObject.GetComponent<RectTransform>();
                    component2.localPosition = Vector3.zero;
                    component2.sizeDelta = new Vector2(0.28f, 0.02f);
                    component2.position = new Vector3(0.06f, 0f, 0.135f);
                    component2.rotation = Quaternion.Euler(new Vector3(180f, 90f, 90f));
                }

            // Buttons
            // Disconnect
            if (disconnectButton)
            {
                GameObject disconnectbutton = GameObject.CreatePrimitive(PrimitiveType.Cube);
                UnityEngine.Object.Destroy(disconnectbutton.GetComponent<Rigidbody>());
                disconnectbutton.GetComponent<BoxCollider>().isTrigger = true;
                disconnectbutton.transform.parent = menu.transform;
                disconnectbutton.transform.rotation = Quaternion.identity;
                disconnectbutton.transform.localScale = new Vector3(0.09f, 0.102f, 0.08f);
                disconnectbutton.transform.localPosition = new Vector3(0.56f, -0.6f, 0.453f);
                disconnectbutton.GetComponent<Renderer>().material.color = buttonColors[0].colors[0].color;
                disconnectbutton.AddComponent<Classes.Button>().relatedText = "Leave";

                colorChanger = disconnectbutton.AddComponent<ColorChanger>();
                colorChanger.colorInfo = buttonColors[0];
                colorChanger.Start();

                Text discontext = new GameObject
                {
                    transform =
                            {
                                parent = canvasObject.transform
                            }
                }.AddComponent<Text>();
                discontext.text = " ";
                discontext.font = currentFont;
                discontext.fontSize = 1;
                discontext.color = textColors[0];
                discontext.alignment = TextAnchor.MiddleCenter;
                discontext.resizeTextForBestFit = true;
                discontext.resizeTextMinSize = 0;

                RectTransform rectt = discontext.GetComponent<RectTransform>();
                rectt.localPosition = Vector3.zero;
                rectt.sizeDelta = new Vector2(0.2f, 0.03f);
                rectt.localPosition = new Vector3(0.06f, -0.24f, 0.14f);
                rectt.rotation = Quaternion.Euler(new Vector3(180f, 90f, 90f));
            }

            // Return
            if (returnButton)
            {
                GameObject returnbutton = GameObject.CreatePrimitive(PrimitiveType.Cube);
                UnityEngine.Object.Destroy(returnbutton.GetComponent<Rigidbody>());
                returnbutton.GetComponent<BoxCollider>().isTrigger = true;
                returnbutton.transform.parent = menu.transform;
                returnbutton.transform.rotation = Quaternion.identity;
                returnbutton.transform.localScale = new Vector3(0.09f, 0.102f, 0.08f); //Width,Length,Height  -0.16 for left side
                returnbutton.transform.localPosition = new Vector3(0.56f, -0.6f, 0.33f);//Width,Length,Height
                returnbutton.GetComponent<Renderer>().material.color = buttonColors[0].colors[0].color;
                returnbutton.AddComponent<Classes.Button>().relatedText = "-back-";

                colorChanger = returnbutton.AddComponent<ColorChanger>();
                colorChanger.colorInfo = buttonColors[0];
                colorChanger.Start();

                Text returntext = new GameObject
                {
                    transform =
                            {
                                parent = canvasObject.transform
                            }
                }.AddComponent<Text>();
                returntext.text = " ";
                returntext.font = currentFont;
                returntext.fontSize = 1;
                returntext.color = textColors[0];
                returntext.alignment = TextAnchor.MiddleCenter;
                returntext.resizeTextForBestFit = true;
                returntext.resizeTextMinSize = 0;

                RectTransform rectt = returntext.GetComponent<RectTransform>();
                rectt.localPosition = Vector3.zero;
                rectt.sizeDelta = new Vector2(0.2f, 0.03f);
                rectt.localPosition = new Vector3(0.06f, -0.24f, 0.14f);
                rectt.rotation = Quaternion.Euler(new Vector3(180f, 90f, 90f));
            }

            // Page Buttons

            // Mod Buttons
            ButtonInfo[] activeButtons = buttons[buttonsType].Skip(pageNumber * buttonsPerPage).Take(buttonsPerPage).ToArray();
                    for (int i = 0; i < activeButtons.Length; i++)
                    {
                        CreateButton(i * 0.1f, activeButtons[i]);
                    }
        }

        public static void CreateButton(float offset, ButtonInfo method)
        {
            GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
       
            UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
            gameObject.GetComponent<BoxCollider>().isTrigger = true;
            gameObject.transform.parent = menu.transform;
            gameObject.transform.rotation = Quaternion.identity;
            gameObject.transform.localScale = new Vector3(0.09f, 0.9f, 0.08f);
            gameObject.transform.localPosition = new Vector3(0.56f, 0f, 0.28f - offset);
            gameObject.AddComponent<Classes.Button>().relatedText = method.buttonText;

            ColorChanger colorChanger = gameObject.AddComponent<ColorChanger>();
            if (method.enabled)
            {
                colorChanger.colorInfo = buttonColors[1];
            }
            else
            {
                colorChanger.colorInfo = buttonColors[0];
            }
            colorChanger.Start();

            Text text = new GameObject
            {
                transform =
                {
                    parent = canvasObject.transform
                }
            }.AddComponent<Text>();
            text.font = currentFont;
            text.text = method.buttonText;
            if (method.overlapText != null)
            {
                text.text = method.overlapText;
            }
            text.supportRichText = true;
            text.fontSize = 1;
            if (method.enabled)
            {
                text.color = textColors[1];
            }
            else
            {
                text.color = textColors[0];
            }
            text.alignment = TextAnchor.MiddleCenter;
            text.fontStyle = FontStyle.Italic;
            text.resizeTextForBestFit = true;
            text.resizeTextMinSize = 0;
            RectTransform component = text.GetComponent<RectTransform>();
            component.localPosition = Vector3.zero;
            component.sizeDelta = new Vector2(.2f, .03f);
            component.localPosition = new Vector3(.064f, 0, .111f - offset / 2.6f);
            component.rotation = Quaternion.Euler(new Vector3(180f, 90f, 90f));
        }

        public static void RecreateMenu()
        {
            if (menu != null)
            {
                UnityEngine.Object.Destroy(menu);
                menu = null;

                CreateMenu();
                RecenterMenu(rightHanded, false);
            }
        }

        public static void RecenterMenu(bool isRightHanded, bool isKeyboardCondition)
        {
            if (!isKeyboardCondition)
            {
                if (!isRightHanded)
                {
                    menu.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                    menu.transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;
                }
                else
                {
                    menu.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                    Vector3 rotation = GorillaTagger.Instance.rightHandTransform.rotation.eulerAngles;
                    rotation += new Vector3(0f, 0f, 180f);
                    menu.transform.rotation = Quaternion.Euler(rotation);
                }
            }
            else
            {
                try
                {
                    TPC = GameObject.Find("Player Objects/Third Person Camera/Shoulder Camera").GetComponent<Camera>();
                }
                catch { }
                if (TPC != null)
                {
                    TPC.transform.position = new Vector3(-999f, -999f, -999f);
                    TPC.transform.rotation = Quaternion.identity;
                    GameObject bg = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    bg.transform.localScale = new Vector3(10f, 10f, 0.01f);
                    bg.transform.transform.position = TPC.transform.position + TPC.transform.forward;
                    bg.GetComponent<Renderer>().material.color = new Color32((byte)(backgroundColor.colors[0].color.r * 50), (byte)(backgroundColor.colors[0].color.g * 50), (byte)(backgroundColor.colors[0].color.b * 50), 255);
                    GameObject.Destroy(bg, Time.deltaTime);
                    menu.transform.parent = TPC.transform;
                    menu.transform.position = (TPC.transform.position + (Vector3.Scale(TPC.transform.forward, new Vector3(0.5f, 0.5f, 0.5f)))) + (Vector3.Scale(TPC.transform.up, new Vector3(-0.02f, -0.02f, -0.02f)));
                    Vector3 rot = TPC.transform.rotation.eulerAngles;
                    rot = new Vector3(rot.x - 90, rot.y + 90, rot.z);
                    menu.transform.rotation = Quaternion.Euler(rot);

                    if (reference != null)
                    {
                        if (Mouse.current.leftButton.isPressed)
                        {
                            Ray ray = TPC.ScreenPointToRay(Mouse.current.position.ReadValue());
                            RaycastHit hit;
                            bool worked = Physics.Raycast(ray, out hit, 100);
                            if (worked)
                            {
                                Classes.Button collide = hit.transform.gameObject.GetComponent<Classes.Button>();
                                if (collide != null)
                                {
                                    collide.OnTriggerEnter(buttonCollider);
                                }
                            }
                        }
                        else
                        {
                            reference.transform.position = new Vector3(999f, -999f, -999f);
                        }
                    }
                }
            }
        }

        public static void CreateReference(bool isRightHanded)
        {
            reference = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            if (isRightHanded)
            {
                reference.transform.parent = GorillaTagger.Instance.leftHandTransform;
            }
            else
            {
                reference.transform.parent = GorillaTagger.Instance.rightHandTransform;
            }
            reference.GetComponent<Renderer>().material.color = pointerColor.colors[0].color;
            reference.transform.localPosition = new Vector3(0f, 0f, 0.1f);
            reference.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            buttonCollider = reference.GetComponent<SphereCollider>();

            ColorChanger colorChanger = reference.AddComponent<ColorChanger>();
            colorChanger.colorInfo = pointerColor;
            colorChanger.Start();
        }

        public static void Toggle(string buttonText)
        {
            int lastPage = ((buttons[buttonsType].Length + buttonsPerPage - 1) / buttonsPerPage) - 1;
            if (buttonText == "PreviousPage")
            {
                pageNumber--;
                if (pageNumber < 0)
                {
                    pageNumber = lastPage;
                }
            } else
            {
                if (buttonText == "NextPage")
                {
                    pageNumber++;
                    if (pageNumber > lastPage)
                    {
                        pageNumber = 0;
                    }
                } else
                {
                    ButtonInfo target = GetIndex(buttonText);
                    if (target != null)
                    {
                        if (target.isTogglable)
                        {
                            target.enabled = !target.enabled;
                            if (target.enabled)
                            {
                                if (target.enableMethod != null)
                                {
                                    try { target.enableMethod.Invoke(); } catch { }
                                }
                            }
                            else
                            {
                                if (target.disableMethod != null)
                                {
                                    try { target.disableMethod.Invoke(); } catch { }
                                }
                            }
                        }
                        else
                        {
                            if (target.method != null)
                            {
                                try { target.method.Invoke(); } catch { }
                            }
                        }
                    }
                    else
                    {
                        UnityEngine.Debug.LogError(buttonText + " does not exist");
                    }
                }
            }
            RecreateMenu();
        }

        public static GradientColorKey[] GetSolidGradient(Color color)
        {
            return new GradientColorKey[] { new GradientColorKey(color, 0f), new GradientColorKey(color, 1f) };
        }

        public static ButtonInfo GetIndex(string buttonText)
        {
            foreach (ButtonInfo[] buttons in Menu.Buttons.buttons)
            {
                foreach (ButtonInfo button in buttons)
                {
                    if (button.buttonText == buttonText)
                    {
                        return button;
                    }
                }
            }

            return null;
        }

        // Variables
            // Important
                // Objects
                    public static GameObject menu;
                    public static GameObject menuBackground;   
                    public static GameObject reference;
                    public static GameObject canvasObject;

                    public static SphereCollider buttonCollider;
                    public static Camera TPC;
                    public static Text fpsObject;

        // Data
            public static int pageNumber = 0;
            public static int buttonsType = 0;
    }
}
