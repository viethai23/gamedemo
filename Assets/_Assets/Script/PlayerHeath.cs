using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeath : Heath
{
    protected override void Die()
    {
        base.Die();
        Debug.Log("Player died");
    }
}
