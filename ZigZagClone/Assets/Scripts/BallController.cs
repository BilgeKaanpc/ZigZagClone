using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Vector3 direction;
    public float speed;
    public float adSpeed;
    public ZeminSpawner zeminSpawnerScript;
    public static bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector3.forward;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.y <= 0.5f)
        {
            gameOver = true;
        }
        if (gameOver)
        {
            return;
        }
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
            speed += adSpeed;
        }
    }
    private void FixedUpdate()
    {
        Vector3 move = direction * Time.deltaTime * speed;
        transform.position += move;
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag== "Zemin")
        {
            Score.score++;
            collision.gameObject.AddComponent<Rigidbody>();
            zeminSpawnerScript.zeminSpawn();
            StartCoroutine(DestroyCube(collision.gameObject));
        }
    }

    IEnumerator DestroyCube(GameObject cube)
    {
        yield return new WaitForSeconds(4f);
        Destroy(cube);
    }
}
