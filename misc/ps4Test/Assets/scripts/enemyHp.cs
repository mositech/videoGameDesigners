using UnityEngine;
using System.Collections;

public class enemyHp : MonoBehaviour {

	public int hp = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(hp < 1){
			Destroy (this.gameObject);
		}
	}
}
