using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int numberOfShrines{get; private set;}

    public UnityEvent<PlayerInventory> onShrineCollected;

    public void ShrineCollected()
    {
        numberOfShrines++;
        onShrineCollected.Invoke(this);
    }
}
