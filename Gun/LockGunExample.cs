using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace IIDKQuest
{
    public class LockGunExample
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
            if (rig != null)
            {
                // so since the GunType was set to lock, the rig param will be the locked rig (if there is one)
                // handle what to do with the locked rig here

            }
        }
    }
}
