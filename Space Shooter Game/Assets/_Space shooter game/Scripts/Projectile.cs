using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector3 direction = Vector3.up;
    public float speed;

    private void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
    
