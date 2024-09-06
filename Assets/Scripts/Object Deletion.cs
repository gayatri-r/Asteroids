using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class ObjectDeletion : MonoBehaviour
{
  Rigidbody2D rb;
  private int padding = 5;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      if(OutOfFrame(rb.position)) {
        Destroy(rb.gameObject);
      }
    }

    private bool OutOfFrame(Vector2 pos) {
      if(pos.x > 9 + padding || pos.x < -9 - padding || pos.y > 5 + padding || pos.y < -5 - padding) {
        return true;
      }
      else { return false; }
    }
}
