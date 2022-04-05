using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{

    [SerializeField] TMP_Text CoinText;
    [SerializeField] TMP_Text DeathText;

    public void SetCoinText(int _coinNumber)
    {
        CoinText.text = "Coins: " + _coinNumber.ToString();
    }
    public void SetDeathText(int _DeathNumber)
    {
        DeathText.text = "Death: " + _DeathNumber.ToString(); 
    }
    
}
