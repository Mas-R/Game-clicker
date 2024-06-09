using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BeatThemAll.Module.SaveData
{
    public interface ISaveDataModel : IBaseModel
    {
        public int Coin { get; }
        public int UpgradePrice { get; }
        public int CoinPerClick { get; }
    }
}

