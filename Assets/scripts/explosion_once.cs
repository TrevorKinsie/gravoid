using UnityEngine;
using System.Collections;

public class explosion_once : MonoBehaviour {
    
    private float lifetime = 3.0f;

    void OnEnable()
    {
        Destroy(gameObject, lifetime);
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
