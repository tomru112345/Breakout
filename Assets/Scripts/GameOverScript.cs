using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    // publicにしてInspectorから設定できるようにする
    public Text gameOverMessage;
    // ゲームオーバーしたかどうかを判断するための変数
    bool isGameOver = false;

    // 衝突時に呼ばれる
    void OnCollisionEnter(Collision collision)
    {
        // Game Overと表示する
        gameOverMessage.text = "Game Over";

        // 当たったゲームオブジェクトを削除する
        Destroy(collision.gameObject);

        isGameOver = true;  
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ゲームオーバーになっている、かつ、Submitボタンを押したら実行する
        if(isGameOver && Input.GetButtonDown("Submit"))
        {
            // Playシーンをロードする
            SceneManager.LoadScene("PlayScene");
        }   
    }
}
