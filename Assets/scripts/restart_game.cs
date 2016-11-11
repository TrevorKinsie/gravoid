using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class restart_game : MonoBehaviour {
    	
	
   

	public void reload_scene(string gamename){
        SceneManager.LoadScene(gamename);
    }
}
