using UnityEngine;

namespace KID
{
    /// <summary>
    /// �ǲ� API �R�A���Ϊk
    /// </summary>
    public class LearnAPIStatic : MonoBehaviour
    {
        private void Start()
        {
            // �R�A�ݩ�
            // 1. ���o Get
            // �y�k�G���O�W��.�R�A�ݩ�
            print($"<color=red>{Random.value}</color>");

            // 2. �]�w Set (Read Only ����]�w)
            // �y�k�G���O�W��.�R�A�ݩ� ���w �ȡF
            // Random.value = 0.3f; ��Ū�ݩʤ���]�w
            Cursor.visible = false;
        }

        private void Update()
        {
            // �R�A��k
            // 3. �ϥΤ�k
            // �y�k�G���O�W��.�R�A��k(�����޼�)
            print(Random.Range(0, 3));
        }
    }
}
