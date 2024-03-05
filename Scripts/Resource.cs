using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
    public int value = 0;
    public string resourceName = "";

    // Don't know yet if I can do this or if I need to return the object and
    // then Destroy this object in the function calling this one
    public string PickUp()
    {
        Destroy(gameObject);
        return resourceName;
    }
}