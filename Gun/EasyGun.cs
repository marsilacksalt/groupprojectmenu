using easyInputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static StupidTemplate.Classes.ColorLib;

namespace IIDKQuest
{
    public class EasyGun
    {

        public Color
            sphereUnpressed = DodgerBlueTransparent,
            spherePress = DarkDodgerBlueTransparent;

        public Color lineColor = BlueTransparent;
        public LineRenderer rend;
        public bool isLeft;

        private bool useCooldown;
        private bool cooldown;
        private VRRig lockedRig;
        private int layerMask;
        private Material baseMat;
        private GunType gunType;
        private bool useLine;

        public EasyGun(GunType guntype, bool isleft = false, bool usecooldown = false, bool useLine = true)
        {
            isLeft = isleft;
            gunType = guntype;
            baseMat = new Material(Shader.Find("Standard"));

            int glarp = 1 << 5;
            int glarp2 = 1 << 15;

            layerMask = glarp | glarp2;
            useCooldown = usecooldown;
            this.useLine = useLine;
        }

        public void SendHit(Action<RaycastHit, VRRig> hitHandler)
        {
            bool trigger = isLeft ? EasyInputs.GetTriggerButtonDown(EasyHand.LeftHand) : EasyInputs.GetTriggerButtonDown(EasyHand.RightHand);
            Transform handTran = isLeft ? GorillaLocomotion.Player.Instance.leftHandTransform : GorillaLocomotion.Player.Instance.rightHandTransform;

            GameObject sphrObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            UnityEngine.Object.Destroy(sphrObj.GetComponent<Collider>());
            UnityEngine.Object.Destroy(sphrObj.GetComponent<Rigidbody>());
            Material sphrMat = sphrObj.GetComponent<Renderer>().material;
            sphrMat.SetFloat("_Glossiness", 0);
            sphrMat.SetFloat("_Metallic", 0);
            sphrMat.color = sphereUnpressed;
            sphrObj.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

            LineRenderer lr = null;

            if (useLine)
            {
                GameObject lrObj = new GameObject();
                lr = lrObj.AddComponent<LineRenderer>();
                lr.useWorldSpace = true;
                lr.startWidth = 0.02f;
                lr.endWidth = 0.02f;
                lr.material = baseMat;
                lr.startColor = lineColor;
                lr.endColor = lineColor;
            }

            GameObject.Destroy(lr.gameObject, Time.deltaTime);
            GameObject.Destroy(sphrObj, Time.deltaTime);

            if (isLeft ? EasyInputs.GetGripButtonDown(EasyHand.LeftHand) : EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                Physics.Raycast(handTran.position, -handTran.up, out var hit, float.PositiveInfinity, ~layerMask);
                Vector3 fixedPosition = hit.point;

                if (gunType == GunType.Lock)
                {
                    if (lockedRig == null)
                        fixedPosition = hit.point;
                    else
                        fixedPosition = lockedRig.transform.position + new Vector3(0, 1.5f, 0);
                }

                sphrObj.transform.position = fixedPosition;

                if (useLine)
                {
                    lr.SetPositions(new Vector3[]
                    {
                        handTran.position,
                        sphrObj.transform.position
                    });
                }


                if (trigger)
                {
                    sphrMat.color = spherePress;
                    VRRig maybeRig = hit.collider.GetComponentInParent<VRRig>();

                    if (gunType == GunType.Lock)
                    {
                        if (maybeRig != null)
                        {
                            if (lockedRig == null)
                            {
                                lockedRig = maybeRig;
                            }
                            else
                            {

                            }
                        }
                    }

                    VRRig possibleRig = gunType == GunType.Lock ? lockedRig : maybeRig;

                    if (useCooldown)
                    {
                        if (!cooldown)
                        {
                            cooldown = true;

                            hitHandler(hit, possibleRig);
                        }
                    }
                    else
                    {
                        hitHandler(hit, possibleRig);
                    }
                }
                else
                {
                    if (lockedRig != null)
                        lockedRig = null;

                    if (useCooldown)
                    {
                        if (!trigger && cooldown)
                        {
                            cooldown = false;
                        }
                    }
                }
            }
        }
    }
}
