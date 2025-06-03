using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] KeyCode keyOne;// ��������� ���������� keyOne ���� KeyCode.
                                    // [SerializeField] ������ � ������� � ���������� Unity.
    [SerializeField] KeyCode keyTwo;
    [SerializeField] Vector3 moveDirection;// ��������� ���������� moveDirection ���� Vector3.

    private void FixedUpdate()//���������� � ������������� ���������� �������
    {
        if (Input.GetKey(keyOne))//������ �� �������
        {// �������� ��������� Rigidbody ����� ������� � ��������� � ��� �������� �������� ������ moveDirection.
            GetComponent<Rigidbody>().linearVelocity += moveDirection;
        }
        if (Input.GetKey(keyTwo))
        {
            GetComponent<Rigidbody>().linearVelocity -= moveDirection;
        }


    }
    //����������, ����� Collider ������� ������� ������ � ������� ����� �������.
    private void OnTriggerEnter(Collider other)
    {// ���������, ����� �� ���� ������ ��� "Player" � ����� �� ������ ������ (�������� � �������) ��� "Finish".
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {// ��������� ��������� �����.  ������ ��������� ����� ������������ ��� buildIndex ������� ����� + 1.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}