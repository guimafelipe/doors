using UnityEngine;
using System.Collections;

public class PortalBehaviour : MonoBehaviour {

	public GameObject targetPortal;
	public float waitTime = 0.5f;
	bool entered = false;
	GameObject playerCamera;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (entered) {
			waitTime -= Time.deltaTime;
			if (waitTime <= 0f) {
				playerCamera.GetComponent<camMouseLook> ().enabled = true;
				waitTime = 0.5f;
				entered = false;
			}
		}
	}


	void OnTriggerEnter(Collider other){
		if(other.tag == "Player") {
			other.transform.position = targetPortal.transform.position + targetPortal.transform.right*5 - targetPortal.transform.up*(-2);
			//other.transform.localEulerAngles = new Vector3(0f,90f,0f);
			other.transform.rotation = targetPortal.transform.rotation;
			/*other.transform.eulerAngles = new Vector3(
				targetPortal.transform.eulerAngles.x,
				targetPortal.transform.eulerAngles.y + 90,
				targetPortal.transform.eulerAngles.z
			);*/

			playerCamera = other.gameObject.transform.FindChild ("Main Camera").gameObject;
			playerCamera.GetComponent<camMouseLook>().enabled = false;
			other.transform.Rotate (0f, 90f, 0f);
			entered = true;
		}
	}

}