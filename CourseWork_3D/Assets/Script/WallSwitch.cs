using UnityEngine;

public class WallSwitch : MonoBehaviour
{
    public Transform player;

    public Light light1;
    public Light light2;

    public float interactRange = 2.25f;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= interactRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (light1 != null) light1.enabled = !light1.enabled;
                if (light2 != null) light2.enabled = !light2.enabled;
            }
        }
    }
}