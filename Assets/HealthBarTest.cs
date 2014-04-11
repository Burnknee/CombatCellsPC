using UnityEngine;
using System.Collections;

public class HealthBarTest : MonoBehaviour {

	public Transform target; //The enemy it attaches to.
	public Texture itemTexture;
	//private Vector3 new_pos;
	//private Rect lol 
	//private Rect rectangle= new Rect
	void OnGUI () {
		Vector3 targetPos;	
		targetPos = Camera.main.WorldToScreenPoint (transform.position);
		//GUI.Box (new Rect (targetPos.x-20,Screen.height-targetPos.y-65,100,20), itemTexture);
		GUI.Label (new Rect (targetPos.x-20,Screen.height-targetPos.y-65,50,50), itemTexture);
		//GUI.DrawTexture (new Rect (targetPos.x-20, Screen.height-targetPos.y-65, 40, 80), itemTexture, ScaleMode.ScaleToFit, true, 10.0f);
	}
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () { 

	}
}
