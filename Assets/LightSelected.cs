using UnityEngine;
using System.Collections;

public class LightSelected : MonoBehaviour {
	public Light light;
	// Use this for initialization
	void Start () {
		Instantiate(light);
		light.intensity=0;
		Debug.Log("intensity =0");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {

		GameObject tile = GameObject.FindGameObjectWithTag("Selected");
		light.transform.position = new Vector3(tile.transform.position.x,tile.transform.position.y+2F,tile.transform.position.z);
			light.intensity=10;
			Debug.Log("Siirretään");
		
	}
	}
}
