using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object in a fixed velocity.
 * Velocity is defined as speed+direction.
 * speed is a number, velocity is a vector.
 */
public class Mover : MonoBehaviour
{
    [Tooltip("Movement vector in meters per second")] [SerializeField] Vector3 velocity;

    void Update()
    {
        transform.position += velocity * Time.deltaTime;
    }

    public void SetVelocity(Vector3 newVelocity)
    {
        this.velocity = newVelocity;
    }
}
