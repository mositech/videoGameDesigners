using UnityEngine;
using System.Collections;

public class carMotion : MonoBehaviour {

	public float speed = 5;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//****Movement Controls****
		if(Input.GetKey(KeyCode.W)){
			transform.position += transform.forward * speed * Time.deltaTime;
		}
		
		if (Input.GetKey (KeyCode.S)) {
			transform.position -= transform.forward *  speed* Time.deltaTime;
		}
		
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(0f, -80f * Time.deltaTime, 0f);
		}
		
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate(0f, 80f * Time.deltaTime, 0f);
		}
	}


}