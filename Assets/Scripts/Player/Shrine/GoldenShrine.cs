using UnityEngine;
using UnityEngine.SceneManagement;

public class GoldenShrine : MonoBehaviour
{
    public GameObject hitEffect;
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.ShrineCollected();
            gameObject.SetActive(false);
            SceneManager.LoadScene("GoldenShrineMenu");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 4f);
        
    }
}
