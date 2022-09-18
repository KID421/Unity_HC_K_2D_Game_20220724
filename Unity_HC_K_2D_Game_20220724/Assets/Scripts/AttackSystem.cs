using UnityEngine;
using System.Collections;

namespace KID
{
    /// <summary>
    /// �����t��
    /// </summary>
    public class AttackSystem : MonoBehaviour
    {
        [SerializeField, Header("�������")]
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
        /// �ˬd�����ϰ�
        /// </summary>
        private void CheckAttackArea()
        {
            Collider2D hit = Physics2D.OverlapBox(
                transform.position +
                transform.TransformDirection(dataAttack.attackAreaOffset),
                dataAttack.attackAreaSize, 0, dataAttack.attackAreaLayer);

            print("�����쪺����G" + hit);
        }

        /// <summary>
        /// �}�l����
        /// </summary>
        public void StartAttack()
        {
            if (isAttacking) return;
            isAttacking = true;
            ani.SetTrigger(dataAttack.parAttack);
            StartCoroutine(Attacking());
        }

        /// <summary>
        /// ������
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

