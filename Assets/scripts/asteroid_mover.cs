using UnityEngine;
using System.Collections;

public class asteroid_mover : MonoBehaviour {

    private bool rotate = false;
	private float speed = 0.01f;

	// Use this for initialization
	void Start () {
        System.Random rnd = new System.Random();
        int randInt = rnd.Next(0,2);
        if (randInt == 1){
            rotate = false;
        } else
        {
            rotate = true;
        }
    }

    // Update is called once per frame
    void Update ()
    {
		transform.position -= new Vector3(0, speed * Time.timeSinceLevelLoad, 0);
        if (rotate)
        {
            transform.Rotate(Vector3.back * 1.0f);
        }
        else
        {
            transform.Rotate(Vector3.forward * 1.0f);
        }

    }
}
