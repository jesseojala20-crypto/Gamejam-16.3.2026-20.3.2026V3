using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject winScreen;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            winScreen.SetActive(true);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
