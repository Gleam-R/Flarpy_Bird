using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpForce = 5;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive == true || Input.GetMouseButtonDown(0) == true && birdIsAlive == true)
        {
            myRigidbody.velocity = new Vector2(0, jumpForce);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;
    }
}
