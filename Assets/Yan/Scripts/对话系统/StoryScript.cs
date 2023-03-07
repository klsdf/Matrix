using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// 作者：闫辰祥
/// 故事剧本的数据结构
/// </summary>
public class StoryScript 
{
    public string stroy;
    public Action stroyEvent;

    public StoryScript(string stroy)
    {
        this.stroy = stroy;
        this.stroyEvent = null;
    }
    public StoryScript(string stroy, Action stroyEvent) 
    {
        this.stroy = stroy;
        this.stroyEvent = stroyEvent;
    }
 
}
