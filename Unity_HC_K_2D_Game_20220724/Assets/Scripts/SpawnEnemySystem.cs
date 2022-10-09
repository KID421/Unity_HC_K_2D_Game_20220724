using UnityEngine;

namespace KID
{
    /// <summary>
    /// 生成敵人系統
    /// </summary>
    /// 預設執行順序：數字越大越慢執行
    [DefaultExecutionOrder(200)]
    public class SpawnEnemySystem : MonoBehaviour
    {
        [SerializeField, Header("生成時間範圍")]
        private Vector2 rangeSpawn = new Vector2(0.5f, 1.5f);

        private void Start()
        {
            SpawnEnemy();
        }

        /// <summary>
        /// 生成敵人
        /// </summary>
        private void SpawnEnemy()
        {
            GameObject tempEnemy = ObjectPoolEnemy.instance.GetPoolObject();
            tempEnemy.transform.position = transform.position;
        }
    }
}
