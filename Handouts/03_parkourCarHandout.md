# Parkour Car Game with Checkpoints
## Here's out car movement script so far:

```
using UnityEngine;
using System.Collections;

public class carMotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//****Movement Controls****
		if(Input.GetKey(KeyCode.W)){
			transform.position += transform.forward * 5 * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.position -= transform.forward * 5 * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(0f, -80f * Time.deltaTime, 0f);
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate(0f, 80f * Time.deltaTime, 0f);
		}
	}
}
```

#### 1. What is a Vector3?
* A Vector3 is only just a collection of numbers. In this case, Vector3 stores 3 different numbers. A Vector2 would store 2 numbers, and a Vector1 would store 1 number.
* In our code, we will use Vector3 to store positions in 3D space. Remember our X, Y, and Z coordinates?



#### 2. Lets Make a Variable
* A Variable is something in code that stores a number (or in this case 3 numbers). Let’s update our code with some new variables.
* “checkpoint” will keep track of new checkpoint positions that our car reaches.
* “spawnpoint” is where the cars starts in the world. 
* The checkpoint variable will be changing and throughout the game, it will store different numbers. This is the power of variables. The allow us to do really cool things!
* **Note: Your numbers will probably be different than the ones provided here**.

```
using UnityEngine;
using System.Collections;

public class carMotion : MonoBehaviour {
                
         
                private Vector3 checkpoint = new Vector3(0,3,0);
	private Vector3 spawnpoint = new Vector3(0,3,0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//****Movement Controls****
		if(Input.GetKey(KeyCode.W)){
			transform.position += transform.forward * 5 * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.position -= transform.forward * 5 * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(0f, -80f * Time.deltaTime, 0f);
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate(0f, 80f * Time.deltaTime, 0f);
		}
	}
}
```

#### 3. Writing the Trigger Code
* Like we did in an earlier session, we are going to create a trigger. This time we will program in what happens when our character enters the trigger!
* Just like “void Update” or “void Start” we need to make a new void. This will be called “void OnTriggerEnter”. Unity scans each frame update for if our character enters a trigger. 
* After naming the void, we need to feed it some information. Between the parentheses, we need to give it something to look for: a “Collider”. In this example we will name whatever the car collides with “trigger”.

```
using UnityEngine;
using System.Collections;

public class carMotion : MonoBehaviour {
         
                private Vector3 checkpoint = new Vector3(0,3,0);
	private Vector3 spawnpoint = new Vector3(0,3,0);

	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
		//****Movement Controls****
		if(Input.GetKey(KeyCode.W)){
			transform.position += transform.forward * 5 * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.position -= transform.forward * 5 * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(0f, -80f * Time.deltaTime, 0f);
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate(0f, 80f * Time.deltaTime, 0f);
		}
	}

                 void OnTriggerEnter(Collider trigger){
		
	}
}
```

#### 4. How to Update Our Checkpoint
*	Now we need to check if the trigger has a specific tag named “checkpoint” Let’s write an if-statement!
*	If the trigger’s tag is “checkpoint” the checkpoint variable is now set to the trigger’s position.

```
using UnityEngine;
using System.Collections;

public class carMotion : MonoBehaviour {
         
                private Vector3 checkpoint = new Vector3(0,3,0);
	private Vector3 spawnpoint = new Vector3(0,3,0);

	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
		//****Movement Controls****
		if(Input.GetKey(KeyCode.W)){
			transform.position += transform.forward * 5 * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.position -= transform.forward * 5 * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(0f, -80f * Time.deltaTime, 0f);
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate(0f, 80f * Time.deltaTime, 0f);
		}
	}

                 void OnTriggerEnter(Collider trigger){
	if(trigger.tag == "checkpoint"){
		checkpoint = trigger.transform.position;
	}
	
          }
}
```

#### 5. “Go Back to Recent Checkpoint” Button
*	Just like how we made the car movements with if-statements, we will make another one this time looking for the “Keycode.C” (C stands for “Checkpoint”).
*	When the button gets pressed, update the car’s position to the current position stored in the “checkpoint” variable. 

```
using UnityEngine;
using System.Collections;

public class carMotion : MonoBehaviour {
         
                private Vector3 checkpoint = new Vector3(0,3,0);
	private Vector3 spawnpoint = new Vector3(0,3,0);

	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
		//****Movement Controls****
		if(Input.GetKey(KeyCode.W)){
			transform.position += transform.forward * 5 * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.position -= transform.forward * 5 * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(0f, -80f * Time.deltaTime, 0f);
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate(0f, 80f * Time.deltaTime, 0f);
		}
	}

            if(Input.GetKeyDown(KeyCode.C)){
		transform.position = checkpoint;
		transform.eulerAngles = new Vector3(0, 0, 0);
	}


                 void OnTriggerEnter(Collider trigger){
	if(trigger.tag == "checkpoint"){
		checkpoint = trigger.transform.position;
	}
	
         }
}
```

#### 6. How Can We Make Zones That Reset the Car to Spawn?
* We will need to make another if-statement within the :”OnTriggerEnter”. Also you will need to make a separate tag for objects that will reset the car to spawn instead of update the checkpoint. 
*	Don;t forget to make this new zone a trigger!
