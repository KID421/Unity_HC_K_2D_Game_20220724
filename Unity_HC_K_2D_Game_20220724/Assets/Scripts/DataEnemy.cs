using UnityEngine;

namespace KID
{
    /// <summary>
    /// �ĤH���
    /// </summary>
    [CreateAssetMenu(menuName = "KID/Enemy Data", fileName = "Enemy Data", order = 1)]
    public class DataEnemy : DataAttack
    {
        [Header("���ʳt��"), Range(0, 50)]
        public float speed = 3.5f;
        [Header("�����e��O�_���a�O���")]
        public Color checkGroundColor = new Color(1, 0.5f, 0.3f, 0.3f);
        public Vector3 checkGroundOffset;
        public Vector3 checkGroundSize = Vector3.one;
        public LayerMask checkGroundLayer;
        [Header("�����e��O�_�������ؼ�")]
        public Color checkTargetColor = new Color(1, 0.1f, 0.1f, 0.3f);
        public Vector3 checkTargetOffset;
        public Vector3 checkTargetSize = Vector3.one;
        public LayerMask checkTargetLayer;
        [Header("�����d��")]
        public Color attackRangeColor = new Color(0, 1, 0, 0.5f);
        [Range(0, 5)]
        public float attackRange = 2;
    }
}
