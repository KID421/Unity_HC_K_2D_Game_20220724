using UnityEngine;

namespace KID
{
    /// <summary>
    /// ���ʨt�ΡG����󲾰ʻP�ʵe
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        #region ���
        [SerializeField, Header("���ʳt��"), Range(0, 100)]
        private float speed = 3.5f;
        [SerializeField, Header("���ʰѼƦW��")]
        private string parMove = "�}���]�B";

        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region ��k
        /// <summary>
        /// ���ʤ�k
        /// </summary>
        private void Move()
        {
            float h = Input.GetAxis("Horizontal");
            rig.velocity = new Vector2(h * speed, rig.velocity.y);
            ani.SetBool(parMove, h != 0);
            
            if (Mathf.Abs(h) < 0.1f) return;                            // �p�G ��������� �p�� 0.1 �N���X

            float yAngle = h > 0 ? 0 : 180;
            transform.eulerAngles = new Vector3(0, yAngle, 0);
        }
        #endregion

        #region �ƥ�
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            Move();
        }

        // �����ƥ�G����Q��������@��
        private void OnDisable()
        {
            rig.velocity = Vector3.zero;
            ani.SetBool(parMove, false);
        }
        #endregion
    }
}
