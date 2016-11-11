using UnityEngine;
using System.Collections;

public class asteroid_spawner : MonoBehaviour {
    public GameObject asteroid = new GameObject();
    public GameObject score_obj = new GameObject();
    public float spawnTime;
	public static float globalSpeed = 0.01f;

    // Use this for initialization
    void Start () {
        InvokeRepeating("randAsteroid", 0.0f, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		increaseSpeed ();
	}

	void increaseSpeed(){
		
		globalSpeed += 0.00001f;
	}

    void randAsteroid()
    {
        System.Random rnd = new System.Random();
        int randInt = rnd.Next(5);
        if (randInt == 0)
        {
            spawnAsteroid(-2.0f, -1.0f, 0.0f, 1.0f, 2.0f);
        }
        else if(randInt == 1)
        {
            spawnAsteroid(-2.0f, -1.0f, 0.0f, 2.0f, 1.0f);
        }
        else if(randInt == 2)
        {
            spawnAsteroid(-2.0f, -1.0f, 1.0f, 2.0f, 0.0f);
        }
        else if (randInt == 3)
        {
            spawnAsteroid(-2.0f, 0.0f, 1.0f, 2.0f, -1.0f);
        }
        else if (randInt == 4)
        {
            spawnAsteroid(-1.0f, 0.0f, 1.0f, 2.0f, -2.0f);
        }
    }

    void spawnAsteroid(float x,float y,float z,float a, float scoreup)
    {
        Vector3 spawnPos = transform.position;
        GameObject.Instantiate(asteroid, spawnPos + new Vector3(x, 0, 0), transform.rotation);
        GameObject.Instantiate(asteroid, spawnPos + new Vector3(y, 0, 0), transform.rotation);
        GameObject.Instantiate(asteroid, spawnPos + new Vector3(z, 0, 0), transform.rotation);
        GameObject.Instantiate(asteroid, spawnPos + new Vector3(a, 0, 0), transform.rotation);
        GameObject.Instantiate(score_obj, spawnPos + new Vector3(scoreup, 0, 0), transform.rotation);
    }
}
