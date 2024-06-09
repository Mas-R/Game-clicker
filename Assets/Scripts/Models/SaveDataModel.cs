using Agate.MVC.Base;
using BeatThemAll.Module.ClickGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BeatThemAll.Module.SaveData
{
    public class SaveDataModel : BaseModel, ISaveDataModel
    {
        public int Coin { get; private set; }
        public int UpgradePrice { get; private set; }
        public int CoinPerClick { get; private set; }


        public void SetCoinData(int coin)
        {
            Coin = coin;
            SetDataAsDirty();
        }

        public void SetCoinPerClick(int coin)
        {
            CoinPerClick = coin;
            SetDataAsDirty();
        }
        public void SetUpgradePrice(int coin)
        {
            UpgradePrice = coin;
            SetDataAsDirty();
        }
    }
}

