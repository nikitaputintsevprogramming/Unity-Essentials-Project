using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public float rotationSpeed;

    public GameObject onCollectEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, rotationSpeed, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            //”ничтожить коллекционный предмет
            Destroy(gameObject);

            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
    }
}
