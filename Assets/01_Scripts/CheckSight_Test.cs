using UnityEngine;

public class CheckSight_Test : MonoBehaviour
{
    [SerializeField]
    private int sightRadius; //�þ� ���� ����
    [SerializeField]
    private Vector2 targetPos;//Ÿ�� ��ġ
    private bool targetFound; //Ÿ�� �߰� ����








    public void FindTarget(Vector2 pos)
    {
        targetFound = true;
        targetPos = pos;
    }
}
