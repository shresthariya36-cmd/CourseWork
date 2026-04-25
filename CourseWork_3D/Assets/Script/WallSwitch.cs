using UnityEngine;

public class WallSwitch : MonoBehaviour
{
    public Transform player;
    public Light roomLight;

    public float interactRange = 2.25f;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= interactRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (roomLight != null)
                {
                    roomLight.enabled = !roomLight.enabled;
                }
            }
        }
    }
}