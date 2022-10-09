using UnityEngine;

namespace KID
{
    /// <summary>
    /// 血量系統
    /// </summary>
    public class HealthSystem : MonoBehaviour
    {
        [SerializeField, Header("血量資料")]
        private DataHealth dataHealth;

        private float hp;
        private float hpMax;

        private Animator ani;

        private void Awake()
        {
            ani = GetComponent<Animator>();

            hp = dataHealth.hp;
            hpMax = hp;
        }

        /// <summary>
        /// 受傷
        /// </summary>
        /// <param name="getDamage">接收到的傷害</param>
        public void Hurt(float getDamage)
        {
            hp -= getDamage;
            if (hp <= 0) Dead();

            print(gameObject + " 血量：" + hp);
        }

        /// <summary>
        /// 死亡
        /// </summary>
        private void Dead()
        {
            hp = 0;
            ani.SetBool(dataHealth.parDead, true);
        }
    }
}
