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
		if(Time.time - LastWave >= waveTime){
            StartWave();
            LastWave = Time.time;
        }
	}

    void StartWave()
    {
        for(int i = 0; i <= enemyPerWave; i++)
        {
            GameObject newEnemy = Instantiate(enemy, gameObject.transform.position, new Quaternion());
            newEnemy.SetActive(true);
        }
    }
}
