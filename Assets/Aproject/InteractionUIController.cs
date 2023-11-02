using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractionUIController : MonoBehaviour
{
  public static InteractionUIController instance;

    public TMPro.TMP_Text objectStuff;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void TellAboutObject(string name, int curHealth, int maxHealth)
    {
        objectStuff.text = name+" " + curHealth.ToString() + "/" + maxHealth.ToString() + " Health";
    }
    public void TellAboutObject(string name)
    {
        objectStuff.text = name;
    }
    public void ClearText()
    {
        objectStuff.text = string.Empty;
    }
}
