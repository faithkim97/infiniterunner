using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour {

    public float speed;

    private void Start()
    {
        speed = 1.0f;
    }

    // Update is called once per frame
    void Update () {
        transform.Translate(new Vector3(0.0f, 0.0f, -speed * Time.deltaTime ));


	}
}
