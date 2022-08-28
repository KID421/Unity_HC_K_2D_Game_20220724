using UnityEngine;

namespace KID
{
    /// <summary>
    /// ���D�t�ΡG������D�P�ʵe��s
    /// </summary>
    public class JumpSystem : MonoBehaviour
    {
        #region ���
        [SerializeField, Header("���D����"), Range(0, 100)]
        private float jump = 5;
        [SerializeField, Header("���D�ѼƦW��")]
        private string parJump = "�}�����D";

        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region �ˬd�a�O���
        [SerializeField, Header("�ˬd�a�O�C��")]
        private Color checkGroundColor = new Color(1, 0, 0.2f, 0.3f);
        [Header("�ˬd�a�O�ؤo�P�첾")]
        [SerializeField] private Vector3 checkGroundSize;
        [SerializeField] private Vector3 checkGroundOffset;
        #endregion

        #region �ƥ�
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        #endregion

        #region ��k
        #endregion
    }
}
