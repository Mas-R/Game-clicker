using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BeatThemAll.Message
{
    public struct UpgradeCoinPerClickMessage
    {
        public int Coin { get; private set; }
        public int UpgradePrice { get; private set; }
        public int CoinPerClick { get; private set; }
        public UpgradeCoinPerClickMessage(int coin, int upgradePrice, int coinPerClick)
        {
            Coin = coin;
            UpgradePrice = upgradePrice;
            CoinPerClick = coinPerClick;

        }
    }
}
