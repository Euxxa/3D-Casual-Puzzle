using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    //�������� ����� �� ���������� ������
    public void ChangeScenes(int numberScenes)
    {
        SceneManager.LoadScene(numberScenes);//�������� ����� �� �������
    }
    
    //������������ ������� �����
    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//�������� ��� ������� �������� �����
                                                                   //����� ��������� ����� �� �����, ����� ������������� ��
    }
    //�������� ����������
    public void Exit()
    {
        Application.Quit();
    }
}