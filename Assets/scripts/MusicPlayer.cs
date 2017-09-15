using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;
	void Awake(){
		Debug.Log("music player awake" + GetInstanceID());
	}
	void Start(){
		Debug.Log("music player start" + GetInstanceID());
		if( instance != null ){
			Destroy(gameObject);
			print ("Destroyed Music player");
		}
		else {
			instance = this; //this is true?
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}	
	//Explanation of the music bug
	//
}
