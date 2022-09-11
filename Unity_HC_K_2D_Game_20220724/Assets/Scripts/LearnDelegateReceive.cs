using UnityEngine;

namespace KID
{
    /// <summary>
    /// 學習委派：接收方
    /// </summary>
    public class LearnDelegateReceive : MonoBehaviour
    {
        public void ReceiveData(int getNumberData)
        {
            getNumberData++;
            print("接收到的資料加一：" + getNumberData);
        }

        // 2. 定義委派：簽章必須與方法一樣
        // 範例：無傳回無參數
        // 簽章：傳回類型、參數數量與類型
        // 委派語法：修飾詞 委派關鍵字 傳回類型 委派名稱(參數)；
        public delegate void delegateOne();

        public delegate void delegateTwo(int number);

        // 3. 使用委派
        // 3-1 參數定義
        public void ReceiveMethod(delegateOne one)
        {
            // 3-3 使用委派
            one();
        }

        public void ReceiveMethodTwo(delegateTwo two)
        {
            int weaponA = 9;
            two(weaponA);
        }
    }
}
