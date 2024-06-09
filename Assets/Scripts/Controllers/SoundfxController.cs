using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BeatThemAll.Module.Soundfx
{
    public class SoundfxController : BaseController<SoundfxController>
    {
        public void OnUpdateCoin()
        {
            Debug.Log("Play Sound fx");
        }
    }
}

