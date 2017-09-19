using UnityEngine;
using System.Collections;

public class Bricks : MonoBehaviour {
	private int timesHit;
	private LevelManager levelManager;
	private bool isBreakable;
	
	public static int breakableCount = 0;
	public AudioClip crack;
	public Sprite[] hitSprites;
	
	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
		//keeping track of breakable 
		if(isBreakable){
			breakableCount++;
		}
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	void OnCollisionExit2D(Collision2D hit){
		float volume = 0.10f;
		AudioSource.PlayClipAtPoint(crack, transform.position, volume);
		if(isBreakable){
			handleHits();
		}
	}
	void handleHits(){
		timesHit++;
		int maxHits = hitSprites.Length +1;
		if(timesHit >= maxHits){
			breakableCount--;
			levelManager.BrickDestroyed();
			Destroy (gameObject);
		}
		else{
			LoadSprites();
		}
	}
	void LoadSprites(){
		int spriteIndex = timesHit -1;
		if(hitSprites[spriteIndex]){
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
	}
}
