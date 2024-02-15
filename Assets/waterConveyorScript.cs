using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterConveyorScript : MonoBehaviour
{
    // I shamelessly stole basically this entire script off of youtube.

    [SerializeField]
    private float speed;
    [SerializeField]
    private Vector3 direction;
    [SerializeField]
    private List<GameObject> onBelt;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i <= onBelt.Count - 1; i++)
        {
            onBelt[i].GetComponent<Rigidbody>().velocity = speed * direction;
        }
    }

    // when something collides with the belt
    private void OnTriggerEnter(Collider fruit)
    {
        onBelt.Add(fruit.gameObject);
    }

    // when something leaves the belt
    private void OnCollisionExit(Collider fruit)
    {
        onBelt.Remove(fruit.gameObject);
    }
}
