using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ObjectData", menuName = "Object Data")]
public class ObjectData : ScriptableObject 
{
    public string objectName = "Object Name";
    public int maxHealth;
    public int currentHealth;


}
    

