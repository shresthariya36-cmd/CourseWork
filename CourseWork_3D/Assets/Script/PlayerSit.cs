using UnityEngine;

public class PlayerSit : MonoBehaviour
{
    private Animator animator;
    private bool isSitting = false;

    public Transform sitPoint;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!isSitting)
            {
                transform.position = sitPoint.position;
                transform.rotation = sitPoint.rotation;
                isSitting = true;
            }
            else
            {
                isSitting = false;
            }

            animator.SetBool("IsSitting", isSitting);
        }
    }
}