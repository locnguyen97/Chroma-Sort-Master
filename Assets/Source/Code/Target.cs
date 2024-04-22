using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public void SetSpr(Sprite spr)
    {
        GetComponent<SpriteRenderer>().sprite = spr;
        GetComponent<SpriteRenderer>().color = Color.white;
        GetComponent<Collider2D>().enabled = false;
    }
}
