using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    //загрузка сцены по указанному номеру
    public void ChangeScenes(int numberScenes)
    {
        SceneManager.LoadScene(numberScenes);//загрузка сцены по индексу
    }
    
    //перезагрузка текущей сцены
    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//получаем имя текущей актимной сцены
                                                                   //затем загружаем сцену по имени, чтобы перезагрузить ее
    }
    //закрытие приложения
    public void Exit()
    {
        Application.Quit();
    }
}