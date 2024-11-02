using UnityEngine;
using UnityEngine.UI;

public class ControlArea : MonoBehaviour
{
    private bool Entered = false;
    public GameObject dialogCanvas;
    public Text dialogText;
    public string dialogMessage = "Это текст диалога.";

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Entered = true;
            dialogText.text = dialogMessage;
            dialogCanvas.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Entered = false;
            dialogCanvas.SetActive(false);
            dialogText.text = "";
        }
    }

    private void Update()
    {
        if (Entered && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Игрок нажал E во время диалога.");
        }
    }
}
