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

        }
        #endregion

        #region �ƥ�
        private void Awake()
        {
            
        }

        private void Update()
        {
            
        }
        #endregion
    }
}

