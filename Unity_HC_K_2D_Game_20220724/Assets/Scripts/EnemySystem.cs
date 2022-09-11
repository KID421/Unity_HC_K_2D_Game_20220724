using UnityEngine;

namespace KID
{
    /// <summary>
    /// �ĤH�t��
    /// </summary>
    public class EnemySystem : MonoBehaviour
    {
        [SerializeField, Header("�ĤH���")]
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
        /// �C��
        /// </summary>
        private void Wander()
        {
            rig.velocity = new Vector2(-dataEnemy.speed, rig.velocity.y);
        }

        /// <summary>
        /// �����e��O�_���a�O
        /// </summary>
        private void CheckGroundForward()
        {
            Collider2D hit = Physics2D.OverlapBox(
                transform.position + dataEnemy.checkGroundOffset,
                dataEnemy.checkGroundSize, 0, dataEnemy.checkGroundLayer);

            // print("�e��O�_���a�O����G" + hit.gameObject);

            isGroundForward = hit;
        }

        /// <summary>
        /// ½��
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
