using UnityEngine;
using System.Collections;

public class AnimateController : MonoBehaviour {

	Animator anim;
	public GameObject thePlayer;
	 

	// Use this for initialization
	void Start () {
		anim = gameObject. GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		Bounce bounceScript = thePlayer.GetComponent<Bounce> (); 
		if (bounceScript.justJump) {
			anim.SetBool ("Jump", true);
		} else {
			anim.SetBool ("Jump", false);
		}


		if (Input.GetButtonDown ("right")) {
			gameObject.transform.rotation = Quaternion.Euler (0, -90, 0);
		}
		if (Input.GetButtonDown ("left")) {
			gameObject.transform.rotation = Quaternion.Euler (0, 90, 0);
		}
		if (Input.GetButtonDown ("up")) { 
			gameObject.transform.rotation = Quaternion.Euler (0, 180, 0);
		}
		if (Input.GetButtonDown ("down")) {
			gameObject.transform.rotation = Quaternion.Euler (0, 0, 0);
		}
	}


}
