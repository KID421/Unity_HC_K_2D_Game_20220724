using UnityEngine;

namespace KID
{
    /// <summary>
    /// �ǲߤ�k�G�x�s�{���϶� (Code Block)�A
    /// ��k�B�禡�B��ơB�\��BMethod�BFunction
    /// </summary>
    public class LearnMethod : MonoBehaviour
    {
        // ��k�y�k�G
        // �� �׹��� �Ǧ^������� ��k�ۭq�W�� () { �{���϶� }
        // �L�Ǧ^���� void
        private void Test()
        {
            print("����");
        }

        // Ctrl + K D �۰ʮ榡�� (�ƪ�)

        private void Start()
        {
            // �I�s��k
            Test();
            Test();
            Test();

            int ten = ReturnTen();

            print("���G�G" + ten);
        }

        private int ReturnTen()
        {
            // return �Ǧ^
            return 10;
        }
    }
}

