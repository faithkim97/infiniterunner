using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeMoreSpheres : MonoBehaviour {
    GameObject ball;
    float zDist = -49.0f;
	
	// Update is called once per frame
	void Update () {
        MakeBall();
        ball.transform.position = new Vector3(0.07f, 0.69f, zDist);
        zDist += 2;
	}

    void MakeBall()
    {
        ball = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Color color = createRandomColor();
        MeshRenderer ballRenderer = ball.GetComponent<MeshRenderer>();
        Material newMaterial = new Material(Shader.Find("Diffuse"));
        newMaterial.color = color;
        ballRenderer.material = newMaterial;
        //add necessary components 
        //add move ball
        MoveBall moveball = ball.AddComponent<MoveBall>(); 


    }

    private Color createRandomColor()
    {
        int randInt = Random.Range(-1, 3);
        //just to initialize
        Color color = Color.red;
        ball.tag = "red";
        if ( randInt == -1 )
        {
            color = Color.green;
            ball.tag = "green";
        }

        else if ( randInt == 0 )
        {
            color = Color.yellow;
            ball.tag = "yellow";
        }

        else if ( randInt == 1 )
        {
            color = Color.red;
            ball.tag = "red";
        }

        else
        {
            color = Color.blue;
            ball.tag = "blue";
        }
        return color;
    }//end of makeRandomColor
}//end of class
