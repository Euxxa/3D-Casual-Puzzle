using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] KeyCode keyOne;// Объявляем переменную keyOne типа KeyCode.
                                    // [SerializeField] делает её видимой в инспекторе Unity.
    [SerializeField] KeyCode keyTwo;
    [SerializeField] Vector3 moveDirection;// Объявляем переменную moveDirection типа Vector3.

    private void FixedUpdate()//вызывается с фиксированным интервалом времени
    {
        if (Input.GetKey(keyOne))//нажата ли клавиша
        {// Получаем компонент Rigidbody этого объекта и добавляем к его линейной скорости вектор moveDirection.
            GetComponent<Rigidbody>().linearVelocity += moveDirection;
        }
        if (Input.GetKey(keyTwo))
        {
            GetComponent<Rigidbody>().linearVelocity -= moveDirection;
        }


    }
    //вызывается, когда Collider другого объекта входит в триггер этого объекта.
    private void OnTriggerEnter(Collider other)
    {// Проверяем, имеет ли этот объект тег "Player" и имеет ли другой объект (вошедший в триггер) тег "Finish".
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {// Загружаем следующую сцену.  Индекс следующей сцены определяется как buildIndex текущей сцены + 1.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}