using UnityEngine;

namespace KID
{
    /// <summary>
    /// 敵人血量系統
    /// </summary>
    public class EnemyHealth : HealthSystem
    {
        public delegate void delegateDead();
        public delegateDead onDead;

        protected override void Dead()
        {
            base.Dead();

            onDead();
            DropProp();
            gameObject.layer = 9;
        }

        /// <summary>
        /// 掉落道具
        /// </summary>
        private void DropProp()
        {
            float probability = Random.value;

            // print("掉落機率：" + probability);

            DataHealthEnemy dataEnemy = (DataHealthEnemy)dataHealth;

            if (probability <= dataEnemy.dropProbability)
            {
                Vector3 pos = transform.position + Vector3.up * 1.5f;

                // Instantiate(dataEnemy.prefabProp, pos, Quaternion.identity);

                GameObject tempProp = ObjectPoolEnemyProp.instance.GetPoolObject();
                tempProp.transform.position = pos;
                tempProp.transform.eulerAngles = Vector3.zero;
            }
        }
    }
}
