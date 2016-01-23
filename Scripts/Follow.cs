using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

    GameObject toFollow;
    private Rigidbody rb;
    public float speed;
    // Use this for initialization
    void Start () {
        toFollow = null;
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(toFollow);
        if (toFollow != null) {
            //Debug.Log("I've got you!");
            float step = speed * Time.deltaTime;
            Vector3 movement = Vector3.MoveTowards(rb.transform.localPosition,toFollow.transform.localPosition,step);
            transform.position = movement;
            //Debug.Log(movement);
            //rb.AddForce(movement);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            toFollow = other.gameObject;
            //Debug.Log("Found you!");
            //Debug.Log(toFollow);
        }
        //Debug.Log("Collided with the ground!");
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            toFollow = null;
            //Debug.Log("Lost you!");
        }
        //Debug.Log("Collided with the ground!");
    }

}
