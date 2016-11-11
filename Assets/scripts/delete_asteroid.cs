using UnityEngine;
using System.Collections;

public class delete_asteroid : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("Collision");
        Destroy(coll.gameObject);
    }
}
