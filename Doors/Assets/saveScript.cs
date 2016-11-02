using UnityEngine;
using System.Collections;

public class saveScript : MonoBehaviour {

	public static saveScript saveObject;
	public int higherLevelReached = 1;

	// Use this for initialization
	void Awake () {
		if (saveObject == null) {
			DontDestroyOnLoad (gameObject);
			saveObject = this;
		} else if (saveObject != this) {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Save () {
	
	}

	void Load(){
	}

}
