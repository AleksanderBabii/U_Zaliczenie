using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI shrineText;

    // Start is called before the first frame update
    void Start()
    {
        shrineText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateShrineText(PlayerInventory playerInventory)
    {
        shrineText.text = playerInventory.numberOfShrines.ToString();
    }
}
