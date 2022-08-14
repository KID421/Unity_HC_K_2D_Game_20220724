using UnityEngine;

namespace KID
{
    /// <summary>
    /// 學習欄位 Field，保存遊戲內的資料
    /// </summary>
    public class LearnField : MonoBehaviour
    {
        #region 欄位基礎語法
        // 欄位語法：
        // 資料類型 欄位自訂名稱；
        // 資料類型 欄位自訂名稱 指定 值；

        // 指定符號 = 將右邊指派給左邊

        // ※ 修飾詞 資料類型 欄位自訂名稱 指定 值；
        int number;

        // 汽車資料
        // CC 數
        // 重量
        // 品牌
        // 是否有天窗

        // 修飾詞預設為私人
        // 私人 private 不顯示不允許外部存取
        // 公開 public 顯示允許外部存取
        public int cc = 1500;
        public float weight = 3.5f;
        public string brand = "特斯拉";
        public bool hasSkyWindow = true;

        // 欄位屬性 [屬性名稱(值)]
        // 1. 提示 Tooltip(字串)
        // 2. 標題 Header(字串)
        // 3. 範圍 Range(數值型態，數值型態) - 僅限數值類型 float 或 int
        // 4. 序列化 SerializedField 將私人欄位顯示
        [Tooltip("這是玩家的數量.....")]
        public int count;
        [Header("攻擊力")]
        public float attack = 10.5f;
        [Range(50, 1500)]
        public int hp = 100;
        [Header("武器名稱")]
        [Tooltip("這是玩家的武器")]
        public string weapon = "小刀";
        [Header("是否死亡"), Tooltip("玩家是否死亡")]
        public bool isDead = false;

        // C# OOP 物件導向程式設計
        // 三大特性：繼承、封裝、多型
        // 封裝：將該類別的內容封閉在類別內僅提供外部需要的窗口
        
        public string password = "123456789";   // 此為沒有封裝的不好示範

        /// <summary>
        /// 序列化欄位，封裝此資料但顯示在屬性面板
        /// </summary>
        [SerializeField]
        private int speed = 10;
        #endregion

        #region Unity 內資料類型
        // 儲存物件
        public GameObject goCamera;

        // 顏色與座標
        public Color color;
        public Color colorRed = Color.red;
        public Color colorYellow = Color.yellow;
        public Color colorCustom1 = new Color(0.5f, 0.5f, 0);
        public Color colorCustomAlpha = new Color(0, 0, 1, 0.5f);

        public Vector2 v2;
        public Vector2 v2Right = Vector2.right; // 1, 0
        public Vector2 v2Up = Vector2.up;       // 0, 1
        public Vector2 v2Custom = new Vector2(9, 1);

        public Vector3 v3Custom = new Vector3(9, 10, 11);
        public Vector3 v3Right = Vector3.right;

        public Vector4 v4Custom = new Vector4(1, 2, 3, 4);

        // 多選與列舉
        public LayerMask layer;

        public LightType lightType;
        public LightType lightTypeArea = LightType.Area;
        public KeyCode keyA;
        public KeyCode keyJump = KeyCode.Space;

        // 元件
        public Transform tra;
        public SpriteRenderer spr;
        public Animator ani;
        #endregion
    }
}
