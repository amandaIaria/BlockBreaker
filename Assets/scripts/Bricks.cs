using UnityEngine;
using System.Collections;

public class Bricks : MonoBehaviour {
	private int timesHit;
	private LevelManager levelManager;
	
	public Sprite[] hitSprites;
	
	// Use this for initialization
	void Start () {
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	void OnCollisionExit2D(Collision2D hit){
		timesHit++;
		int maxHits = hitSprites.Length +1;
		if(timesHit >= maxHits){
			Destroy (gameObject);
		}
		else{
			LoadSprites();
		}
	}
	// TODO remove this methode
	
	void SimulateWin(){
		levelManager.LoadNextLevel();
	}
	void LoadSprites(){
		int spriteIndex = timesHit -1;
		if(hitSprites[spriteIndex]){
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
	}
}
