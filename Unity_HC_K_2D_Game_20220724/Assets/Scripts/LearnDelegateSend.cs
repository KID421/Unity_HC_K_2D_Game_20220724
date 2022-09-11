using UnityEngine;

namespace KID
{
    /// <summary>
    /// 學習委派：傳送方
    /// </summary>
    public class LearnDelegateSend : MonoBehaviour
    {
        private int number = 99;
        private LearnDelegateReceive receive;

        #region 委派說明
        // 1. 需要傳遞的方法
        // 2. 定義委派
        // 3. 使用委派
        #endregion

        private void Awake()
        {
            receive = FindObjectOfType<LearnDelegateReceive>();
            receive.ReceiveData(number);

            // 3. 使用委派
            // 3-2 參數傳遞
            receive.ReceiveMethod(MethodOne);
        }

        // 1. 定義方法
        // 範例：無傳回無參數
        private void MethodOne()
        {
            print("我是方法一");
        }
    }
}
