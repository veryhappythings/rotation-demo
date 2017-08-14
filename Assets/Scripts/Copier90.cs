using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copier90 : MonoBehaviour {
    public GameObject target;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
        Vector3 t = target.transform.rotation.eulerAngles;
        if (t.z < 45) {
            t.z = 0;
        } else if (t.z < 135) {
            t.z = 90;
        } else if (t.z < 225) {
            t.z = 180;
        } else if (t.z  < 315) {
            t.z = 270;
        } else {
            t.z = 0;
        }

        transform.eulerAngles = new Vector3(180f, 0, t.z);
	}
}
