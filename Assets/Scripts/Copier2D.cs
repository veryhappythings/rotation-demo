using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copier2D : MonoBehaviour {
    public GameObject target;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
        Vector3 t = target.transform.rotation.eulerAngles;
        //Quaternion goal = new Quaternion(0, t.y, t.z, t.w);
        transform.eulerAngles = new Vector3(0, t.y, 0);
	}
}
