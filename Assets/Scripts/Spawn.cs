using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject enemy;
    public int waves;
    public int enemyPerWave;
    public float waveTime;
    public float PrepareTime;
    private float LastWave = 0;

	void Start () {
        LastWave = waveTime - PrepareTime;
	}
	
	void Update () {
		
	}

    void StartWave()
    {
        for(int i = 0; i <= enemyPerWave; i++)
        {
            GameObject newEnemy = Instantiate(enemy, gameObject.transform.position, new Quaternion());

        }
    }
}
