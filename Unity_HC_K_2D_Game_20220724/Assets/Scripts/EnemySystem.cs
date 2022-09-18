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
        [SerializeField, Header("�ʵe��������ʵe�W��")]
        private string nameAnimationAttack = "����_����";

        private Rigidbody2D rig;
        private Animator ani;
        private bool isGroundForward;
        private string parWalk = "�}������";
        private bool lookAttackTarget;
        private Transform traAttackTarget;
        private EnemyAttack enemyAttack;

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
            #region �ˬd�a�O
            Gizmos.color = dataEnemy.checkGroundColor;
            Gizmos.DrawCube(
                transform.position +
                transform.TransformDirection(dataEnemy.checkGroundOffset),
                dataEnemy.checkGroundSize);
            #endregion

            #region �ˬd�����ؼ�
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
        /// �C��
        /// </summary>
        private void Wander()
        {
            // �p�G �ثe�ʵe�W�� �� ����_���� �N���X
            if (ani.GetCurrentAnimatorStateInfo(0).IsName(nameAnimationAttack)) return;

            if (lookAttackTarget) return;
            rig.velocity = -transform.right * new Vector2(dataEnemy.speed, rig.velocity.y);
            ani.SetBool(parWalk, rig.velocity.x != 0);
        }

        /// <summary>
        /// �����e��O�_���a�O
        /// </summary>
        private void CheckGroundForward()
        {
            Collider2D hit = Physics2D.OverlapBox(
                transform.position + 
                transform.TransformDirection(dataEnemy.checkGroundOffset),
                dataEnemy.checkGroundSize, 0, dataEnemy.checkGroundLayer);

            // print("�e��O�_���a�O����G" + hit.gameObject);

            isGroundForward = hit;
        }

        /// <summary>
        /// �����e��O�_�������ؼ�
        /// </summary>
        private void CheckAttackTarget()
        {
            Collider2D hit = Physics2D.OverlapBox(
                transform.position +
                transform.TransformDirection(dataEnemy.checkTargetOffset),
                dataEnemy.checkTargetSize, 0, dataEnemy.checkTargetLayer);

            // print("�e��O�_�������ؼСG" + hit.gameObject);

            lookAttackTarget = hit;
            if (hit) traAttackTarget = hit.transform;   // �p�G���I�쪫��N�x�s�ܧΤ���
        }

        /// <summary>
        /// �ݨ������ؼ�
        /// </summary>
        private void LookAttackTarget()
        {
            if (lookAttackTarget)
            {
                float dis = Vector3.Distance(transform.position, traAttackTarget.position);
                // print("�Z���G" + dis);

                // �p�G �ثe�ʵe�W�� �� ����_���� �N���X
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
        /// ����
        /// </summary>
        private void Attack()
        {
            rig.velocity = Vector3.zero;
            enemyAttack.StartAttack();
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
