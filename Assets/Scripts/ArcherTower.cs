using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherTower : MonoBehaviour {

    public float Range;


	void  FixedUpdate () {
        GameObject value = CheckRange(Range);
        print(value);
        if (value != null){
            Vector3 before = transform.rotation.eulerAngles;
            transform.LookAt(value.transform, new Vector3(0, 1, 0));
            before.z = transform.rotation.eulerAngles.z;
            transform.eulerAngles = before;
        }
    }

    GameObject CheckRange(float r)
    { 
        List<GameObject> enemies = new List<GameObject>();
        List<float> distances = new List<float>();

        enemies.AddRange(GameObject.FindGameObjectsWithTag("enemy"));

        GameObject value = null;

        foreach (GameObject e in enemies)
        {
            distances.Add(Vector3.Distance(e.transform.position, transform.position));
        }

        distances.Sort();
        float furthest = distances[0];
        if (furthest <= r)
        {
            foreach (GameObject e in enemies)
            {
                float distance = Vector3.Distance(e.transform.position, transform.position);
                if (distance == furthest)
                {
                    value = e;
                    break;
                }
            }
        }

        enemies = null;
        return value;
    }
}