using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinLevel : MonoBehaviour
{
    public int LevelNumber;
    public TMP_Text CoinText;
    private int coin;

    private void GetCoin()
    {
        if (LevelNumber == 1)
            coin = Inventory.Instance.Level1;
        if (LevelNumber == 2)
            coin = Inventory.Instance.Level2;
        if(LevelNumber == 3)
            coin = Inventory.Instance.Level3;
    }

    private void Update()
    {
        GetCoin();
        CoinText.text = "Coins : " + coin.ToString();
    }
}
