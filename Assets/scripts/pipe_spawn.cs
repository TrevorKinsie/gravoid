using UnityEngine;
using System.Collections;

public class pipe_spawn : MonoBehaviour {

	public GameObject pipe;
	public float randomGen;
	private float upperRand = -0.7f;
	private float lowerRand = -7.22f;
	private GameObject spawner;

	// Use this for initialization
	void Start () {
		spawner = this.gameObject;
		StartCoroutine (pipe_spawning ());
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			
		}
	}

	IEnumerator pipe_spawning(){
		while (true) {
			randomGen = getRandom ();	
			print (randomGen);
			GameObject pipe1 = (GameObject)Instantiate (pipe, spawner.transform.position - new Vector3 (0, randomGen), spawner.transform.rotation);
			pipe1.transform.localScale = new Vector3 (1f, 6.5f, 1f);
			GameObject pipe2 = (GameObject)Instantiate (pipe, spawner.transform.position - new Vector3 (0, randomGen + 6.5f + 3f), spawner.transform.rotation);
			pipe2.transform.localScale = new Vector3 (1f, 6.5f, 1f);
			yield return new WaitForSeconds (3);
		}
	}

	public float getRandom(){
		float randNum = Random.Range(lowerRand, upperRand);
		return randNum;
	}
}
