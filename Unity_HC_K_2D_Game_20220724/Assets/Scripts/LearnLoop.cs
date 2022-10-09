using UnityEngine;

namespace KID
{
    /// <summary>
    /// 迴圈：for
    /// </summary>
    public class LearnLoop : MonoBehaviour
    {
        private void Awake()
        {
            for (int x = 0; x < 100; x++)
            {
                print("迴圈執行次數：" + x);
            }
        }
    }
}
