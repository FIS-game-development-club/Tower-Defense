using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    private List<Transform> path = new List<Transform>();
    public GameObject Path;
    private int current = 0;
    public float speed;


    void Start()
    {
        foreach (Transform child in Path.transform)
        {
            path.Add(child);
        }
        Debug.Log(path);
    }

    void FixedUpdate () {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, path[current].position, step);

        if(transform.position == path[current].position && current < path.Count -1)
        {
            current++;
        }
    }
}
