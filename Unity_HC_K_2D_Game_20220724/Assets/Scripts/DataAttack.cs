using UnityEngine;

namespace KID
{
    /// <summary>
    /// 攻擊資料
    /// </summary>
    [CreateAssetMenu(menuName = "KID/Data Attack", fileName = "Data Attack")]
    public class DataAttack : ScriptableObject
    {
        [Header("攻擊資料")]
        [Range(0, 1000)]
        public float attack = 30;
        public Color attackAreaColor = new Color(0, 1, 0.2f, 0.7f);
        public Vector3 attackAreaSize = Vector3.one;
        public Vector3 attackAreaOffset;
        public LayerMask attackAreaLayer;
        public string parAttack = "觸發攻擊";
        [Range(0, 3)]
        public float attackTime = 0.9f;
        [Range(0, 2)]
        public float delaySendDamage = 0.3f;
    }
}
