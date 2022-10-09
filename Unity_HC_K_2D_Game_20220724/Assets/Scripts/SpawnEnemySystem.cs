using UnityEngine;

namespace KID
{
    /// <summary>
    /// �ͦ��ĤH�t��
    /// </summary>
    /// �w�]���涶�ǡG�Ʀr�V�j�V�C����
    [DefaultExecutionOrder(200)]
    public class SpawnEnemySystem : MonoBehaviour
    {
        [SerializeField, Header("�ͦ��ɶ��d��")]
        private Vector2 rangeSpawn = new Vector2(0.5f, 1.5f);

        private void Start()
        {
            SpawnEnemy();
        }

        /// <summary>
        /// �ͦ��ĤH
        /// </summary>
        private void SpawnEnemy()
        {
            GameObject tempEnemy = ObjectPoolEnemy.instance.GetPoolObject();
            tempEnemy.transform.position = transform.position;
        }
    }
}
