using UnityEngine;

namespace KID
{
    /// <summary>
    /// ���a�����t�ΡG�z�L��L����
    /// </summary>
    public class PlayerAttack : AttackSystem
    {
        [SerializeField, Header("������J����")]
        private KeyCode keyAttack = KeyCode.Mouse0;

        private void Update()
        {
            InputCheck();
        }

        /// <summary>
        /// �ˬd��J��������
        /// </summary>
        private void InputCheck()
        {
            if (Input.GetKeyDown(keyAttack))
            {
                StartAttack();
            }
        }
    }
}
