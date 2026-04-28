using UnityEngine;
using UnityEngine.UI;

public class PopupInteract : MonoBehaviour
{
    public Transform player;
    public GameObject popupText;
    public float interactRange = 3f;

    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);

        if (distance <= interactRange)
        {
            popupText.SetActive(true);
        }
        else
        {
            popupText.SetActive(false);
        }
    }
}