using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button2Trigger : MonoBehaviour
{
    public Text dialogueText; // Ссылка на текстовое поле для диалога
    public Animator doorAnimator; // Ссылка на Animator двери
    private bool hasInteracted = false; // Флаг для отслеживания взаимодействия

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player") && !hasInteracted)
        {
            dialogueText.text = "Press T to choose: Save the mother.";
            Debug.Log("Player entered Button 2 trigger."); // Дебаг сообщение
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            dialogueText.text = ""; // Скрыть текст при выходе из триггера
            Debug.Log("Player exited Button 2 trigger."); // Дебаг сообщение
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && !hasInteracted)
        {
            StartCoroutine(Choose());
        }
    }

    private IEnumerator Choose()
    {
        hasInteracted = true; // Устанавливаем флаг, что взаимодействие произошло
        dialogueText.text = "You chose to save the mother.";
        Debug.Log("Player chose Button 2."); // Дебаг сообщение
        yield return new WaitForSeconds(2); // Задержка, чтобы текст был виден
        dialogueText.text = ""; // Скрыть текст

        // Вызов анимации открытия двери
        doorAnimator.SetBool("IsOpen", true);
        Debug.Log("Door animator parameter set to open."); // Дебаг сообщение
    }
}
