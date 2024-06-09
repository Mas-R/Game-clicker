using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BeatThemAll.Message {
    public struct UpdateCoinMessage 
    {
        public int Coin { get; private set; }

        public UpdateCoinMessage(int coin)
        {
            Coin = coin;
        }
    }
}


