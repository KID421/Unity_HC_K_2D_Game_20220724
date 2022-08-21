using UnityEngine;

namespace KID
{
    /// <summary>
    /// 學習 API 靜態的用法
    /// </summary>
    public class LearnAPIStatic : MonoBehaviour
    {
        private Vector3 v3A = new Vector3(1, 1, 1);
        private Vector3 v3B = new Vector3(22, 22, 22);

        private void Start()
        {
            #region 認識靜態屬性
            // 靜態屬性
            // 1. 取得 Get
            // 語法：類別名稱.靜態屬性
            print($"<color=red>{Random.value}</color>");

            // 2. 設定 Set (Read Only 不能設定)
            // 語法：類別名稱.靜態屬性 指定 值；
            // Random.value = 0.3f; 唯讀屬性不能設定
            Cursor.visible = false;
            #endregion

            // 練習 取得靜態屬性 1 ~ 2
            print($"攝影機數量 { Camera.allCamerasCount }");
            print($"平台 { Application.platform }");

            // 練習 設定靜態屬性 1 ~ 2
            Physics.sleepThreshold = 10;
            Time.timeScale = 0.5f;

            // 練習 呼叫靜態方法 1，2，4
            print(Mathf.Round(2.5f));
            print(Mathf.Floor(2.5f));
            print(Mathf.Ceil(2.5f));

            print($"A B 點距離 { Vector3.Distance(v3A, v3B) }");

            Application.OpenURL("https://unity.com/");
        }

        private void Update()
        {
            #region 認識靜態方法
            // 靜態方法
            // 3. 使用方法
            // 語法：類別名稱.靜態方法(對應引數)
            // print(Random.Range(0, 3));
            #endregion

            // 練習 取得靜態屬性 3 ~ 4
            // print($"是否按下任意鍵 { Input.anyKeyDown }");
            // print($"遊戲經過時間 {Time.time }");
            
            // 練習 呼叫靜態方法 3
            print($"是否按下空白鍵 {Input.GetKeyDown(KeyCode.Space) }");
        }
    }
}
