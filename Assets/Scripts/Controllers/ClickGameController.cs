using Agate.MVC.Base;
using BeatThemAll.Boot;
using BeatThemAll.Message;
using BeatThemAll.Module.SaveData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BeatThemAll.Module.ClickGame {
    public class ClickGameController : ObjectController<ClickGameController, ClickGameModel, IClickGameModel, ClickGameView>
    {
        private SaveDataController _saveData;
        private void OnClickEarnCoin()
        {
            _model.AddCoin();
            Publish<UpdateCoinMessage>(new UpdateCoinMessage(_model.Coin));

        }

        private void OnClickSpendCoin()
        {
            _model.UpgradeCoinPerClick();
            Publish<UpgradeCoinPerClickMessage>(new UpgradeCoinPerClickMessage(_model.Coin, _model.UpgradePrice, _model.CoinPerClick));

        }

        private void OnClickBack()
        {
            SceneLoader.Instance.LoadScene("Home");
        }

        public override void SetView(ClickGameView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnClickEarnCoin, OnClickSpendCoin, OnClickBack);
        }
        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
            _model.SetCoin(_saveData.Model.Coin);
            _model.SetCoinPerClick(_saveData.Model.CoinPerClick);
            _model.SetUpgradePrice(_saveData.Model.UpgradePrice);
        }
    }
}


