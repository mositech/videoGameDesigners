using UnityEngine;
using System.Collections;

public class bulletDestroy : MonoBehaviour {
	
	public float waitTime = 2.0f;
	
	void Start() {
		//		print("Starting " + Time.time);
		StartCoroutine(WaitAndPrint(2.0F));
		//		print("Before WaitAndPrint Finishes " + Time.time);
	}
	IEnumerator WaitAndPrint(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		//		print("destroy " + Time.time);
		Destroy(this.gameObject);
	}
	
	void OnTriggerEnter(Collider col){
		if(col.tag == "enemy"){
			col.gameObject.GetComponent<enemyHp>().hp -= 1;
			Debug.Log(col.gameObject.GetComponent<enemyHp>());
			//			Debug.Log(col.gameObject.GetComponent<enemyHp>().hp);
		}
		Destroy(this.gameObject);
	}
}
