using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class getSpeed : MonoBehaviour {

    private Text txt;
    private float speed;


    // Use this for initialization
    void OnEnable()
    {
        txt = GetComponent<Text>();
        txt.text = "0.0";
    }

    // Update is called once per frame
    void FixedUpdate () {
	}
    

}
