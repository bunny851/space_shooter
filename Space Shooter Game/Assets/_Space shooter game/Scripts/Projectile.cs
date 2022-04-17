using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Vector3 direction;
    public float speed;

    private void update()
    {
        this.transform.position += this.direction * this.speed * Time.deltaTime;
    }
}
    
