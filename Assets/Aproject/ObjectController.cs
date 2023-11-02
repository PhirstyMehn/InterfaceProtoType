using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    [SerializeField] private ObjectData myData;

    public string GetName()
    {
        return myData.objectName;
    }
    public int GetMaxHealth() { return myData.maxHealth; }
    public int GetCurrentHealth() { return myData.currentHealth; }

    
}
