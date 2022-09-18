using UnityEngine;

namespace KID
{
    /// <summary>
    /// 玩家攻擊系統：透過鍵盤控制
    /// </summary>
    public class PlayerAttack : AttackSystem
    {
        [SerializeField, Header("攻擊輸入按鍵")]
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
        /// 檢查輸入攻擊按鍵
        /// </summary>
        private void InputCheck()
        {
            if (Input.GetKeyDown(keyAttack))
            {
                StartAttack();
            }
        }

        // override 複寫父類別有 virtual 關鍵字的成員
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
