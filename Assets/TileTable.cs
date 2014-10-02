using UnityEngine;
using System.Collections;

public class TileTable : MonoBehaviour {
	private GameObject[,] tileSheet;
	void Start () {

		BoardCreator bc = gameObject.GetComponent<BoardCreator>();
		int size=bc.getBoardSize();
		print(size);
		tileSheet = new GameObject[size,size];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
