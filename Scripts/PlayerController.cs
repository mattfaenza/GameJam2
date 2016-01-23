using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    // Use this for initialization
    private Rigidbody rb;
    public float speed;
    public float jump_height;
	void Start () {
        //Debug.Log("Hello Scripting!");
        rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate()
    {
        rb.velocity = Vector3.zero;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(speed * horizontal, 0, speed * vertical);
        //rb.AddForce(movement);
        transform.position = transform.position + movement*Time.deltaTime;
    }

    // Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter(Collider other) {

        if (other.CompareTag("Enemy"))
        {
            Debug.Log("EXPLOSION!");
        }
    }
}
