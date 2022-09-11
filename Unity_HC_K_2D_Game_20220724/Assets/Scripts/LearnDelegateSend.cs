using UnityEngine;

namespace KID
{
    /// <summary>
    /// �ǲߩe���G�ǰe��
    /// </summary>
    public class LearnDelegateSend : MonoBehaviour
    {
        private int number = 99;
        private LearnDelegateReceive receive;

        #region �e������
        // 1. �ݭn�ǻ�����k
        // 2. �w�q�e��
        // 3. �ϥΩe��
        #endregion

        private void Awake()
        {
            receive = FindObjectOfType<LearnDelegateReceive>();
            receive.ReceiveData(number);

            // 3. �ϥΩe��
            // 3-2 �Ѽƶǻ�
            receive.ReceiveMethod(MethodOne);
            receive.ReceiveMethodTwo(WeaponAttack);
        }

        // 1. �w�q��k
        // �d�ҡG�L�Ǧ^�L�Ѽ�
        private void MethodOne()
        {
            print("�ڬO��k�@");
        }

        private void WeaponAttack(int attack)
        {
            attack *= 100;
            print("�Z���u��ˮ`�G" + attack);
        }
    }
}
