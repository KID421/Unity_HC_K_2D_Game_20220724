using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace KID
{
    /// <summary>
    /// 玩家血量系統
    /// </summary>
    public class PlayerHealth : HealthSystem
    {
        private Image imgHp;

        protected override void Awake()
        {
            base.Awake();

            imgHp = GameObject.Find("血條").GetComponent<Image>();
        }

        public override void Hurt(float getDamage)
        {
            base.Hurt(getDamage);

            imgHp.fillAmount = hp / hpMax;
        }

        protected override void Dead()
        {
            base.Dead();

            gameObject.layer = 8;

            Invoke("Replay", 3);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains("死亡區域")) Hurt(99999);
        }

        /// <summary>
        /// 重新遊戲
        /// </summary>
        private void Replay()
        {
            SceneManager.LoadScene("遊戲場景");
        }
    }
}
