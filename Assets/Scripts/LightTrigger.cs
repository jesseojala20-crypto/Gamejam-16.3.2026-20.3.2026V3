using UnityEngine;
using UnityEngine.Rendering.Universal; // <--- THIS IS THE KEY

public class LightTrigger : MonoBehaviour
{
    // Note: This must now say Light2D, not Light
    public Light2D areaLight;
    public float targetIntensity = 0.5f;

    void Start()
    {
        print(this.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("2D Light Activated!");
            areaLight.intensity = targetIntensity;
        }
    }
}