using UnityEngine;

namespace KID
{
    /// <summary>
    /// 移動系統：控制物件移動與動畫
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("移動速度"), Range(0, 100)]
        private float speed = 3.5f;
        [SerializeField, Header("移動參數名稱")]
        private string parMove = "開關跑步";

        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region 方法
        /// <summary>
        /// 移動方法
        /// </summary>
        private void Move()
        {
            float h = Input.GetAxis("Horizontal");
            rig.velocity = new Vector2(h * speed, rig.velocity.y);
            ani.SetBool(parMove, h != 0);
            
            if (Mathf.Abs(h) < 0.1f) return;                            // 如果 水平絕對值 小於 0.1 就跳出

            float yAngle = h > 0 ? 0 : 180;
            transform.eulerAngles = new Vector3(0, yAngle, 0);
        }
        #endregion

        #region 事件
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            Move();
        }

        // 關閉事件：元件被關閉執行一次
        private void OnDisable()
        {
            rig.velocity = Vector3.zero;
            ani.SetBool(parMove, false);
        }
        #endregion
    }
}
