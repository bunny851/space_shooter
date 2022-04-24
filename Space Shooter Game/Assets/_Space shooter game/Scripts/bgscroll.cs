using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgscroll : MonoBehaviour
{
    [SerializeField] private float m_speed = 4f;
    [SerializeField] private float m_bounds = -7.69f;
    [SerializeField] private Transform m_resetPosition;

    private Vector3 StartPosition;
    // Start is called before the first frame update
    void Start()
    {
        StartPosition = m_resetPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * m_speed * Time.deltaTime);
        if(transform.position.y < m_bounds)
        {
            transform.position = StartPosition;
        }
    }
}
