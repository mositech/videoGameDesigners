using UnityEngine; 
using System.Collections;

public class shoot : MonoBehaviour 
{
	public float bulletSpeed = 10;
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
		if (Input.GetButtonDown("PS4_R2") && !Input.GetButton("PS4_L2")){
			Fire();
		}
			
		if(Input.GetButton("PS4_L2")){
			scope();
			Debug.Log("SCOPE");
			if(Input.GetButtonDown("PS4_R2") && Input.GetButton("PS4_L2")){
				Debug.Log("Shooting");
				Fire ();
			}
		}
		else{
			zoomCam.enabled = false;
			normalCam.enabled = true;
		}
	}
}