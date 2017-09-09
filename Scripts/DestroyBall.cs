using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyBall : MonoBehaviour {
    private int scoreCount;
    public int globalScore; 
    public Text score;
	
    // Use this for initialization
	void Start () {
       globalScore = scoreCount = 0;
        SetCountText();

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerStay(Collider other)
   
    {
        Debug.Log("entered trigger");
        
         //if not correct input pressed
        if ( (other.gameObject.CompareTag( "red") && !Input.GetKeyDown(KeyCode.UpArrow)) ||
            ( other.gameObject.CompareTag("blue") && !Input.GetKeyDown(KeyCode.RightArrow)) ||
            ( other.gameObject.CompareTag("yellow" ) && !Input.GetKeyDown(KeyCode.DownArrow) ) ||
            ( other.gameObject.CompareTag("green" ) && !Input.GetKeyDown(KeyCode.LeftArrow)) )
        {
            //Put game over sign and go back to menu--didn't do that yet
            Debug.Log("FAIL");
            Application.Quit();
        }//end of if
        

     

       
        else
        {
            Destroy(other.gameObject);
            //score goes up by two points for each object
            globalScore = scoreCount = scoreCount + 2;
            SetCountText();


        }
        
    }//end of OnTriggerEnter

    void SetCountText()
    {
        score.text = "Score: " + scoreCount.ToString();
    }
}
