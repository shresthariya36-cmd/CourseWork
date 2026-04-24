using UnityEngine;

public class WallSwitch : MonoBehaviour
{
    public Transform player;

    public Light light1;

    public float interactRange = 2f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float distance = Vector3.Distance(transform.position, player.position);

            if (distance <= interactRange)
            {
                ToggleLights();
            }
        }
    }

    void ToggleLights()
    {
        if (light1 != null) light1.enabled = !light1.enabled;
    }
}