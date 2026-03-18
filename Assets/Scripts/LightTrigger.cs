using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    public Light arealight;
    public float targetIntensity = 2.0f;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something entered the trigger!");
        if (other.CompareTag("Player"))
        {
            arealight.intensity = targetIntensity;
        }
    }
}
