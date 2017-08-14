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
        t.z = Mathf.Round(t.z / 90) * 90;

        transform.eulerAngles = new Vector3(180f, 0, t.z);
	}
}
