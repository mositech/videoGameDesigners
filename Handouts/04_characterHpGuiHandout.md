# Character HP and GUI
## Today we’re learning how to give your player an hp system

#### Remember Variables?
* To Jog your memory, variables in programming are words that stand in for numbers and can be changed during the game. 
* First step is to make a new C# script and name it: “characterHp” (no quotes)
* We’re going to be making a variable called “hp” (no quotes) and set it equal to however much health we want our player to start the game with. 
* The type of variable we will be using is an int, which means whole number. We don’t need any decimal points in this script.
* Do you remember how to declare a variable? Here’s the way you set it up below. Ask your neighbors for help. The correct way to set up the variable is on the next page if you are stuck. 

```
using UnityEngine;
using System.Collections;

public class characterHp : MonoBehaviour {

public int ____ = ____ ;
               (What do you type in the first blank space? What goes in the second blank space?)

// Use this for initialization
void Start () {
}
// Update is called once per frame
void Update () {
}
}
```

#### OnTriggerEnter
* Does **“OnTriggerEnter”** sound a bit similar to anyone? Remember we used it to check if something has entered a trigger object. In programming terms, this is called a **Method**, or an action that we use regularly. You know something is a method when you see the word **Void** next to it.  We want to check if our character has bumped into any enemy units. If it does, we want the hp variable to go down by 1.
* Inside of the **OnTrggerEnter** method we need to check if the trigger is tagged with the word “enemy”. This is similar to the way we did this project before. When the tag matches, hp is set to the current hp value minus 1. 
* Let’s say I have 5 apples, and I give one to my friend. How many apples do I now have? We can take the original value (5) and subtract the one I gave away and now I have 4 apples. 

```
using UnityEngine;
using System.Collections;

public class characterHp : MonoBehaviour {

public int hp = 5;

// Use this for initialization
void Start () {
}
// Update is called once per frame
void Update () {
}

void OnTriggerEnter(Collider trigger){
if(trigger.gameObject.tag == "enemy"){
hp = hp - 1;

}
}
}
```

#### Restarting when hp is less than 1
* *IF my hp is less than 1, THEN I want to restart the game.*
Where have we seen this sentence structure before? Of course, when we learned about **if statements**. 
What is the condition that needs to be met? And what is the result?
To restart the game, we will use the code: **Application.loadLevel(0)**;

```

 
using UnityEngine;
using System.Collections;

public class characterHp : MonoBehaviour {

public int hp = 5;

// Use this for initialization
void Start () {
}
// Update is called once per frame
void Update () {
if (hp <1){
Application.LoadLevel (0);  
}
}

void OnTriggerEnter(Collider obj){
if(obj.gameObject.tag == "enemy"){
hp = hp - 1;

}
}
}	 
```

#### Graphic User Interface (GUI)
* Have you ever wondered how game developers make HP bars in video games? This is a ** user interface** and it gives the player information about the game. We are going to make it happen for ourselves.
* We are going to start by typing a new method called “**OnGUI**”. This is used for any graphic user interfaces in Unity. 
* First we will create a new variable and name it “**hpBar**”. We are doing this so we can connect the length of the bar to the hp number that are character currently has.
* **GUI.color** changes the color of the text on screen. Usually HP is done with the color red, but you can change this to any color. 
* **GUI.Box** will create a box on screen. Next we need to create a new rectangle with the **Rect** code. The numbers between the inner parentheses tell unity the position on screen as well as the size of the box. The variable “hpBar” is in the length section.

```
 
public class characterHp : MonoBehaviour {

public int hp = 5;

// Use this for initialization
void Start () {
}
// Update is called once per frame
void Update () {
if (hp <1){
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
GUI.Box (new Rect(30, 60, hpBar, 20), "HP; "+ hp.ToString());
}
}	 
```
