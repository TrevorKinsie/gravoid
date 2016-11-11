using UnityEngine;
using System.Collections;

public class gravity_reverse : MonoBehaviour {

	public bool moveSwitch = true; //when true ship has a force applied to the right, false means it is has a force applied to the left
	public int multiplier = 1; //changes how much the gravity affects the scene
	//private Vector3 upper = new Vector3 (0, 0, 290); //upper limit of rotation of boat, will rotate up when it is going up
	//private Vector3 lower = new Vector3 (0, 0, 250); //lower limit of rotation of boat, will rotate down when it is going down

	public float thrust;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {

	}

	void onEnable(){
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		moveShip ();
		rotateBoat (); //for rotating the boat
		gravReverse (); //for reversing gravity on keypress
                        //collision_ground();
	}

	void moveShip(){
		rb.AddForce (transform.up * thrust);
	}

    void gravReverse() {
        if (Input.GetKeyDown("space")){//|| (Input.GetTouch(0).phase == TouchPhase.Began && Input.touchCount > 0)) {
			print ("space key was pressed");
			if (moveSwitch == true) {
				//Physics.gravity = new Vector3 (0, 9.8f * multiplier, 0);

				moveSwitch = false;
			} else if (moveSwitch == false) {
				//Physics.gravity = new Vector3 (0, -9.8f * multiplier, 0);
				moveSwitch = true;
			}
		}
	}

	void rotateBoat(){
		if (moveSwitch == true && Vector3.Distance(transform.eulerAngles, new Vector3(0,0,270)) > 0.1f) {
			transform.Rotate (Vector3.back);
			//Debug.Log ("right");
		}
		if (moveSwitch == false && Vector3.Distance(transform.eulerAngles, new Vector3(0,0,90)) > 0.1f) {
			transform.Rotate (Vector3.forward);
			//Debug.Log ("left");
		}

	}

	void OnCollisionEnter(Collision coll){
		Debug.Log ("bang");

	}
    
}
