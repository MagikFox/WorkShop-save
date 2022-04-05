using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : item
{
    protected override void Comportement()
    {
        Inventory.Instance.addCoin();
        this.UIManager.SetCoinText(Inventory.Instance.coin);
        Destroy(gameObject);
    }
}
