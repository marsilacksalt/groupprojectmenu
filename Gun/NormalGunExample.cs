using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace IIDKQuest
{
    public class NormalGunExample
    {
        public static EasyGun gun;

        public static void ExecuteMe() // run this on update
        {
            if (gun == null)
            {
                gun = new EasyGun(GunType.Lock);
            }

            gun.SendHit(HandleGun);
        }

        public static void HandleGun(RaycastHit hit, VRRig rig) // the RayCastHit and VRRig params are needed
        {
            // since this is a Normal gun, the rig param will not be null when it hits a Player.

        }
    }
}
