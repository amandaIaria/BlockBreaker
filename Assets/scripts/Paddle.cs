using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	
	private float mousePosInBlocks;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
		mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		paddlePos.x = Mathf.Clamp (mousePosInBlocks, 0.5f ,15.5f);
		this.transform.position = paddlePos;
	}
}

//why is the world size 16, is it because of the aspect ratio of 4:3, which is 800*600. ONe reason to have this set is so the mouse does not go off screen.
