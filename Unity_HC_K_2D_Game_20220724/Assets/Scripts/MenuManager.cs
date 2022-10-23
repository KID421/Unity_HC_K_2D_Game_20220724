using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace KID
{
    /// <summary>
    /// �}�l�����޲z��
    /// </summary>
    public class MenuManager : MonoBehaviour
    {
        private Button btnStart, btnQuit;

        private void Awake()
        {
            btnStart = GameObject.Find("�}�l�C��").GetComponent<Button>();
            btnQuit = GameObject.Find("���}�C��").GetComponent<Button>();

            btnStart.onClick.AddListener(() => SceneManager.LoadScene("�C������"));
            btnQuit.onClick.AddListener(() => Application.Quit());
        }
    }
}
