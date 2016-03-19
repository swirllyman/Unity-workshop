using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    //[Tooltip("Value for character speed.")]
    public float speed = 24;
    public float elevationSpeed = 10;
    Transform cam;

    void Start() {
        cam = Camera.main.transform.parent;
    }
    
	// Update is called once per frame
	void Update () {
        cam.position = transform.position;
        transform.forward = cam.forward;

        //increments the object based on the Vector 3 that is passed in
        transform.Translate((Input.GetAxisRaw("Horizontal") * Time.deltaTime) * speed, 0, (Input.GetAxisRaw("Vertical") * Time.deltaTime) * speed);

        //GetKeyDwn() ---- WRONG
        //GetKey() ----    RIGHT

        if (Input.GetKey(KeyCode.Q)) {
            transform.position += transform.up * Time.deltaTime * elevationSpeed;
        }

        if (Input.GetKey(KeyCode.E)) {
            transform.position -= transform.up * Time.deltaTime * elevationSpeed;
        }
	}
}
