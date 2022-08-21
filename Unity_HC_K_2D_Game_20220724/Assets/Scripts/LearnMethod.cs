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
        // �Ѽƻy�k�G������� �ѼƦW�١A������� �ѼƦW�١A...
        // �� �׹��� �Ǧ^������� ��k�ۭq�W�� (�Ѽ�) { �{���϶� }
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

            AddTen(7);
            Add(100, 300);
            Add(50, 999);
            // ���y�A�������A�z��
            Skill("���y", effect: "�z��");
            Skill("�B�y");
            Skill("�q�y", "������");
        }

        private int ReturnTen()
        {
            // return �Ǧ^
            return 10;
        }

        private void AddTen(int number)
        {
            number = number + 10;
            print("�Ʀr�[�Q�᪺���G�G" + number);
        }

        private void Add(int numberA, int numberB)
        {
            print("<color=yellow>�Ʀr�ۥ[�����G" + (numberA + numberB) + "</color>");
        }

        // �I��ޯ�G���y�B�B�y�B�q�y...
        // ���w�]�Ȫ��ѼơG��ܦ��Ѽ� - �����g�b�̥k��A�I�s�ɤ���|�H�w�]�ȱa�J
        private void Skill(string skillType, string sound = "������", string effect = "�H��")
        {
            print("�I��ޯ�S�ġG" + skillType);
            print("�ޯ୵�ġG" + sound);
            print($"�ޯ���a�S�ġG {effect}");
        }
    }
}

