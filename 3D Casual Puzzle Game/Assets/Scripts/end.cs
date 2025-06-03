using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    [Tooltip("������ UI, ������� ����� �������� ��� ����������� ������. ���������, ��� ��� ���������!")]
    public GameObject levelCompletePanel;

    private void OnTriggerEnter(Collider other)
    {
        ShowLevelCompletePanel(); 
    }

    private void ShowLevelCompletePanel()
    {
        if (levelCompletePanel != null)
        {
            levelCompletePanel.SetActive(true); // ���������� ������
        }
        else
        {
            Debug.LogError("������ LevelComplete �� ��������� � �������!");
        }
    }
}