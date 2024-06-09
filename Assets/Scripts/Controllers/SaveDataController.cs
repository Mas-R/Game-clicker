using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BeatThemAll.Module.SaveData {
    public class SaveDataController : DataController<SaveDataController, SaveDataModel, ISaveDataModel>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            LoadData();
        }
        private void SaveData()
        {
            PlayerPrefs.SetInt("Coin", _model.Coin);
            PlayerPrefs.SetInt("CoinPerClick",_model.CoinPerClick);
            PlayerPrefs.SetInt("UpgradePrice", _model.UpgradePrice);
            PlayerPrefs.Save();
        }

        private void LoadData()
        {
            if (!PlayerPrefs.HasKey("Coin"))
            {
                PlayerPrefs.SetInt("Coin",0);
            }
            if (!PlayerPrefs.HasKey("CoinPerClick"))
            {
                PlayerPrefs.SetInt("CoinPerClick", 1);
            }
            if (!PlayerPrefs.HasKey("UpgradePrice"))
            {
                PlayerPrefs.SetInt("UpgradePrice", 10);
            }

            int coin = PlayerPrefs.GetInt("Coin");
            int coinPerClick = PlayerPrefs.GetInt("CoinPerClick");
            int upgradePrice = PlayerPrefs.GetInt("UpgradePrice");

            _model.SetCoinData(coin);
            _model.SetCoinPerClick(coinPerClick);
            _model.SetUpgradePrice(upgradePrice);

            Debug.Log(_model.Coin);
            Debug.Log(_model.CoinPerClick);
            Debug.Log(_model.UpgradePrice);

        }
        public void OnUpdateCoin(int coin)
        {
            _model.SetCoinData(coin);
            SaveData();
        }
        public void OnUpgradeCoinPerClick(int coin, int coinPerClick, int upgradePrice)
        {
            _model.SetCoinData(coin);
            _model.SetCoinPerClick(coinPerClick);
            _model.SetUpgradePrice(upgradePrice);
            SaveData();
        }

    }
}


