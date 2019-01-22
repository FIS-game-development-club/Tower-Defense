using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject enemy;
    public int waves;
    public int enemyPerWave;
    public float waveTime;
    public float PrepareTime;
    private float LastWave;

    void Start () {
        LastWave = -waveTime + PrepareTime;
	}
	
	void FixedUpdate () {
        if (Time.time - LastWave >= waveTime)
        {
            for (int i = 0; i <= enemyPerWave; i++)
            {
                spawn();
            }

            LastWave = Time.time;
        }
	}

    private GameObject spawn() {
        GameObject newEnemy = Instantiate(enemy, gameObject.transform.position, enemy.transform.rotation);
        newEnemy.GetComponent<EnemyMove>().speed += Random.Range(0f, 1.5f);
        newEnemy.SetActive(true);
        return newEnemy;
    }
}
