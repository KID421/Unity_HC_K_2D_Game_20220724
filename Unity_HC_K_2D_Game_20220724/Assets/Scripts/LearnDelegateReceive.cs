using UnityEngine;

namespace KID
{
    /// <summary>
    /// �ǲߩe���G������
    /// </summary>
    public class LearnDelegateReceive : MonoBehaviour
    {
        public void ReceiveData(int getNumberData)
        {
            getNumberData++;
            print("�����쪺��ƥ[�@�G" + getNumberData);
        }

        // 2. �w�q�e���Gñ�������P��k�@��
        // �d�ҡG�L�Ǧ^�L�Ѽ�
        // ñ���G�Ǧ^�����B�ѼƼƶq�P����
        // �e���y�k�G�׹��� �e������r �Ǧ^���� �e���W��(�Ѽ�)�F
        public delegate void delegateOne();

        // 3. �ϥΩe��
        // 3-1 �ѼƩw�q
        public void ReceiveMethod(delegateOne one)
        {
            // 3-3 �ϥΩe��
            one();
        }
    }
}
