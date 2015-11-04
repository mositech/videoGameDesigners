using UnityEngine; 
using System.Collections;

public class shoot : MonoBehaviour 
{
	public float bulletSpeed = 20;
	public Rigidbody bullet;
	public Camera normalCam;
	public Camera zoomCam;
	
	void Fire()
	{
		Rigidbody bulletClone = (Rigidbody) Instantiate(bullet, transform.position, transform.rotation);
		bulletClone.velocity = transform.forward * bulletSpeed;
	}
	
	void scope(){
		normalCam.enabled = false;
		zoomCam.enabled = true;
	}
	
	void Update () 
	{
		
		Debug.Log(Input.GetKey(KeyCode.Mouse0));
		if (Input.GetKey(KeyCode.Mouse0) && !Input.GetKey(KeyCode.Mouse1)){
			Fire();
			//Debug.Log("firing");
		}
		
		if(Input.GetKey(KeyCode.Mouse1)){
			scope();
			//Debug.Log("SCOPE");
			if(Input.GetKey(KeyCode.Mouse0) && Input.GetKey(KeyCode.Mouse1)){
				//`Debug.Log("Shooting");
				Fire ();
			}
		}
		else{
			zoomCam.enabled = false;
			normalCam.enabled = true;
		}
	}
}