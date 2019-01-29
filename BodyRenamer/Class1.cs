using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BodyRenamer
{
    [KSPAddon(KSPAddon.Startup.MainMenu, false)]
    public class Hello : MonoBehaviour
    {
        public string body_name = "seronimo waz here";
        private CelestialBody[] bodys;

        public void Start()
        {
            bodys = FindObjectsOfType(typeof(CelestialBody)) as CelestialBody[];

            foreach (CelestialBody body in bodys)
            {
                body.bodyDisplayName = body_name;
                body.bodyAdjectiveDisplayName = body_name;
            }
        }
    }
}
