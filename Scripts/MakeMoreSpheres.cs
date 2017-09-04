using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeMoreSpheres : MonoBehaviour {
    GameObject ball;
    float zDist = -49.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MakeBall();
        ball.transform.position = new Vector3(0.07f, 0.69f, zDist);
        zDist += 5;
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
        Color color = Color.red;
        if ( randInt == -1 )
        {
            color = Color.green;
        }

        else if ( randInt == 0 )
        {
            color = Color.yellow;
        }

        else if ( randInt == 1 )
        {
            color = Color.red;
        }

        else
        {
            color = Color.blue;
        }
        return color;
    }//end of makeRandomColor
}//end of class
