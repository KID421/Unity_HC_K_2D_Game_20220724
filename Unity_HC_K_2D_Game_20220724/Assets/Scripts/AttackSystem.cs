using UnityEngine;
using System.Collections;

namespace KID
{
    /// <summary>
    /// 攻擊系統
    /// </summary>
    public class AttackSystem : MonoBehaviour
    {
        [SerializeField, Header("攻擊資料")]
        private DataAttack dataAttack;

        private Animator ani;
        private bool isAttacking;

        private void Awake()
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

        /// <summary>
        /// 檢查攻擊區域
        /// </summary>
        private void CheckAttackArea()
        {
            Collider2D hit = Physics2D.OverlapBox(
                transform.position +
                transform.TransformDirection(dataAttack.attackAreaOffset),
                dataAttack.attackAreaSize, 0, dataAttack.attackAreaLayer);

            print("攻擊到的物件：" + hit);
        }

        /// <summary>
        /// 開始攻擊
        /// </summary>
        public void StartAttack()
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
        }
    }
}

