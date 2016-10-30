using UnityEngine;
using System.Collections;

public class camMouseLook : MonoBehaviour {
	Vector2 mouseLook;
	Vector2 smoothV;
	public float sensitivity = 1.0f;
	public float smoothing = 2.0f;
	float antx, anty;
	GameObject character;

	// Use this for initialization
	void Start () {
		character = this.transform.parent.gameObject;
		//antx = 0;
		//anty = 0;

	}
	
	// Update is called once per frame
	void Update () {

		var md = new Vector2 (Input.GetAxisRaw ("Mouse X"), Input.GetAxisRaw ("Mouse Y"));
		bool foi = false;
		if (character.GetComponent<PlayerController>().inPortal) {
			Debug.Log ("resetou mouse look");
			foi = true;
			character.GetComponent<PlayerController> ().inPortal = false;
		}

		md = Vector2.Scale (md, new Vector2 (sensitivity * smoothing, sensitivity * smoothing));
		smoothV.x = Mathf.Lerp (smoothV.x, md.x, 1f / smoothing);
		smoothV.y = Mathf.Lerp (smoothV.y, md.y, 1f / smoothing);
		mouseLook += smoothV;

		if (foi) {
			mouseLook = new Vector2 (180f, 0f);
			foi = false;
		}

		transform.localRotation = Quaternion.AngleAxis (-mouseLook.y, Vector3.right);
		character.transform.localRotation = Quaternion.AngleAxis (mouseLook.x, character.transform.up);
	}
		
}
