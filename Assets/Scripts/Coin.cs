using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Coin : MonoBehaviour {
	public Text coinText;
	public static int coins;
	// Use this for initialization
	void Start () {
		coins = 0;
	}
	
	// Update is called once per frame
	void Update () {
		coinText.text = "" +coins;
	}
}
