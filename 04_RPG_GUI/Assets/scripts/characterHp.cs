using UnityEngine;
using System.Collections;

public class characterHp : MonoBehaviour {

	public int hp = 5;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (hp < 1){
			Application.LoadLevel (0);  
		}
	}

	void OnTriggerEnter(Collider obj){
		if(obj.gameObject.tag == "enemy"){
			hp = hp - 1;

		}
	}

	void OnGUI(){
		int hpBar = hp * 250;

		GUI.color = Color.red;
		GUI.Box (new Rect(30, 60, hpBar, 20), "HP; " + hp.ToString());
	}
}
