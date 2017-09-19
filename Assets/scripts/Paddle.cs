using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	
	public bool autoPlay = false;
	public float minX, maxX;
	
	private Ball ball;
	
	void Start(){
		ball = GameObject.FindObjectOfType<Ball>();
	}
	
	void Update () {
		if(!autoPlay){
			MoveWithMouse();
		}
		else{
			AutoPlay();
		}
	}
	
	void MoveWithMouse(){
		float mousePosInBlocks;
		Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
		mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		paddlePos.x = Mathf.Clamp (mousePosInBlocks, minX, maxX);
		this.transform.position = paddlePos;
	}
	
	void AutoPlay(){
		Vector3 ballPos = ball.transform.position;
		Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
		paddlePos.x = Mathf.Clamp (ballPos.x, minX, maxX);
		this.transform.position = paddlePos;
	}
}

//why is the world size 16, is it because of the aspect ratio of 4:3, which is 800*600. ONe reason to have this set is so the mouse does not go off screen.
