using UnityEngine;
using System.Collections;

public class MoveObjectToWayPointTest : MonoBehaviour {

	//public Transform target1;
	//public Transform target2;
	public Transform [] waypoints ;
	public float speed = 5.0f; //move speed
	//bool madeit = false;
	// Use this for initialization
	private Transform currentWP;
	private int WPcounter = 0;
	//private Transform[] act_waypoints;
	void Start () {
		//I could modify the position of the waypoints to be moved a little: x direction range(-3,3) z direction(-3,3)

		currentWP = waypoints [WPcounter];
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("Hello");
		if (currentWP.position == transform.position) { // The object has reached the current waypoint
			//Change to the next waypoint
			if(WPcounter < waypoints.Length-1)
			{
				WPcounter++;
				currentWP = waypoints[WPcounter];

			}
		}
		else{
			transform.position = Vector3.MoveTowards (transform.position, currentWP.position, speed * Time.deltaTime);
		}

	}
}
