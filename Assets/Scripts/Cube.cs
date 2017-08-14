using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, 0, 1 * horizontal));

        float vertical = Input.GetAxis("Vertical");
        transform.Rotate(new Vector3(0, 1 * vertical, 0));
	}
}
