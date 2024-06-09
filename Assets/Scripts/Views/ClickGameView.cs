using Agate.MVC.Base;
using BeatThemAll.Module.ClickGame;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BeatThemAll.Module.ClickGame
{
    public class ClickGameView : ObjectView<IClickGameModel>
    {
        [SerializeField]
        private TextMeshProUGUI _coinText;
        [SerializeField]
        private Button _earnCoinButton;
        [SerializeField]
        private Button _spendCoinButton;
        [SerializeField]
        private TextMeshProUGUI _spendCoinText;
        [SerializeField]
        private Button _backButton;

        public void SetCallbacks(UnityAction onClickEarnCoin, UnityAction onClickSpendCoin, UnityAction onClickBack)
        {
            _earnCoinButton.onClick.RemoveAllListeners();
            _spendCoinButton.onClick.RemoveAllListeners();
            _backButton.onClick.RemoveAllListeners();
            _earnCoinButton.onClick.AddListener(onClickEarnCoin);
            _spendCoinButton.onClick.AddListener(onClickSpendCoin);
            _backButton.onClick.AddListener(onClickBack);
        }

        protected override void InitRenderModel(IClickGameModel model)
        {
            _coinText.text = $"Coin: {model.Coin.ToString()}";
            _spendCoinText.text = $"{model.UpgradePrice.ToString()} Coin \n Upgrade Click";
        }

        protected override void UpdateRenderModel(IClickGameModel model)
        {
            _coinText.text = $"Coin: {model.Coin.ToString()}";
            _spendCoinText.text = $"{model.UpgradePrice.ToString()} Coin \n Upgrade Click";

        }


    }
}
