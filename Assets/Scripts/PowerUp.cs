using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float multiplayer = 5.2f;
    public GameObject pickupEffect;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Pickup(other);
        }
        void Pickup(Collider player)
        {
            Instantiate(pickupEffect,transform.position,transform.rotation);
            player.transform.localScale *= multiplayer;
            Destroy(gameObject);
            Debug.Log("Power up picked up");
        }
    }
}
