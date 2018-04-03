using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public Transform origin;
    public float speed = 10f;
    public float speed_ = 2f;
    float y, z;
	void Start () {
        y = Random.Range(1, 360);
        z = Random.Range(1, 360);

    }
	
	
	void Update () {
        Vector3 axis = new Vector3(0, y, z);
        this.transform.RotateAround(origin.position, axis, speed * Time.deltaTime);
        this.transform.Rotate(Vector3.up * speed_ * Time.deltaTime);
	}
}
