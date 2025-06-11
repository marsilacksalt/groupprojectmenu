using Photon.Pun;
using System;
using UnityEngine;
using static IIDKQuest.Menu.Main;
using static IIDKQuest.Settings;
using static IIDKQuest.Mods.SettingsMods;

namespace IIDKQuest.Classes
{

    [MelonLoader.RegisterTypeInIl2Cpp]
    public class Button : MonoBehaviour
	{
		public Button(IntPtr ptr ) : base(ptr) { }
		public string relatedText;

		public static float buttonCooldown = 0f;
		
		public void OnTriggerEnter(Collider collider)
		{
			if (Time.time > buttonCooldown && collider == buttonCollider && menu != null)
			{
                buttonCooldown = Time.time + 0.2f;
                GorillaTagger.Instance.StartVibration(rightHanded, GorillaTagger.Instance.tagHapticStrength / 2f, GorillaTagger.Instance.tagHapticDuration / 2f);
				if (changebuttonS == 0f)
				{
                    GorillaTagger.Instance.offlineVRRig.PlayHandTap(31, rightHanded, 0.4f);
                }
                if (changebuttonS == 1f)
                {
                    GorillaTagger.Instance.offlineVRRig.PlayHandTap(39, rightHanded, 0.4f);
                }
                if (changebuttonS == 2f)
                {
                    GorillaTagger.Instance.offlineVRRig.PlayHandTap(29, rightHanded, 0.4f);
                }
                if (changebuttonS == 3f)
                {
                    GorillaTagger.Instance.offlineVRRig.PlayHandTap(49, rightHanded, 0.4f);
                }
                if (changebuttonS == 4f)
                {
                    GorillaTagger.Instance.offlineVRRig.PlayHandTap(54, rightHanded, 0.4f);
                }
                if (changebuttonS == 5f)
                {
                    GorillaTagger.Instance.offlineVRRig.PlayHandTap(8, rightHanded, 0.4f);
                }
                if (changebuttonS == 6f)
                {
                    GorillaTagger.Instance.offlineVRRig.PlayHandTap(18, rightHanded, 0.4f);
                }
                Toggle(this.relatedText);
            }
		}
	}
}
