using System;
using UnityEngine;

public class UpDownMovement : MonoBehaviour
{
    private UpDownController controller;
    private Rigidbody2D movementRigidbody;
    
    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<UpDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += move;
    }

    private void move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        movementRigidbody.velocity = direction;
    }
}