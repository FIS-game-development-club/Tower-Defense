using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour {

    SpriteRenderer sprite;
    public GameObject empty;

    private void Start()
    {
        sprite = empty.GetComponent<SpriteRenderer>();
    }

    public void Selected()
    {
        sprite.color.grays
    }

    public void DeSelected()
    {

    }
}
