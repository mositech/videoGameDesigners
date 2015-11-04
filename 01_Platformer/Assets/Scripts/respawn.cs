using UnityEngine;
using System.Collections;

public class respawn : MonoBehaviour {

	public GameObject fireworks;
	private int seconds;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider col){
		if(col.gameObject.name == "Respawn_Zone"){
			Debug.Log("The game reset");
			Application.LoadLevel (0); 
		}

		if(col.gameObject.tag == "Finish"){
			winSequence();
		}
	}

	void winSequence(){
		fireworks.gameObject.SetActive(true);
		StartCoroutine(wait());
		//Application.LoadLevel(0);
	}


	IEnumerator wait() {
		//print(Time.time);
		yield return new WaitForSeconds(5);
		//print(Time.time);
	}
}
