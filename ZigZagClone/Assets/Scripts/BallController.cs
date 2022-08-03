using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Vector3 direction;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(direction.x == 0)
            {
                direction = Vector3.left;
            }
            else
            {
                direction = Vector3.forward;
            }
        }
    }
    private void FixedUpdate()
    {
        Vector3 move = direction * Time.deltaTime * speed;
        transform.position += move;
    }
}
