using UnityEngine;

namespace KID
{
    /// <summary>
    /// 學習欄位 Field，保存遊戲內的資料
    /// </summary>
    public class LearnField : MonoBehaviour
    {
        // 欄位語法：
        // 資料類型 欄位自訂名稱；
        // 資料類型 欄位自訂名稱 指定 值；

        // 指定符號 = 將右邊指派給左邊

        // 修飾詞 資料類型 欄位自訂名稱 指定 值；
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
        // 3. 範圍 Range(數值型態，數值型態)
        [Tooltip("這是玩家的數量.....")]
        public int count;
        [Header("攻擊力")]
        public float attack = 10.5f;
    }
}
