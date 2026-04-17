using UnityEngine;

public class InteractUI : MonoBehaviour
{
    public GameObject uiText;
    public float range = 3f;
    public Transform player;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        Debug.Log("Distance: " + distance);

        if (distance <= range)
        {
            uiText.SetActive(true);
        }
        else
        {
            uiText.SetActive(false);
        }
    }
}