using UnityEngine;

namespace KID
{
    /// <summary>
    /// 學習非靜態 API
    /// 與靜態的差別：需要有實體物件
    /// </summary>
    public class LearnAPINonStatic : MonoBehaviour
    {
        // 1. 該類別的欄位
        // 2. 屬性面板必須取得實體物件
        // 3. 使用非靜態屬性或方法
        public GameObject goKnight;

        public Camera cam;
        public SphereCollider sphereCollider;
        public Transform traCapsule;

        public Transform traCube, traSphere;
        public Rigidbody rigCapsule;

        private void Start()
        {
            // 非靜態屬性
            // 1. 取得 Get
            // 語法：欄位名稱.非靜態屬性
            print($"騎士圖層 { goKnight.layer }");

            // 2. 設定 Set 
            // 語法：欄位名稱.非靜態屬性 指定 值；
            goKnight.layer = 4;

            // 非靜態方法
            // 3. 使用
            // 語法：欄位名稱.非靜態方法(對應的引數)
            goKnight.SetActive(false);

            print($"Camera Depth { cam.depth }");
            print($"球體半徑 { sphereCollider.radius }");

            cam.backgroundColor = Random.ColorHSV();
            traCapsule.localScale = new Vector3(3, 2, 1);
        }

        private void Update()
        {
            traCube.RotateAround(traSphere.position, traSphere.forward, 5);
            rigCapsule.AddForce(new Vector3(0, 10, 0));
        }
    }
}
