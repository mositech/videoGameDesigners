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

		Debug.Log(Input.GetAxis("xbox_Rtrigger"));
		if (Input.GetAxis("xbox_Rtrigger") > 0.9f && !Input.GetButton("xbox_Lbumper")){
			Fire();
			//Debug.Log("firing");
		}
			
		if(Input.GetButton("xbox_Lbumper")){
			scope();
			//Debug.Log("SCOPE");
			if(Input.GetAxis("xbox_Rtrigger") > 0 && Input.GetButton("xbox_Lbumper")){
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