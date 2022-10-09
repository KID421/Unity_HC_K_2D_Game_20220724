using UnityEngine;

namespace KID
{
    /// <summary>
    /// 敵人物件池
    /// </summary>
    public class ObjectPoolEnemy : ObjectPoolBase
    {
        public static ObjectPoolEnemy instance;

        private void Start()
        {
            instance = this;
        }
    }
}
