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
    public float enemyDelay;

    private float lastSpawn;

	void Start () {
        LastWave = -waveTime + PrepareTime;
        lastSpawn = 0 - enemyDelay;
	}
	
	void FixedUpdate () {
        if (Time.time - LastWave >= waveTime)
        {
            for (int i = 0; i <= enemyPerWave; i++)
            {
                bool s = false;

                while (!s)
                {
                    if (Time.time - lastSpawn >= enemyDelay)
                    {
                        s = true;
                    }
                    Debug.Log("loop");
                }

                spawn();
                lastSpawn = Time.time;
            }
            LastWave = Time.time;
        }
	}

    private void spawn() {
        GameObject newEnemy = Instantiate(enemy, gameObject.transform.position, enemy.transform.rotation);
        newEnemy.GetComponent<EnemyMove>().speed += Random.Range(-0.1f, 0.1f);
        newEnemy.SetActive(true);
    }
}
