using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public float minPosX;
    public float maxPosX;

    public float moveDistance = 1f;
    public float timeStep = 1f;
    public static int enemyCount; // 记录敌人数量

    bool isMovingRight = true;

    // Use this for initialization
    void Start()
    {
        // Invoke repeating will be called once after timeStep (2nd parameter) amount,
        // and then repeatedly every timeStep (3rd parameter) amount
        InvokeRepeating("Move", timeStep, timeStep);
        // 初始化敌人数量
        enemyCount = GameObject.FindGameObjectsWithTag("Hearts").Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Move()
    {
        if (isMovingRight)
        {
            // Moving right
            Vector3 currentPos = transform.position;
            Vector3 newPos = currentPos + new Vector3(moveDistance, 0f);
            transform.position = newPos;

            // If aliens group reached the right-most edge, flip their direction
            if (transform.position.x >= maxPosX)
            {
                isMovingRight = false;
            }
        }
        else
        {
            // Moving left
            Vector3 currentPos = transform.position;
            Vector3 newPos = currentPos - new Vector3(moveDistance, 0f);
            transform.position = newPos;

            // If aliens group reached the left-most edge, flip their direction
            if (transform.position.x <= minPosX)
            {
                isMovingRight = true;
            }
        }
    }
    void OnDestroy()
    {
        EnemyController.enemyCount--;

        // 如果敌人全部被消灭，触发游戏成功逻辑
        if (EnemyController.enemyCount == 0)
        {
            GameSuccess();
        }
    }

    void GameSuccess()
    {
        // 在这里处理游戏成功的逻辑，比如切换场景
        SceneManager.LoadScene("GameSuccessScene");
    }
}


