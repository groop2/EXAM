using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool IsOpen = false; // Булевая переменная для состояния двери

    private void Update()
    {
        if (IsOpen)
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        // Здесь добавь логику открытия двери (например, анимацию)
        Debug.Log("Дверь открыта"); // Пример логирования
        // После открытия двери можно добавить логику для закрытия, если это нужно
        IsOpen = false; // Сбрасываем состояние после открытия (если дверь должна открываться только один раз)
    }
}
