using UnityEngine;
using System.Collections;

public class TileScript : MonoBehaviour {
<<<<<<< HEAD

	private LevelScript levelScript;
=======
private LevelScript levelScript;

>>>>>>> 0856591d8ae49453a41c7f201ef7b6276bb382d9
	
	// Use this for initialization
	void Start () {
		//Get LevelScript instance
		levelScript = GameObject.Find("LevelManager").GetComponent<LevelScript>();
		//Put the tile in generic list
		levelScript.RegisterTile(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
