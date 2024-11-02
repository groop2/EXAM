using UnityEngine;
using UnityEngine.UI;

public class Button1Trigger : MonoBehaviour
{
    public GameObject dialogCanvas;
    public Text questionText;
    public Text responseText;
    public GameObject door;
    public DoorController doorController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            dialogCanvas.SetActive(true);
            questionText.text = "Кого вы спасете: ребенка или маму?";
            responseText.text = "Вы выбрали ребенка.";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            dialogCanvas.SetActive(false);
            questionText.text = "";
            responseText.text = "";
        }
    }

    public void Choose()
    {
        responseText.text += "\nСделал ли ты правильный выбор?";
        Invoke("OpenDoor", 3f);
    }

    private void OpenDoor()
    {
        dialogCanvas.SetActive(false);
        responseText.text = "";
        doorController.IsOpen = true;
    }
}
