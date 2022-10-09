﻿using UnityEngine;

namespace KID
{
    /// <summary>
    /// 敵人資料
    /// </summary>
    [CreateAssetMenu(menuName = "KID/Enemy Data", fileName = "Enemy Data", order = 1)]
    public class DataEnemy : DataAttack
    {
        [Header("移動速度"), Range(0, 50)]
        public float speed = 3.5f;
        [Header("偵測前方是否有地板資料")]
        public Color checkGroundColor = new Color(1, 0.5f, 0.3f, 0.3f);
        public Vector3 checkGroundOffset;
        public Vector3 checkGroundSize = Vector3.one;
        public LayerMask checkGroundLayer;
        [Header("偵測前方是否有攻擊目標")]
        public Color checkTargetColor = new Color(1, 0.1f, 0.1f, 0.3f);
        public Vector3 checkTargetOffset;
        public Vector3 checkTargetSize = Vector3.one;
        public LayerMask checkTargetLayer;
        [Header("攻擊範圍")]
        public Color attackRangeColor = new Color(0, 1, 0, 0.5f);
        [Range(0, 5)]
        public float attackRange = 2;
    }
}
