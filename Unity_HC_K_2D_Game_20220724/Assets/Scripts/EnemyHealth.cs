using UnityEngine;

namespace KID
{
    /// <summary>
    /// 敵人血量系統
    /// </summary>
    public class EnemyHealth : HealthSystem
    {
        protected override void Dead()
        {
            base.Dead();

            DropProp();
        }

        private void DropProp()
        {

        }
    }
}
