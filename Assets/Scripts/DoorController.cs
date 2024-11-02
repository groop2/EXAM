using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool IsOpen = false; // Булевая переменная для состояния двери
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>(); // Получаем компонент Animator
    }

    private void Update()
    {
        animator.SetBool("IsOpen", IsOpen); // Устанавливаем значение переменной IsOpen в Animator
    }
}
