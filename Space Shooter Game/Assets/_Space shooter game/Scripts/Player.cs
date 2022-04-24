using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public Projectile laserPrefab;
    public GameObject _leftBlaster, _rightBlaster;

    [HideInInspector] public Transform _playerShipTransform;

    void Start()
    {
        _playerShipTransform = gameObject.transform;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        Instantiate(laserPrefab, _leftBlaster.transform.position, Quaternion.identity);
        Instantiate(laserPrefab, _rightBlaster.transform.position, Quaternion.identity);
    }
}

