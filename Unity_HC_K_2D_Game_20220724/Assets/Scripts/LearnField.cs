using UnityEngine;

namespace KID
{
    /// <summary>
    /// �ǲ���� Field�A�O�s�C���������
    /// </summary>
    public class LearnField : MonoBehaviour
    {
        // ���y�k�G
        // ������� ���ۭq�W�١F
        // ������� ���ۭq�W�� ���w �ȡF

        // ���w�Ÿ� = �N�k�����������

        // �׹��� ������� ���ۭq�W�� ���w �ȡF
        int number;

        // �T�����
        // CC ��
        // ���q
        // �~�P
        // �O�_���ѵ�

        // �׹����w�]���p�H
        // �p�H private ����ܤ����\�~���s��
        // ���} public ��ܤ��\�~���s��
        public int cc = 1500;
        public float weight = 3.5f;
        public string brand = "�S����";
        public bool hasSkyWindow = true;

        // ����ݩ� [�ݩʦW��(��)]
        // 1. ���� Tooltip(�r��)
        // 2. ���D Header(�r��)
        // 3. �d�� Range(�ƭȫ��A�A�ƭȫ��A)
        [Tooltip("�o�O���a���ƶq.....")]
        public int count;
        [Header("�����O")]
        public float attack = 10.5f;
    }
}
