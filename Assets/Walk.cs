using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    // You can change players' speed from the GUI.
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {
        // We got each player's Transform component to change his position.
        // For each player we used different keys to move with.

        // Player1 - can move with 'A','D', 'S', 'W'.
        Transform t1 = GameObject.FindGameObjectWithTag("Player1").transform;
        if (Input.GetKey(KeyCode.A))
        {
            t1.position = new Vector3(t1.position.x - speed, t1.position.y, t1.position.z);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            t1.position = new Vector3(t1.position.x + speed, t1.position.y, t1.position.z);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            t1.position = new Vector3(t1.position.x, t1.position.y - speed, t1.position.z);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            t1.position = new Vector3(t1.position.x, t1.position.y + speed, t1.position.z);
        }

        // Player2 - can move with keyboard arrows.
        Transform t2 = GameObject.FindGameObjectWithTag("Player2").transform;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            t2.position = new Vector3(t2.position.x + speed, t2.position.y, t2.position.z);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            t2.position = new Vector3(t2.position.x - speed, t2.position.y, t2.position.z);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            t2.position = new Vector3(t2.position.x, t2.position.y + speed, t2.position.z);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            t2.position = new Vector3(t2.position.x, t2.position.y - speed, t2.position.z);
        }
    }
}