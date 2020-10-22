using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public Rigidbody playerRB;

    public bool isJumping;

    [Range(0, 100)]
    public float speed = 3.0f;
    [Range(0, 1000)]
    public float jumpForce = 8.0f;
    // Start is called before the first frame update
    void Start()
    {
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
        isJumping = false;
    }

    public void move()
    {
        if(Input.GetKey(KeyCode.D))
        {
            player.transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            player.transform.Translate(-speed * Time.deltaTime, 0, 0, Space.World);
        }

        if(Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            playerRB.AddForce(new Vector3(0, jumpForce * Time.deltaTime, 0), ForceMode.Impulse);
            isJumping = true;
        }
    }
}
