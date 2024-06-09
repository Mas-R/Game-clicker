using Agate.MVC.Base;
using BeatThemAll.Message;
using BeatThemAll.Module.SaveData;
using BeatThemAll.Module.Soundfx;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BeatThemAll.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        private SaveDataController _saveData;
        private SoundfxController _soundfx;

        public void OnUpdateCoin(UpdateCoinMessage message)
        {
            _saveData.OnUpdateCoin(message.Coin);
            _soundfx.OnUpdateCoin();
        }
        public void OnUpgradeCoinPerClick(UpgradeCoinPerClickMessage message)
        {
            _saveData.OnUpgradeCoinPerClick(message.Coin, message.CoinPerClick, message.UpgradePrice);
            _soundfx.OnUpdateCoin();

        }
        protected override void Connect()
        {
            Subscribe<UpdateCoinMessage>(OnUpdateCoin);
            Subscribe<UpgradeCoinPerClickMessage>(OnUpgradeCoinPerClick);

        }

        protected override void Disconnect()
        {
            Unsubscribe<UpdateCoinMessage>(OnUpdateCoin);
            Unsubscribe<UpgradeCoinPerClickMessage>(OnUpgradeCoinPerClick);

        }
    }
}