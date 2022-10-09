using UnityEngine;

namespace KID
{
    /// <summary>
    /// 敵人系統
    /// </summary>
    public class EnemySystem : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("敵人資料")]
        private DataEnemy dataEnemy;
        [SerializeField, Header("動畫控制器攻擊動畫名稱")]
        private string nameAnimationAttack = "死神_攻擊";

        private Rigidbody2D rig;
        private Animator ani;
        private bool isGroundForward;
        private string parWalk = "開關走路";
        private bool lookAttackTarget;
        private Transform traAttackTarget;
        private EnemyAttack enemyAttack;
        #endregion

        #region 事件
        private void Awake()
        {
            rig = GetComponent<Rigidbody2D>();
            ani = GetComponent<Animator>();
            enemyAttack = GetComponent<EnemyAttack>();
        }

        private void Update()
        {
            Wander();
            CheckGroundForward();
            Flip();
            CheckAttackTarget();
            LookAttackTarget();
        }

        private void OnDrawGizmos()
        {
            #region 檢查地板
            Gizmos.color = dataEnemy.checkGroundColor;
            Gizmos.DrawCube(
                transform.position +
                transform.TransformDirection(dataEnemy.checkGroundOffset),
                dataEnemy.checkGroundSize);
            #endregion

            #region 檢查攻擊目標
            Gizmos.color = dataEnemy.checkTargetColor;
            Gizmos.DrawCube(
                transform.position +
                transform.TransformDirection(dataEnemy.checkTargetOffset),
                dataEnemy.checkTargetSize);
            #endregion

            Gizmos.color = dataEnemy.attackRangeColor;
            Gizmos.DrawLine(transform.position, transform.position + -transform.right * dataEnemy.attackRange);
        }
        #endregion

        #region 方法
        /// <summary>
        /// 遊走
        /// </summary>
        private void Wander()
        {
            // 如果 目前動畫名稱 為 死神_攻擊 就跳出
            if (ani.GetCurrentAnimatorStateInfo(0).IsName(nameAnimationAttack)) return;

            if (lookAttackTarget) return;
            rig.velocity = -transform.right * new Vector2(dataEnemy.speed, rig.velocity.y);
            ani.SetBool(parWalk, rig.velocity.x != 0);
        }

        /// <summary>
        /// 偵測前方是否有地板
        /// </summary>
        private void CheckGroundForward()
        {
            Collider2D hit = Physics2D.OverlapBox(
                transform.position + 
                transform.TransformDirection(dataEnemy.checkGroundOffset),
                dataEnemy.checkGroundSize, 0, dataEnemy.checkGroundLayer);

            // print("前方是否有地板物件：" + hit.gameObject);

            isGroundForward = hit;
        }

        /// <summary>
        /// 偵測前方是否有攻擊目標
        /// </summary>
        private void CheckAttackTarget()
        {
            Collider2D hit = Physics2D.OverlapBox(
                transform.position +
                transform.TransformDirection(dataEnemy.checkTargetOffset),
                dataEnemy.checkTargetSize, 0, dataEnemy.checkTargetLayer);

            // print("前方是否有攻擊目標：" + hit.gameObject);

            lookAttackTarget = hit;
            if (hit) traAttackTarget = hit.transform;   // 如果有碰到物件就儲存變形元件
        }

        /// <summary>
        /// 看見攻擊目標
        /// </summary>
        private void LookAttackTarget()
        {
            if (lookAttackTarget)
            {
                float dis = Vector3.Distance(transform.position, traAttackTarget.position);
                // print("距離：" + dis);

                // 如果 目前動畫名稱 為 死神_攻擊 就跳出
                if (ani.GetCurrentAnimatorStateInfo(0).IsName(nameAnimationAttack)) return;

                if (dis > dataEnemy.attackRange)
                {
                    rig.velocity = -transform.right * new Vector2(dataEnemy.speed, rig.velocity.y);
                }
                else 
                {
                    Attack();
                }

                ani.SetBool(parWalk, rig.velocity.x != 0);
            }
        }

        /// <summary>
        /// 攻擊
        /// </summary>
        private void Attack()
        {
            rig.velocity = Vector3.zero;
            enemyAttack.StartAttack();
        }

        /// <summary>
        /// 翻面
        /// </summary>
        private void Flip()
        {
            if (!isGroundForward)
            {
                float yAngle = transform.eulerAngles.y;
                transform.eulerAngles = new Vector3(0, yAngle == 0 ? 180 : 0, 0);
            }
        }
        #endregion
    }
}
