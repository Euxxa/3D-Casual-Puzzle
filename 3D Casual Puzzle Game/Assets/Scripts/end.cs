using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    [Tooltip("Панель UI, которую нужно показать при прохождении уровня. Убедитесь, что она назначена!")]
    public GameObject levelCompletePanel;

    private void OnTriggerEnter(Collider other)
    {
        ShowLevelCompletePanel(); 
    }

    private void ShowLevelCompletePanel()
    {
        if (levelCompletePanel != null)
        {
            levelCompletePanel.SetActive(true); // Активируем панель
        }
        else
        {
            Debug.LogError("Панель LevelComplete не назначена в скрипте!");
        }
    }
}