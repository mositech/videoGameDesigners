using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour {

	public GameObject player;

	public Vector3 offset = new Vector3(0.1190664f, 7.082292f, -8.371008f);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position + offset;
	}
}
