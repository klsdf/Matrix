using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 作者：闫辰祥
/// </summary>
public class level_1 : MonoBehaviour
{

    void Start()
    {
        DialogSystem.Instance.SetAndPlayStorys(new List<StoryScript>() {
            new StoryScript("当我着手书写这本日记的时候,我已经失忆了3天了。\n"),
            new StoryScript("虽然这三天\n"),
            new StoryScript("与其说是日记，更像是回忆。\n"),
        });
        
    }


    void Update()
    {
        
    }
}
