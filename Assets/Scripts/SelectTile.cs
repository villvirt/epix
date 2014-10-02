using UnityEngine;
using System.Collections;

public class SelectTile : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		//prevent raycast if clicking GUI buttons
		if (GUIUtility.hotControl == 0) {
		

		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit)){
				if (hit.collider != null){
					if(hit.collider.transform.tag.Equals("Tile")){
						if (GameObject.FindGameObjectWithTag("Selected")){
							GameObject old = GameObject.FindGameObjectWithTag("Selected");
							old.transform.tag="Tile";
							old.renderer.material.color = Color.white;
							Debug.Log("UNSELECT");
						}
						hit.collider.transform.tag = "Selected";
						hit.collider.renderer.material.color = Color.red;
						Stats stats =(Stats) hit.collider.GetComponent(typeof(Stats));
						Debug.Log("SELECT");
						int asd=stats.getI();
						Debug.Log(asd);
						asd=stats.getJ();
						Debug.Log(asd);

					}
					else if(hit.collider.transform.tag.Equals("Selected")){
						hit.collider.transform.tag = "Tile";
						hit.collider.renderer.material.color = Color.white;
						Debug.Log("UNSELECT");
					}
				}
			}
		}
	}
	}
}
