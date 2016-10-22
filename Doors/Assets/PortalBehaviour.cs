using UnityEngine;
using System.Collections;

public class PortalBehaviour : MonoBehaviour {

	public GameObject targetPortal;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	
	void OnTriggerEnter(Collider other){
		if(other.tag == "Player") {
			other.transform.position = targetPortal.transform.position + targetPortal.transform.right*5 - targetPortal.transform.up*(-2);
		}
	}

}