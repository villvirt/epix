using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour {
	public int i;
	public int j;

	public int getI(){
		return i;

	}
	public int getJ(){
		return j;

	}
	public void setI(int i){
		this.i=i;

	}
	public void setJ(int j){
		this.j=j;

	}

	void OnGUI () {
		
		if(transform.tag=="Selected"){
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,80,20), "Push")) {
			print ("clicky");
		}
		}

	}
}