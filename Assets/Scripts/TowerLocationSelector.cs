using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLocationSelector : MonoBehaviour {

    List<GameObject> places;
    private int active = 0;
    private int change = 0;

	void Start () {
        places = new List<GameObject>(GameObject.FindGameObjectsWithTag("TowerSpot"));
    }

    void FixedUpdate()
    {
        if (places.Count > 0)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                change = 1;
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                change = -1;
            }

            if (change != 0)
            {
                places[active].GetComponent<PlaceTower>().DeSelected();
                active += change;
                if (active <= 0)
                {
                    active = places.Count;
                }

                if (active >= places.Count)
                {
                    active = 0;
                }

                places[active].GetComponent<PlaceTower>().Selected();
                change = 0;
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                places[active].GetComponent<PlaceTower>().place("archer");
                places.RemoveAt(active);
                active = 0;
            }
        }
    }

}
