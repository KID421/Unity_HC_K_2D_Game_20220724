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
        // 參數語法：資料類型 參數名稱，資料類型 參數名稱，...
        // ※ 修飾詞 傳回資料類型 方法自訂名稱 (參數) { 程式區塊 }
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

            AddTen(7);
            Add(100, 300);
            Add(50, 999);
            // 火球，咻咻咻，爆炸
            Skill("火球", effect: "爆炸");
            Skill("冰球");
            Skill("電球", "滋滋滋");
        }

        private int ReturnTen()
        {
            // return 傳回
            return 10;
        }

        private void AddTen(int number)
        {
            number = number + 10;
            print("數字加十後的結果：" + number);
        }

        private void Add(int numberA, int numberB)
        {
            print("<color=yellow>數字相加的結果" + (numberA + numberB) + "</color>");
        }

        // 施放技能：火球、冰球、電球...
        // 有預設值的參數：選擇式參數 - 必須寫在最右邊，呼叫時不填會以預設值帶入
        private void Skill(string skillType, string sound = "咻咻咻", string effect = "碎片")
        {
            print("施放技能特效：" + skillType);
            print("技能音效：" + sound);
            print($"技能附帶特效： {effect}");
        }
    }
}

