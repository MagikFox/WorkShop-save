using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class item : MonoBehaviour
{
    protected UiManager UIManager;
    protected abstract void Comportement();
    private void Awake()
    {
        UIManager = FindObjectOfType<UiManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Comportement();
        }
    }
}
