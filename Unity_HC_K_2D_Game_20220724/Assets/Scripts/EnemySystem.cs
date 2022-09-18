using UnityEngine;

namespace KID
{
    /// <summary>
    /// 敵人系統
    /// </summary>
    public class EnemySystem : MonoBehaviour
    {
        [SerializeField, Header("敵人資料")]
        private DataEnemy dataEnemy;

        private Rigidbody2D rig;
        private Animator ani;
        private bool isGroundForward;
        private string parWalk = "開關走路";
        private bool lookAttackTarget;
        private Transform traAttackTarget;

        private void Awake()
        {
            rig = GetComponent<Rigidbody2D>();
            ani = GetComponent<Animator>();
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

        /// <summary>
        /// 遊走
        /// </summary>
        private void Wander()
        {
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

                if (dis > dataEnemy.attackRange)
                {
                    rig.velocity = -transform.right * new Vector2(dataEnemy.speed, rig.velocity.y);
                }
                else 
                {
                    rig.velocity = Vector3.zero;
                }

                ani.SetBool(parWalk, rig.velocity.x != 0);
            }
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
    }
}
