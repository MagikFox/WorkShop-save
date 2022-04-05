using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pics : item
{
    private Vector2 Spawn;
    public Transform Player;

    private void Start()
    {
        Spawn = Player.transform.position;
    }
    protected override void Comportement()
    {
        Respawn();
        Inventory.Instance.addaDeath();
        this.UIManager.SetDeathText(Inventory.Instance.Death);
    }
    public void Respawn()
    {
        Player.position = Spawn;
    }
}
