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

        private MoveSystem moveSystem;
        private JumpSystem jumpSystem;

        protected override void Awake()
        {
            base.Awake();

            moveSystem = GetComponent<MoveSystem>();
            jumpSystem = GetComponent<JumpSystem>();
        }

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

        // override �Ƽg�����O�� virtual ����r������
        public override void StartAttack()
        {
            base.StartAttack();

            moveSystem.enabled = false;
            jumpSystem.enabled = false;
        }

        protected override void StopAttack()
        {
            base.StopAttack();

            moveSystem.enabled = true;
            jumpSystem.enabled = true;
        }
    }
}
