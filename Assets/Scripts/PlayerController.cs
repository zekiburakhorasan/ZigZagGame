using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rigitBody;
    bool lookingRight;
    GameManager gameManager;
    Animator animController;
    public Transform rayOrijin;

	void Start ()
    {
        lookingRight = true;
        gameManager = FindObjectOfType<GameManager>();
        animController = GetComponent<Animator>();
    }
	
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ChangeDirection();
        }

        if(transform.position.y < -2)
        {
            gameManager.RestartGame();
        }
	}

    private void ChangeDirection()
    {
        lookingRight = !lookingRight;
        if(lookingRight)
        {
            transform.rotation = Quaternion.Euler(0, 45, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, -45, 0);
        }
    }

    private void FixedUpdate()
    {
        if(!gameManager.isGameStarted) return;

        else
        {
            animController.SetTrigger("gameStarted");
            rigitBody.position += transform.forward * Time.deltaTime;

            if(!Physics.Raycast(rayOrijin.position, Vector3.down))
            {
                animController.SetTrigger("falling");
            }
        }
    }
}
