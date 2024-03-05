using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mineable : MonoBehaviour
{
    [SerializeField] private int durability;
    [SerializeField] private GameObject dropsResource;

    public void Mine(int damage)
    {
        Debug.Log("Mining resource for " + damage + " damage");
        durability -= damage;
        if (durability <= 0)
        {
            Debug.Log("Resource destroyed");
            
            // Play any effects here
            
            Instantiate(dropsResource, gameObject.transform.position + Vector3.down * 0.5f, Quaternion.Euler(45, 0, 45));
            Destroy(gameObject);
        }
    }

}