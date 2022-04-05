using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockLevel : MonoBehaviour
{
    public Button[] LockedLevels;
    int Level1;
    int Level2;
    public int[] CoinPerLevel;

    public void Coin(Inventory Inventory)
    {
        
        Level1 = Inventory.Level1;
        Level2 = Inventory.Level2;
        
    }
    private void Awake()
    {
        Coin(Inventory.Instance);
        if(Level1 >= CoinPerLevel[0])
            LockedLevels[0].interactable = true;
        else
            LockedLevels[0].interactable = false;
        Debug.Log("level1" +Level1);
        if (Level2 >= CoinPerLevel[1])
            LockedLevels[1].interactable = true;
        else
            LockedLevels[1].interactable = false; 
        Debug.Log("Level2" + Level2);
    }

}
