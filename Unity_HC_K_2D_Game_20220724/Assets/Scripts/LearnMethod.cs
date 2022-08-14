using UnityEngine;

namespace KID
{
    /// <summary>
    /// 學習方法：儲存程式區塊 (Code Block)，
    /// 方法、函式、函數、功能、Method、Function
    /// </summary>
    public class LearnMethod : MonoBehaviour
    {
        // 方法語法：
        // ※ 修飾詞 傳回資料類型 方法自訂名稱 () { 程式區塊 }
        // 無傳回類型 void
        private void Test()
        {
            print("測試");
        }

        // Ctrl + K D 自動格式化 (排版)

        private void Start()
        {
            // 呼叫方法
            Test();
            Test();
            Test();

            int ten = ReturnTen();

            print("結果：" + ten);
        }

        private int ReturnTen()
        {
            // return 傳回
            return 10;
        }
    }
}

