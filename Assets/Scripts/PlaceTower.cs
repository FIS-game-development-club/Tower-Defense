using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour {

    private List<GameObject> towers = new List<GameObject>();
    SpriteRenderer sprite;
    public GameObject empty;

    private void Start()
    {
        sprite = empty.GetComponent<SpriteRenderer>();
        foreach (Transform child in transform)
        {
            if(child.tag == "tower")
            {
                towers.Add(child.gameObject);
            }
        }

    }

    public void Selected()
    {
        Color tmp = sprite.color;
        tmp.a = 0.5f;
        sprite.color = tmp;
    }

    public void DeSelected()
    {
        Color tmp = sprite.color;
        tmp.a = 1f;
        sprite.color = tmp;
    }

    public void place(string type)
    {
        empty.SetActive(false);
        foreach(GameObject tower in towers)
        {
            if(tower.name == type)
            {
                tower.SetActive(true);
                break;
            }
        }

    }
}
