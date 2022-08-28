using UnityEngine;

namespace KID
{
    /// <summary>
    /// 跳躍系統：角色跳躍與動畫更新
    /// </summary>
    public class JumpSystem : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("跳躍高度"), Range(0, 100)]
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
        #endregion

        #region 事件
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        #endregion

        #region 方法
        #endregion
    }
}
