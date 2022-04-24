using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement_Handler : MonoBehaviour
{
    [SerializeField] private float m_leftScreenBound, m_rightScreenBound, m_topScreenBound, m_bottomScreenBound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    void GetInput()
    {
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && gameObject.GetComponent<Player>()._playerShipTransform.position.x > m_leftScreenBound)
        {
            MoveHorizontal(-1);
        }

        else if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && gameObject.GetComponent<Player>()._playerShipTransform.position.x < m_rightScreenBound)
        {
            MoveHorizontal(1);
        }

        else if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && gameObject.GetComponent<Player>()._playerShipTransform.position.y < m_topScreenBound)
        {
            MoveVertical(1);
        }

        else if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && gameObject.GetComponent<Player>()._playerShipTransform.position.y > m_bottomScreenBound)
        {
            MoveVertical(-1);
        }
    }

    void MoveHorizontal(int direction)
    {
        gameObject.GetComponent<Player>()._playerShipTransform.Translate(Vector3.right * direction * gameObject.GetComponent<Player>().speed);
    }

    void MoveVertical(int direction)
    {
        gameObject.GetComponent<Player>()._playerShipTransform.Translate(Vector3.up * direction * gameObject.GetComponent<Player>().speed);

    }
}


