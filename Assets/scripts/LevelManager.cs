using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public void LoadLevel(string name){
		Bricks.breakableCount = 0;
		Application.LoadLevel(name);
	}
	public void QuitRequest(){
		Application.Quit();
	}
	public void LoadNextLevel(){
		Bricks.breakableCount = 0;
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	public void BrickDestroyed(){
		if( Bricks.breakableCount <= 0 ){
			LoadNextLevel();
		}
	}
}