using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MaxCoinsDisp : MonoBehaviour
{
    public TMP_Text DispMaxCoin;
    public int MaxCoins;

    public void maxCoinsDisp(Inventory Inventory)
    {
        MaxCoins = Inventory.Level1 + Inventory.Level2 + Inventory.Level3;
    }

    // Update is called once per frame
    void Update()
    {
        maxCoinsDisp(Inventory.Instance);
        Debug.Log(MaxCoins);
        DispMaxCoin.text = MaxCoins.ToString();
    }

    private void Awake()
    {
        maxCoinsDisp(Inventory.Instance);
        DispMaxCoin.text = MaxCoins.ToString();
    }
}
