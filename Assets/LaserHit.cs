using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserHit : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField] string playerLivesTag;

    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled) // Check if there was a hit
        {
            // Get game object of the player lives by their tag and check if exists
            GameObject newObject = GameObject.FindGameObjectWithTag(playerLivesTag);
            if (newObject)
            {
                HitPoints numberOfHits = newObject.GetComponent<HitPoints>();
                Destroy(other.gameObject);
                numberOfHits.decrementHit();
            }
        }
    }
    // Update is called once per frame
    void Update()
    {     
    }
}
