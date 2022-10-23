using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace KID
{
    /// <summary>
    /// 開始場景管理器
    /// </summary>
    public class MenuManager : MonoBehaviour
    {
        private Button btnStart, btnQuit;

        private void Awake()
        {
            btnStart = GameObject.Find("開始遊戲").GetComponent<Button>();
            btnQuit = GameObject.Find("離開遊戲").GetComponent<Button>();

            btnStart.onClick.AddListener(() => SceneManager.LoadScene("遊戲場景"));
            btnQuit.onClick.AddListener(() => Application.Quit());
        }
    }
}
