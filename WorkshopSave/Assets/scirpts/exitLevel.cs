using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Inventory.Instance.SaveCoin();
        Inventory.Instance.save();
        SceneManager.LoadScene("Menu");

    }
}
