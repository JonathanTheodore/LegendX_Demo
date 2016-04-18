using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {
	public Text text;
	int myInt;
	// Use this for initialization
	void Start () {
		myInt = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Z) && myInt == 0) {
			myInt++;
		}
		if(Input.GetKeyUp (KeyCode.X) && myInt == 1) {
			myInt++;
			text.text = "Dodge an Attack (J)";
            // Coins start below map -> Change position to on map
            GameObject aCoin = GameObject.Find("coin2");
            Vector3 newPosition = aCoin.transform.position;
            newPosition.y = 5;
            aCoin.transform.position = newPosition;
        }
		if(Input.GetKeyUp (KeyCode.J) && myInt == 2) {
			myInt++;
			text.text = "Now try flying (F)";
            // Coins start below map -> Change position to on map
            GameObject aCoin = GameObject.Find("coin3");
            Vector3 newPosition = aCoin.transform.position;
            newPosition.y = 5;
            aCoin.transform.position = newPosition;
        }
		if(Input.GetKeyUp (KeyCode.F) && myInt == 3) {
			myInt++;
            // Coins start below map -> Change position to on map
            GameObject aCoin = GameObject.Find("coin4");
            Vector3 newPosition = aCoin.transform.position;
            newPosition.y = 5;
            aCoin.transform.position = newPosition;
            text.text = "Fight the boss";
			GameObject boss = GameObject.Find("boss");
			Vector3 newPosition1 = boss.transform.position;
			newPosition1.y = 1;
			boss.transform.position = newPosition1;
		}
	}
}
