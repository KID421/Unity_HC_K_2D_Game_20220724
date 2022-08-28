using UnityEngine;

namespace KID
{
    /// <summary>
    /// 跳躍系統：角色跳躍與動畫更新
    /// </summary>
    public class JumpSystem : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("跳躍高度"), Range(0, 10000)]
        private float jump = 5;
        [SerializeField, Header("跳躍參數名稱")]
        private string parJump = "開關跳躍";

        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region 檢查地板資料
        [SerializeField, Header("檢查地板顏色")]
        private Color checkGroundColor = new Color(1, 0, 0.2f, 0.3f);
        [Header("檢查地板尺寸與位移")]
        [SerializeField] private Vector3 checkGroundSize;
        [SerializeField] private Vector3 checkGroundOffset;
        [SerializeField, Header("檢查地板圖層")]
        private LayerMask checkGroundLayer;

        private bool isGrounded;
        #endregion

        #region 事件
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = checkGroundColor;
            Gizmos.DrawCube(
                transform.position + checkGroundOffset,
                checkGroundSize);
        }

        private void Update()
        {
            CheckGround();
            Jump();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 檢查地板
        /// </summary>
        private void CheckGround()
        {
            Collider2D hit = Physics2D.OverlapBox(
                transform.position + checkGroundOffset,
                checkGroundSize, 0, checkGroundLayer);

            // print("<color=red>碰到的物件" + hit + "</color>");

            isGrounded = hit;
        }

        /// <summary>
        /// 跳躍
        /// </summary>
        private void Jump()
        {
            // 如果 在地板上 並且 按下空白鍵 就跳躍
            if (isGrounded && Input.GetKeyDown(KeyCode.Space))
            {
                rig.AddForce(new Vector2(0, jump));
            }
        }
        #endregion
    }
}
