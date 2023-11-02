using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{

    [SerializeField] private bool isInteractable = false;

    public bool GetIsInteractable() 
    {
        return isInteractable;
    }
    public void SetIsInteractable(bool setting) 
    {
        isInteractable = setting;
    }
}
