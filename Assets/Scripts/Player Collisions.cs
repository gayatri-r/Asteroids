using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
  Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other) {
      //Debug.Log(other.gameObject.tag);
      Destroy(other.gameObject);
      Respawn();
    }

    private void Respawn() {
      rb.position = new Vector2(0, 0);
      rb.velocity = new Vector2(0, 0);
      transform.eulerAngles = new Vector3(0, 0, 0);
    }
}
