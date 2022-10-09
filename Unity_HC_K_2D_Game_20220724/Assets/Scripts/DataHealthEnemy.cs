using UnityEngine;

namespace KID
{
    /// <summary>
    /// 敵人血量系統
    /// </summary>
    [CreateAssetMenu(menuName = "KID/Data Health Enemy")]
    public class DataHealthEnemy : DataHealth
    {
        [Header("掉落機率"), Range(0f, 1f)]
        public float dropProbability;
        [Header("掉落物件")]
        public GameObject prefabProp;
    }
}
