using UnityEngine;
using System.Collections;

namespace KID
{
    /// <summary>
    /// 攻擊系統
    /// </summary>
    public class AttackSystem : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("攻擊資料")]
        private DataAttack dataAttack;

        private Animator ani;
        private bool isAttacking;
        #endregion

        #region 事件
        protected virtual void Awake()
        {
            ani = GetComponent<Animator>();
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = dataAttack.attackAreaColor;
            Gizmos.DrawCube(
                transform.position +
                transform.TransformDirection(dataAttack.attackAreaOffset),
                dataAttack.attackAreaSize);
        }
        #endregion

        #region 方法
        /// <summary>
        /// 檢查攻擊區域
        /// </summary>
        private void CheckAttackArea()
        {
            Collider2D hit = Physics2D.OverlapBox(
                transform.position +
                transform.TransformDirection(dataAttack.attackAreaOffset),
                dataAttack.attackAreaSize, 0, dataAttack.attackAreaLayer);

            // print("攻擊到的物件：" + hit);

            if (hit) hit.GetComponent<HealthSystem>().Hurt(dataAttack.attack);
        }

        // virtual 虛擬：允許子類別使用複寫關鍵字複寫 overrride
        /// <summary>
        /// 開始攻擊
        /// </summary>
        public virtual void StartAttack()
        {
            if (isAttacking) return;
            isAttacking = true;
            ani.SetTrigger(dataAttack.parAttack);
            StartCoroutine(Attacking());
        }

        /// <summary>
        /// 攻擊中
        /// </summary>
        private IEnumerator Attacking()
        {
            yield return new WaitForSeconds(dataAttack.delaySendDamage);
            CheckAttackArea();
            yield return new WaitForSeconds(dataAttack.attackTime);
            isAttacking = false;
            StopAttack();
        }

        // protected 保護級別：允許子類別存取或複寫
        protected virtual void StopAttack()
        {

        }
        #endregion
    }
}

