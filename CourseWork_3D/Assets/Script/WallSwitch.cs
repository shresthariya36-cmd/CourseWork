using UnityEngine;

public class WallSwitch : MonoBehaviour
{
    public Transform player;

    public Light light1;
    public Light light2;
    public Light light3;

    public float interactRange = 2.25f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float distance = Vector3.Distance(transform.position, player.position);

            Debug.DrawLine(transform.position, player.position, Color.red);

            if (distance <= interactRange)
            {
                ToggleLights();
            }
        }
    }

    void ToggleLights()
    {
        if (light1 != null) light1.enabled = !light1.enabled;
        if (light2 != null) light2.enabled = !light2.enabled;
        if (light3 != null) light3.enabled = !light3.enabled;
    }
}