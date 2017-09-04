using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyBall : MonoBehaviour {
    private int scoreCount;
    public Text score;

	// Use this for initialization
	void Start () {
        scoreCount = 0;
        SetCountText();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
         //if not correct input pressed
        if ( (other.gameObject.CompareTag( "red") && !Input.GetKeyDown(KeyCode.UpArrow)) ||
            ( other.gameObject.CompareTag("blue") && !Input.GetKeyDown(KeyCode.RightArrow)) ||
            ( other.gameObject.CompareTag("yellow" ) && !Input.GetKeyDown(KeyCode.DownArrow) ) ||
            ( other.gameObject.CompareTag("green" ) && !Input.GetKeyDown(KeyCode.LeftArrow)) )
        {
            //Put game over sign and go back to menu--didn't do that yet
            Application.Quit();
        }//end of if

        else
        {
            Destroy(other.gameObject);
            //score goes up by two points for each object
            scoreCount = scoreCount + 2;
            SetCountText();


        }
    }//end of OnTriggerEnter

    void SetCountText()
    {
        score.text = "Score: " + scoreCount.ToString();
    }
}
