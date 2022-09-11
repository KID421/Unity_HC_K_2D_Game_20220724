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
        private bool isGroundForward;

        private void Awake()
        {
            rig = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            Wander();
            CheckGroundForward();
            Flip();
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = dataEnemy.checkGroundColor;
            Gizmos.DrawCube(
                transform.position + dataEnemy.checkGroundOffset,
                dataEnemy.checkGroundSize);
        }

        /// <summary>
        /// 遊走
        /// </summary>
        private void Wander()
        {
            rig.velocity = new Vector2(-dataEnemy.speed, rig.velocity.y);
        }

        /// <summary>
        /// 偵測前方是否有地板
        /// </summary>
        private void CheckGroundForward()
        {
            Collider2D hit = Physics2D.OverlapBox(
                transform.position + dataEnemy.checkGroundOffset,
                dataEnemy.checkGroundSize, 0, dataEnemy.checkGroundLayer);

            // print("前方是否有地板物件：" + hit.gameObject);

            isGroundForward = hit;
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
