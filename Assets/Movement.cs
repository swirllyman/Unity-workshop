using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float speed = 24;
    Transform cam;

    void Start() {
        cam = Camera.main.transform.parent;
    }
    
	// Update is called once per frame
	void Update () {
        cam.position = transform.position;
        transform.forward = Camera.main.transform.forward;
        //increments the object based on the Vector 3 that is passed in
        transform.Translate((Input.GetAxisRaw("Horizontal") * Time.deltaTime) * speed, 
            0, 
            (Input.GetAxisRaw("Vertical") * Time.deltaTime) * speed);
	}
}
