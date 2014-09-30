using UnityEngine;
using System.Collections;



public class BoardCreator : MonoBehaviour {
	public GameObject tile;
	private int boardSize=13;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < boardSize; i++) {
			for(int j = 0; j<boardSize; j++){
				if(i==0 && j==0){

				}
				else if(i==0 && j==boardSize-1){


				}
				else if(i==boardSize-1 && j==0){
					
					
				}
				else if(i==boardSize-1 && j==boardSize-1){
					
					
				}
				else if(i==(boardSize-1)/2 && j==(boardSize-1)/2){

				}
				else{
				Instantiate(tile);
				tile.transform.position = new Vector3 (i+0.05F*i,0,j+0.05F*j);
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
