using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator animator;
    public bool IsOpen;

    private void Update()
    {
        animator.SetBool("IsOpen", IsOpen);
    }
}
