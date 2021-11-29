using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameClearScript : MonoBehaviour
{
    public Text gameClearMessage;
    Transform myTransform;

    // ゲームクリアしたかどうかを判断するための変数
    bool isGameClear = false;

    // Start is called before the first frame update
    void Start()
    {
        // Transformコンポーネントを保持しておく
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        // 子がいなくなったらゲームを停止する
        if (myTransform.childCount == 0)
        {
            gameClearMessage.text = "Game Clear";
            Time.timeScale = 0f;

            isGameClear = true;
        }

        // ゲームクリアしている、かつ、ボタン入力でシーンを再ロード
        if(isGameClear && Input.GetButtonDown("Submit"))
        {
            // timeScaleを1に戻しておく
            Time.timeScale = 1f;
            // シーンのロード
            SceneManager.LoadScene("PlayScene");
        }
    }
}
