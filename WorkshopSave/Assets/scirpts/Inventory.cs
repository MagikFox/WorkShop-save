using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;
    public int coin = 0;
    public int Level1 = 0;
    public int Level2 = 0;
    public int Level3 = 0;
    public int Death = 0;
    public int MaxCoins;
    public int LevelNumber;
    private string SceneName;

    private void LevelCheck()
    {
        SceneName = SceneManager.GetActiveScene().name;
        Debug.Log(SceneName);
        if (SceneName == "Level1")
            LevelNumber = 1;
        else if (SceneName == "Level2")
            LevelNumber = 2;
        else if (SceneName == "Level3")
            LevelNumber = 3;
    }

    private void Update()
    {
        LevelCheck();
    }


    private void Awake()
    {
        if (Instance)
        {
            Destroy(gameObject);
        }else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        load();
        coin = 0;
        
    }

    public int DisplayMaxCoins()
    {
        return MaxCoins;
    }
    public void addCoin()
    {
        coin++;
        //Debug.Log("Number of coins: " + coin.ToString());
    }

    public void addaDeath()
    {
        Death++;
        //Debug.Log("Number of deaths: " + Death.ToString());
    }

    

    public void save()
    {
        Save.saveStats(this);
    }
    public void load()
    {
        InventoryData InvData = Save.loadInventory();
        coin = InvData.coin;
        Death = InvData.Death;
        MaxCoins = InvData.TotalCoin;
        Level1 = InvData.Level1;
        Level2 = InvData.Level2;
        Level3 = InvData.Level3;
    }
    public void SaveCoin()
    {
        if(LevelNumber ==1)
        {
            Level1 = coin;
            Debug.Log("level1");
        }
        if(LevelNumber ==2)
        {
            Level2 = coin;
            Debug.Log("Level2");
        }
        if(LevelNumber==3)
        {
            Level3 = coin;
            Debug.Log("Level3");
        }
        Debug.Log("Level1 " + Level1 +" Level2 " + Level2 + "Level3 " + Level3);
        coin = 0;
    }

    public void reset()
    {
        Debug.Log("Reset");
        coin = 0;
        Level1 = 0;
        Level2 = 0;
        Level3 = 0;
        Death = 0;
        save();
        SceneManager.LoadScene("Menu");
    }
}
