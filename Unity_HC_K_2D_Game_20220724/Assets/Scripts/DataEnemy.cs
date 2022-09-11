using UnityEngine;

namespace KID
{
    /// <summary>
    /// �ĤH���
    /// </summary>
    [CreateAssetMenu(menuName = "KID/Enemy Data", fileName = "Enemy Data", order = 1)]
    public class DataEnemy : ScriptableObject
    {
        [Header("���ʳt��"), Range(0, 50)]
        public float speed = 3.5f;
        [Header("�����e��O�_���a�O���")]
        public Color checkGroundColor = new Color(1, 0.5f, 0.3f, 0.3f);
        public Vector3 checkGroundOffset;
        public Vector3 checkGroundSize = Vector3.one;
        public LayerMask checkGroundLayer;
    }
}
