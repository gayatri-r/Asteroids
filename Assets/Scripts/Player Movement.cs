using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    Rigidbody2D rb;
    private float rot;
    public float rotAmt;
    public float latMoveAmt;
    private float r;
    private Vector2 rotationVector;
    private Vector2 projectileVector;
    public Rigidbody2D projectile;
    private Rigidbody2D proj;
    //private bool turning = false;
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
      projectileVector = new Vector2(0, latMoveAmt);
    }

    void FixedUpdate() {
      r = Mathf.Deg2Rad * transform.eulerAngles.z; //angle of rotation currently
      transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z + rot);
    }
    void OnTurn(InputValue value) {
      //turning = true;
      rot = value.Get<float>() * rotAmt;
    }
    
    void OnMove(InputValue value) {
      if(value.isPressed) {
        //r = Mathf.Deg2Rad * transform.eulerAngles.z; //angle of rotation currently
        rotationVector = new Vector2(-latMoveAmt * Mathf.Sin(r), latMoveAmt * Mathf.Cos(r));
        rb.velocity = rotationVector;
        Debug.Log(rotationVector);
      }
      else {
        rb.velocity = new Vector2(0, 0);
      }
      //Debug.Log(rb.velocity);
      //Debug.Log(rb.position);
    }

    void OnShoot() {
      projectileVector = new Vector2(-latMoveAmt * Mathf.Sin(r), latMoveAmt * Mathf.Cos(r));
      //proj = Instantiate(projectile, rb.position, transform.rotation);
      proj = Instantiate(projectile, transform.position, transform.rotation);
      proj.velocity = projectileVector;
    }
}
