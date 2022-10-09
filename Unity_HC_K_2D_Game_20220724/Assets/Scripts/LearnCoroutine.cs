using UnityEngine;
using System.Collections;   // 1. 引用系統集合

namespace KID
{
    /// <summary>
    /// 學習協同程序
    /// </summary>
    public class LearnCoroutine : MonoBehaviour
    {
        private void Awake()
        {
            StartCoroutine(Test());
        }

        private IEnumerator Test()
        {
            print("第一段程式");

            yield return new WaitForSeconds(3);

            print("三秒後執行第二段");

            yield return new WaitForSeconds(4);

            print("四秒後執行第三段");
        }
    }
}
