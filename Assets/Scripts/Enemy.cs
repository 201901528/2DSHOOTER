using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp = 3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        --hp;
        Debug.Log(hp);
        if(hp < 1)
        {
            Destroy(this.gameObject);
        }

    }
   
}
