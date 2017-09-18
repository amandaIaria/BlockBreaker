using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;
	//this is a singleton or a persitance singleton pattern. 
	void Awake(){
		if( instance != null ){
			Destroy(gameObject);
		}
		else {
			instance = this; //this is true?
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}	
	//Explanation of the music bug
	//oRIGINALLY the script was in the start method, however start works on each time that level starts up. WHile Awake plays only once and stays instatations
}
