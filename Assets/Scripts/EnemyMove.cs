using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    private List<Transform> path = new List<Transform>();
    public GameObject Path;
    private int current = 0;
    private Transform next;
    public float speed;
    private float Randomness;


    void Start()
    {
        foreach (Transform child in Path.transform)
        {
            path.Add(child);
        }
        transform.position = path[0].position;
        next = path[0];
    }

    void FixedUpdate () {

    if(transform.position == next.position && current < path.Count -1)
        {
            current++;
            EstablishNext();
        }
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, next.position, step);

    }

    void EstablishNext()
    {
        int Xchange = 1;
        if (path[current - 1].position.x <= path[current].position.x){
            Xchange = -1;
        }

        int Ychange = 1;
        if (path[current - 1].position.y <= path[current].position.y)
        {
            Ychange = -1;
        }

        next = path[current];
        next.position += new Vector3(Xchange * Random.Range(0, Random.Range(0, Randomness)), Ychange * Random.Range(0, Random.Range(0, Randomness)));

    }
}
