using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BossScript : MonoBehaviour {

    private Animator myAnim;
    private int currFrame;
    public Text text;

	// Use this for initialization
	void Start () {
	    myAnim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        // Every 3 seconds, attack
        if(currFrame % 40 == 0)
        {
            myAnim.SetBool("Attack!", true);
            myAnim.Play("Attack!");
            Invoke("stopAttack", 0.01f);
        }

        // Every 5 seconds, block
        if(currFrame % 100 == 0)
        {
            myAnim.SetBool("Block!", true);
            myAnim.Play("Block!");
            Invoke("stopBlock", 0.01f);
        }
        currFrame++;
	}

    void OnCollisionStay(Collision other)
    {
        Animator ZeroAnim = other.gameObject.GetComponent<Animator>();
        if (other.gameObject.name.StartsWith("Zero") && ZeroAnim.GetBool("Attack") == true)
        {  // isAttacking is the variable for animation state changing
            Destroy(this.gameObject);
            text.text = "Congrats!  You beat the tutorial!";
        }
    }
}
