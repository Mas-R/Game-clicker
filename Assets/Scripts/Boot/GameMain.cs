using Agate.MVC.Base;
using Agate.MVC.Core;
using BeatThemAll.Module.SaveData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BeatThemAll.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {
        protected override IConnector[] GetConnectors()
        {
            return null;
        }

        protected override IController[] GetDependencies()
        {
            return new IController[]{
                new SaveDataController()
            };
        }

        protected override IEnumerator StartInit()
        {
            yield return null;
        }
    }
}


