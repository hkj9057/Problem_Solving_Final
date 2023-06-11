using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isCollision : MonoBehaviour
{ 

    public Transform player; // 플레이어의 Transform 컴포넌트
    private Transform enemy; // 적의 Transform 컴포넌트
    public RespawnMananger res;

    private Vector2 playerSize; // 플레이어의 크기
    private Vector2 enemySize; // 적의 크기

    private void Start()
    {
        
        // 플레이어와 적의 크기 가져오기
        playerSize = GetObjectSize(player);
        enemySize = GetObjectSize(enemy);
    }

    private void Update()
    {
        if(GameManager.instance.isPlay)
        {
            for(int i = 0; i < 6; i++)
            {
                enemy = res.MobPool[i].transform;
                // AABB 충돌 감지
                if (CheckCollision(player.position, playerSize, enemy.position, enemySize))
                {
                    // 충돌 이벤트 실행
                    GameManager.instance.GameOver();
                    // 여기에 충돌 이벤트를 처리하는 코드를 추가하세요.
                }
            }
        }
        
    }

    private Vector2 GetObjectSize(Transform obj)
    {
        // 객체의 크기를 가져오는 함수
        Renderer renderer = obj.GetComponent<Renderer>();
        if (renderer != null)
        {
            return renderer.bounds.size;
        }
        else
        {
            Debug.LogWarning("Object renderer not found!");
            return Vector2.zero;
        }
    }

    private bool CheckCollision(Vector2 positionA, Vector2 sizeA, Vector2 positionB, Vector2 sizeB)
    {
        // AABB 충돌 감지 함수
        float halfWidthA = sizeA.x / 3f;
        float halfHeightA = sizeA.y / 3f;
        float halfWidthB = sizeB.x / 3f;
        float halfHeightB = sizeB.y / 3f;

        float leftA = positionA.x - halfWidthA;
        float rightA = positionA.x + halfWidthA;
        float topA = positionA.y + halfHeightA;
        float bottomA = positionA.y - halfHeightA;

        float leftB = positionB.x - halfWidthB;
        float rightB = positionB.x + halfWidthB;
        float topB = positionB.y + halfHeightB;
        float bottomB = positionB.y - halfHeightB;

        return leftA <= rightB && rightA >= leftB && bottomA <= topB && topA >= bottomB;
    }
}
