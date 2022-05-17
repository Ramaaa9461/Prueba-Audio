using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (CharacterController))]
public class Movement : MonoBehaviour
{
    [SerializeField] KeyCode Up;
    [SerializeField] KeyCode Down;
    [SerializeField] KeyCode Right;
    [SerializeField] KeyCode Left;

    [SerializeField] float velocityX;
    [SerializeField] float velocityY;

    CharacterController characterController;

    Vector3 directionMove;
    private float jumpHeight = 1.9f;
    private float gravityScale = 20f;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {

        if (Input.GetKey(Up))
        {
            characterController.SimpleMove(transform.forward * velocityY);
        }
        if (Input.GetKey(Down))
        {
            characterController.SimpleMove(-transform.forward * velocityY);
        }

        if (Input.GetKey(Left))
        {
            transform.eulerAngles += Vector3.down * velocityX * Time.deltaTime;
        }
        if (Input.GetKey(Right))
        {
            transform.eulerAngles += Vector3.up * velocityX * Time.deltaTime;
        }

    }
}
