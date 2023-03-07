using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// 作者：闫辰祥
/// </summary>
public class DialogSystem : MonoBehaviour
{
    public TMP_Text text;

    static DialogSystem instance;


    private List<StoryScript> storys=null;
    private int storyPointer = 0;//剧情指针，表明当前剧情的进度

    public static DialogSystem Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<DialogSystem>();

            }
            return instance;
        }
    }

    void Start()
    {
      
       
        //text.GetComponent<>()
    }


    void Update()
    {
        
    }

    //设置故事
    public void SetStorys(List<StoryScript> newStorys)
    {
        storys = newStorys;
    }

    public void SetAndPlayStorys(List<StoryScript> newStorys)
    {
        SetStorys(newStorys);
        PlayNextStory();
    }

    //增加信息
    public void AddMessage(string msg)
    {
        text.text += msg;
    }


    public void ChangeMessage(string msg)
    {
        text.text = msg;
    }

    //播放下一句话
    public void PlayNextStory() 
    {
        if (storyPointer >= storys.Count)
        {
            return;
        }

        AddMessage(storys[storyPointer].stroy);

        if (storys[storyPointer].stroyEvent != null)
        {
            storys[storyPointer].stroyEvent();
        }
        storyPointer++;

    }
}
