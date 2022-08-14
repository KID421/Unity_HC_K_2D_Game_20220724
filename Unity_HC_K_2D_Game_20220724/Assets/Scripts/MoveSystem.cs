using UnityEngine;

namespace KID
{
    /// <summary>
    /// 移動系統：控制物件移動與動畫
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("移動速度"), Range(0, 100)]
        private float speed = 3.5f;
        [SerializeField, Header("移動參數名稱")]
        private string parMove = "開關跑步";

        private Animator ani;
        private Rigidbody2D rig;
    }
}

