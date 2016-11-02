using UnityEngine;
using System.Collections;

public class DoorSaveUpdate : MonoBehaviour {

	public int doorLevel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == "Player") {
			saveScript.saveObject.higherLevelReached = Mathf.Max(doorLevel,saveScript.saveObject.higherLevelReached);
		}
	}
}

