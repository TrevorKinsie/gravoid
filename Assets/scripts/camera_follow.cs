using UnityEngine;
using System.Collections;

public class camera_follow : MonoBehaviour {

	public GameObject player;
    private float speed;
	public float cameraHeight;
    public float currentVelocity;

	void OnEnable()
    {
        Vector3 pos = player.transform.position;
        pos.z -= cameraHeight;// * (speed/2 + 1);
        pos.y += 2.0f;
        transform.position = pos;

    }

    // Update is called once per frame
    void Update () {
        get_speed();
		follow_player ();
	}

	void follow_player(){
        
		
	}

    void get_speed()
    {
        //speed = Mathf.SmoothDamp(speed, rb.velocity.magnitude, ref currentVelocity, 0.3f);
    }
}
