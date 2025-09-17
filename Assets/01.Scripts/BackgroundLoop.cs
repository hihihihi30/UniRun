using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    private float width; //����� ���α���

    private void Awake() //���� ���̸� �����ϴ� ó��
    {
        //BoxCollider2D ������Ʈ�� size �ʵ��� X ���� ���� ���̷� ���
        BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();
        width = backgroundCollider.size .x;
    }

    void Update()
    {
        //���� ��ġ�� �������� �������� width �̻� �̵����� �� ��ġ�� ���ġ
        if(transform.position.x  <= -width)
        {
            Reposition();
        }
        
    }
    //��ġ�� ���ġ�ϴ� �޼���
    private void Reposition()
    {
        //���� ��ġ���� ���������� ���α��� *2��ŭ �̵�
        Vector2 offset = new Vector2(width * 2f, 0);
        transform.position = (Vector2) transform.position + offset;
    }
}
