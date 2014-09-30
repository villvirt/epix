using UnityEngine;
using System.Collections;

public class FollowCursor : MonoBehaviour {
	private float NorthBound=11;
	private float WestBound=0;
	private float SouthBound=-2;
	private float EastBound=12;
	private float x;
	private float z;

	// Use this for initialization
	void Start () {
		x=transform.position.x;
		z=transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.mousePosition.x>Screen.width-10){
			if(transform.position.x<EastBound){
				transform.position = new Vector3(x+0.1F,3F,z);
				x=transform.position.x;
			}
		}
		if(Input.mousePosition.x<10){
			if(transform.position.x>WestBound){
				transform.position = new Vector3(x-0.1F,3F,z);
				x=transform.position.x;
			}
		}

		if(Input.mousePosition.y>Screen.height-10){
			if(transform.position.z<NorthBound){
				transform.position = new Vector3(x,3F,z+0.1F);
				z=transform.position.z;
			}
		}
		if(Input.mousePosition.y<10){
			if(transform.position.z>SouthBound){
				transform.position = new Vector3(x,3F,z-0.1F);
				z=transform.position.z;
			}
		}


	}
}
