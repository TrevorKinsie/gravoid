using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class start_game : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void load_scene(string gamename)
    {
        SceneManager.LoadScene(gamename);
        Debug.Log("hey");
    }

}
