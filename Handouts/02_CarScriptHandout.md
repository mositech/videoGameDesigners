# Car Movement Script
## Today we’re learning how to program a vehicle in Unity
#### 1. How do computers make decisions?
* Computers can’t make decisions all by themselves. Computers are good at taking in, organizing, and processing information. Programmers need to set up situations where computers can use all of that data. 
* There situations are called **conditionals** or **if-statements**. These are set up in this way: *If* (some condition is met) *then* (a result happens)
* Example: *If it is raining, then I will wear a raincoat*. Can you find which part of this example is the condition and which is the result?

#### 2. Input from the player
* Any button you push when playing a game is called an **input**. Technically what you are doing is sending a signal to the computer telling that a button is pressed, and also says which button is pressed down. 
* We are going to combine this *input* with *if-statements* to ask, **if a button is pressed down, then activate something.**
* The code for asking for an input is: **Input.GetKey(KeyCode.W)** Note: The “W” in this example is a placeholder. You will change this letter depending on which button you want information from.
* Below is how our code should look after entering our first if-statement.

```
using UnityEngine;
using System.Collections;

public class carMotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W)){
			
		}
	}
}
```

#### 3. How do we tell our vehicle to move?
* Currently, when we press the “W” key down, nothing happens. This is because we don’t have any **result** inside of the if-statement. The **result** goes between the two curly braces that look like this **{ }**.
* Here is the code that will go inside of the if-statement’s result: transform.position += transform.forward * 5 * Time.deltaTime; Let’s break this down
* **Transform.position** refers to the object’s current position in space. We will be changing this value to make the car move.
*	**Transform.forward** refers to the direction that we want our car to be moving in. 
*	**5 * Time.deltaTime**, 5 is our speed value, we can change this number to change the speed of our car. Time.deltaTime will stabilize how fast the car moves. This makes it so the car moves the same speed on all computers. 

```
using UnityEngine;
using System.Collections;

public class carMotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W)){
			transform.position += transform.forward * 5 * Time.deltaTime;
		}
	}
}
```
