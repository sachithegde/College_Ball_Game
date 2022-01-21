using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float Speed;
    public Rigidbody rb;
    bool GameStarted = false;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameStarted)
        {
            rb.velocity = new Vector3(0, 0, Speed);
            GameStarted = true;
        }
        if (!Physics.Raycast(transform.position, Vector3.down, 2f))
        {
            rb.velocity = new Vector3(0, -10, 0);
        }
        else
        {
            if(Input.GetMouseButtonDown(0))
            {
                changeDir();
            }
        }
        
    }

    void changeDir()
    {
        if(rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(Speed, 0, 0);
        }
        else if(rb.velocity.x > 0)
        {
            rb.velocity = new Vector3(0, 0, Speed);
        }
    }


}
