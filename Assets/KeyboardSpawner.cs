using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component spawns the given object whenever a player clicks a given key.
 */
public class KeyboardSpawner : MonoBehaviour
{
    [SerializeField] protected KeyCode keyToPress;
    [SerializeField] protected GameObject prefabToSpawn;
    [SerializeField] protected Vector3 velocityOfSpawnedObject;
    [SerializeField] protected Vector3 rotation;
    [SerializeField] protected float speed;

    protected GameObject spawnObject()
    {
        // Spawn the new object.
        Vector3 positionOfSpawnedObject = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);  // span at the containing object position.
        Quaternion rotationOfSpawnedObject = Quaternion.Euler(rotation);  // vector3 of rotation.
        GameObject newObject = Instantiate(prefabToSpawn, positionOfSpawnedObject, rotationOfSpawnedObject);

        // Modify the velocity of the new object - must have mover component.
        Mover newObjectMover = newObject.GetComponent<Mover>();
        if (newObjectMover)
        {
            newObjectMover.SetVelocity(velocityOfSpawnedObject);
        }
        return newObject;
    }

    private void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            spawnObject();
        }
    }
}
