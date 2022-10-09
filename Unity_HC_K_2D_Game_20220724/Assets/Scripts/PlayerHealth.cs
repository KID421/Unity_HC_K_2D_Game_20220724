using UnityEngine;

namespace KID
{
    /// <summary>
    /// 玩家血量系統
    /// </summary>
    public class PlayerHealth : HealthSystem
    {
        protected override void Dead()
        {
            base.Dead();

            gameObject.layer = 8;
        }
    }
}
