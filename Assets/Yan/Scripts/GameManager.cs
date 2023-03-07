using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 作者：闫辰祥
/// </summary>
public class GameManager : MonoBehaviour
{


    static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();

            }
            return instance;
        }
    }

    public GameObject 女主;


    //显示女主头上的气泡
    public void ShowEmoji()
    {
        女主.transform.GetChild(0).gameObject.SetActive(true);
    }

    //取消气泡动画
    public void NotShowEmoji()
    {
        女主.transform.GetChild(0).gameObject.SetActive(false);
    }


    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
