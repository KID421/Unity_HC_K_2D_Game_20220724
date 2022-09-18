using UnityEngine;

namespace KID
{
    /// <summary>
    /// �������
    /// </summary>
    public class DataAttack : ScriptableObject
    {
        [Header("�������")]
        [Range(0, 1000)]
        public float attack = 30;
        public Color attackAreaColor = new Color(0, 1, 0.2f, 0.7f);
        public Vector3 attackAreaSize = Vector3.one;
        public Vector3 attackAreaOffset;
    }
}
