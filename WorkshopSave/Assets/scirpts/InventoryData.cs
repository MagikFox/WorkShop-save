using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class InventoryData
{
    public int level;
    public int coin;
    public int Death;
    public int TotalCoin;
    public int Level1;
    public int Level2;
    public int Level3;

    public InventoryData(Inventory Inventory)
    {
        coin = Inventory.coin;
        Death = Inventory.Death;
        TotalCoin = Inventory.MaxCoins;
        Level1 = Inventory.Level1;
        Level2 = Inventory.Level2;
        Level3 = Inventory.Level3;
    }

}
