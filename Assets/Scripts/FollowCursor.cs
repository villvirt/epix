using UnityEngine;
using System.Collections;

public class FollowCursor : MonoBehaviour {
	private float NorthBound=11;
	private float WestBound=0;
	private float SouthBound=-2;
	private float EastBound=12;
	private float FloorLevel=3;
	private float CeilingLevel=10;
	private float x;
	private float z;
	private float y;

	// Use this for initialization
	void Start () {
		x=transform.position.x;
		z=transform.position.z;
		y=transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetAxis("Mouse ScrollWheel") < 0) // back
		{
			if (y<CeilingLevel) {
				transform.position = new Vector3(x, transform.position.y+0.1f, z);
				y=transform.position.y;
			}
		}

		if (Input.GetAxis("Mouse ScrollWheel") > 0) // forward
		{
			if (y>FloorLevel) {
				transform.position = new Vector3(x, transform.position.y-0.1f, z);
				y=transform.position.y;
			}
		}

		if(Input.mousePosition.x>Screen.width-10){
			if(transform.position.x<EastBound){
				transform.position = new Vector3(x+0.1F,y,z);
				x=transform.position.x;
			}
		}
		if(Input.mousePosition.x<10){
			if(transform.position.x>WestBound){
				transform.position = new Vector3(x-0.1F,y,z);
				x=transform.position.x;
			}
		}

		if(Input.mousePosition.y>Screen.height-10){
			if(transform.position.z<NorthBound){
				transform.position = new Vector3(x,y,z+0.1F);
				z=transform.position.z;
			}
		}
		if(Input.mousePosition.y<10){
			if(transform.position.z>SouthBound){
				transform.position = new Vector3(x,y,z-0.1F);
				z=transform.position.z;
			}
		}
	}
}
