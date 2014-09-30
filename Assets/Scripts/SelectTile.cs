using UnityEngine;
using System.Collections;

public class SelectTile : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit)){
				if (hit.collider != null){
					if(hit.collider.transform.tag.Equals("Tile")){
						if (GameObject.FindGameObjectWithTag("Selected")){
							GameObject old = GameObject.FindGameObjectWithTag("Selected");
							old.transform.tag="Tile";
							Debug.Log("UNSELECT");
						}
						hit.collider.transform.tag = "Selected";
						Debug.Log("SELECT");

					}
					else if(hit.collider.transform.tag.Equals("Selected")){
						hit.collider.transform.tag = "Tile";
						Debug.Log("UNSELECT");
					}
				}
			}
		}
	}
}
