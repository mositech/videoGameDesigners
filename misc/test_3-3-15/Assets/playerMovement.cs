using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {


	public float speed;
	public int count;
	public GameObject fireworks;

	// Use this for initialization
	void Start () {
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		float forward = Input.GetAxis("Vertical");
		float sideways = Input.GetAxis("Horizontal");

		Vector3 movement = new Vector3(sideways, 0, forward);

		GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
	
		if(count >= 6){
			fireworks.gameObject.SetActive(true);
		}
		else{
			fireworks.gameObject.SetActive(false);
		}
	}

	void OnTriggerEnter(Collider hitObj){
		if(hitObj.tag == "pickup"){
			Destroy(hitObj.gameObject);
			count = count + 1;
		}
	}
}
