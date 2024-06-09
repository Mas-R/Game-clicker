using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BeatThemAll.Module.ClickGame
{
    public interface IClickGameModel : IBaseModel
    {
        public int Coin { get; }
        public int UpgradePrice { get; }
        public int CoinPerClick { get; }


    }
}
