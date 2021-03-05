using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObjectInteraction : MonoBehaviour
{
    public void HoverOver()
    {
        GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
    }

    public void HoverEnder()
    {
        GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }

    public void Select()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
}
