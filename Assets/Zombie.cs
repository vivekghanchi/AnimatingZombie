using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {
    Animator animZombie;
    float speed = 10.0f;

	// Use this for initialization
	void Start () {
        animZombie = GetComponent<Animator>();	
	}
	
	// Update is called once per frame
	void Update () {
        
            //Walk Animation Zombie

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            animZombie.SetBool("Walk", true);
            animZombie.SetBool("Stop", false);
        }

        // Stop Zombie Animation

        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.DownArrow))
        {

            animZombie.SetBool("Stop", true);
            animZombie.SetBool("Walk", false);
        }
    }

    private void FixedUpdate()
    {
        // Move Code
        // Move Forward
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 5), ForceMode.VelocityChange);
            transform.GetComponent<Rigidbody>().rotation = Quaternion.LookRotation(Vector3.forward);
        }
        // Move Player Left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.GetComponent<Rigidbody>().AddForce(new Vector3(-5, 0, 0), ForceMode.VelocityChange);
            transform.GetComponent<Rigidbody>().rotation = Quaternion.LookRotation(Vector3.left);
        }
        // Move Player Back
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -5), ForceMode.VelocityChange);
            transform.GetComponent<Rigidbody>().rotation = Quaternion.LookRotation(Vector3.back);
        }
        // Move Player Right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.GetComponent<Rigidbody>().AddForce(new Vector3(5, 0, 0), ForceMode.VelocityChange);
            transform.GetComponent<Rigidbody>().rotation = Quaternion.LookRotation(Vector3.right);
        }
    }
}
