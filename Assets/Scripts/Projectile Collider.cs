using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
      if(other.gameObject.CompareTag("Asteroid")) { //asteroid collision
        Destroy(other.gameObject); //destroy asteroid
        Destroy(gameObject); //destroy projectile
      }
    }
}
