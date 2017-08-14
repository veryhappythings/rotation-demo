using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowHeightGenerator {
    public int Current;
    public int Step;
    public RowHeightGenerator(int start, int step) {
        this.Current = start;
        this.Step = step;
    }

    public int next() {
        int returning = Current;
        Current += Step;
        return returning;
    }
}

public class DebugGUI : MonoBehaviour {
    public GameObject cube;
    public GameObject copier2d;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

    void OnGUI() {
        Vector3 translated = cube.transform.worldToLocalMatrix.MultiplyVector(cube.transform.rotation.eulerAngles);
        RowHeightGenerator height = new RowHeightGenerator(10, 30);
        GUI.Box(new Rect(10,height.next(),230,30), "Horizontal: " + Input.GetAxis("Horizontal"));
        GUI.Box(new Rect(10,height.next(),230,30), "Vertical: " + Input.GetAxis("Vertical"));
        GUI.Box(new Rect(10,height.next(),230,30), "Cube rotation: " + cube.transform.rotation);
        GUI.Box(new Rect(10,height.next(),230,30), "Cube translate: " + translated);
        GUI.Box(new Rect(10,height.next(),230,30), "Cube Euler: " + cube.transform.rotation.eulerAngles);
        GUI.Box(new Rect(10,height.next(),230,30), "Copier2D rotation: " + copier2d.transform.rotation);
        GUI.Box(new Rect(10,height.next(),230,30), "Copier2D Euler: " + copier2d.transform.rotation.eulerAngles);
    }
}
