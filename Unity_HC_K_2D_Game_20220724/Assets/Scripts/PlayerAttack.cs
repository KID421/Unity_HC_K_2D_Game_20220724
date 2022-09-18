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
    }
}
