using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class AsteroidSpawner : MonoBehaviour
{
    public Rigidbody2D asteroid1;
    public Rigidbody2D asteroid2;
    public Rigidbody2D asteroid3;
    public Rigidbody2D UFO;
    private Rigidbody2D asteroid;
    public int numAsteroids;
    private int counter = 0;
    private int asteroidType = 0;
    private int corner;
    private Vector2 position;
    private Vector2 velocity;
    
    void FixedUpdate()
    {
      counter++;
      //Generate();
      if(counter == 50) {
        corner = Random.Range(1, 4);
        counter = 0;/*
        if(asteroidType % 20 == 0) {
          asteroid = Instantiate(UFO, transform.position, transform.rotation);
        }*/
        if(asteroidType % 13 != 0) {
          if(corner == 1) {
            corner = Random.Range(1, 4);
            position = new Vector2(Random.Range(7, 13), Random.Range(4, 6));
            velocity = new Vector2(Random.Range(-7, -3), Random.Range(-7, -3));
          }
          else if(corner == 2) {
            corner = Random.Range(1, 4);
            position = new Vector2(Random.Range(-13, -7), Random.Range(4, 6));
            velocity = new Vector2(Random.Range(3, 7), Random.Range(-7, -3));
          }
          else if(corner == 3) {
            corner = Random.Range(1, 4);
            position = new Vector2(Random.Range(-13, -7), Random.Range(-6, -4));
            velocity = new Vector2(Random.Range(3, 7), Random.Range(3, 7));
          }
          else if(corner == 4) {
            corner = Random.Range(1, 4);
            position = new Vector2(Random.Range(7, 13), Random.Range(-6, -4));
            velocity = new Vector2(Random.Range(-3, -7), Random.Range(3, 7));
          }
          if(asteroidType % 3 == 0) {
            asteroid = Instantiate(asteroid1, position, Quaternion.identity);
            asteroid.velocity = velocity;
          }
          else if(asteroidType % 3 == 1) {
            asteroid = Instantiate(asteroid2, position, Quaternion.identity);
            asteroid.velocity = velocity;
          }
          else if(asteroidType % 3 == 2) {
            asteroid = Instantiate(asteroid3, position, Quaternion.identity);
            asteroid.velocity = velocity;
          }
        }
        else{
          asteroid = Instantiate(UFO, new Vector2(-10, Random.Range(-4, 4)), Quaternion.identity);
          asteroid.velocity = new Vector2(Random.Range(4, 7), 0);
        }
        asteroidType++;
      }
    }
}
