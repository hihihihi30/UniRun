using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    public float speed = 10f; // �̵��ӵ�

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�ʴ� speed�� �ӵ��� �������� �����̵�
      transform.Translate(Vector3.left * speed * Time.deltaTime);  
    }
}
