using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    public int forwardMoveSpeed = 30;
    public int reverseMoveSpeed = 15;
    public int rotateSpeed = 10;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Move(vertical);
        Rotate(horizontal);
    }

    private void Move(float amount)
    {
        int speed = forwardMoveSpeed;
        if (amount < 0)
        {
            speed = reverseMoveSpeed;
        }

        transform.Translate(0, 0, amount * Time.deltaTime * speed);

        //Vector3 position = this.transform.position;
        //position.z += ;
        //this.transform.position = position;

    }

    private void Rotate(float amount)
    {
        transform.Rotate(transform.up, amount * Time.deltaTime * rotateSpeed);

    }
}
