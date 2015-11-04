using UnityEngine;
using System.Collections;

public class mcBuild : MonoBehaviour {
	
	public GameObject parent;
	public RaycastHit hit;
	public LineRenderer line;
	private GameObject block;
	
	public int count = 0;

	public int selectBlock = 1;
	public GameObject grassblock;
	public GameObject dirtBlock;
	public GameObject stoneblock;
	
	// Use this for initialization
	void Start () {
		line = gameObject.AddComponent<LineRenderer>();
		line.SetWidth(.02f,0.02f);
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log (selectBlock);

		if(Input.GetKeyDown(KeyCode.F)){
			selectBlock++;
			if(selectBlock == 4){
				selectBlock = 1;
			}
		}

		if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)){
			line.SetPosition(0,parent.transform.position);
			line.SetPosition(1,hit.point);
		}
		
		//LEFT CLICK
		if(Input.GetMouseButtonDown(1)){
			Debug.Log ("Left mouse click: " + hit.transform.name);
			
			if(hit.transform.tag == "cube"){
				Vector3 cubePos = hit.transform.position + hit.normal;
				Quaternion rot = Quaternion.identity;
				GameObject newInstance;

				if(selectBlock == 1){
					block = grassblock;
				}else if(selectBlock == 2){
					block = dirtBlock;
				}else if(selectBlock == 3){
					block = stoneblock;
				}

				newInstance = Instantiate(block, cubePos, rot) as GameObject;
				
				newInstance.name = "superCube" + count;
				count++;
			}
			
			
		}
		
		//RIGHT CLICK
		if(Input.GetMouseButtonDown(0)){
			if(hit.transform.tag == "cube"){
				Debug.Log ("Right mouse click: " + hit.transform.name);
				GameObject collideObj = GameObject.Find(hit.transform.name);
				Destroy(collideObj);
			}
		}
		
		
	}
}