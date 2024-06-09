using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BeatThemAll.Module.ClickGame
{
    public class ClickGameModel : BaseModel, IClickGameModel
    {
        public int Coin { get; private set; }
        public int UpgradePrice {  get; private set; }
        public int CoinPerClick { get; private set; }

        public void SetCoin(int coin)
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

        public void AddCoin()
        {
            Coin = Coin + CoinPerClick;
            SetDataAsDirty();
        }

        public void UpgradeCoinPerClick()
        {
            if(Coin >= UpgradePrice)
            {
                Coin = Coin-UpgradePrice;
                UpgradePrice = (int)(UpgradePrice * 1.5f);
                CoinPerClick++;
            }else
            {
                Debug.Log("not enough coins");
            }
            SetDataAsDirty();
        }
    }
}