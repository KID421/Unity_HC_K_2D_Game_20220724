using UnityEngine;

namespace KID
{
    [CreateAssetMenu(menuName = "KID/Data Health", fileName = "Data Health")]
    public class DataHealth : ScriptableObject
    {
        [Header("血量"), Range(0, 1000)]
        public float hp;
        [Header("死亡動畫參數")]
        public string parDead;
    }
}
