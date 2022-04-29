using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // message displayed to the player when looking on the interactible
    public string promtMessage;

    public void BaseInteract()
    {
        Interact();
    }
    protected virtual void Interact()
    {
        //i wont code here, this function will be changed by subbclasses
    }
}
