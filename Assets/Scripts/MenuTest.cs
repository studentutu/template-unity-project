﻿using UnityEngine;
using System.Collections;
using OmiyaGames;

///-----------------------------------------------------------------------
/// <copyright file="MenuTest.cs" company="Omiya Games">
/// The MIT License (MIT)
/// 
/// Copyright (c) 2014-2015 Omiya Games
/// 
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
/// 
/// The above copyright notice and this permission notice shall be included in
/// all copies or substantial portions of the Software.
/// 
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
/// THE SOFTWARE.
/// </copyright>
/// <author>Taro Omiya</author>
/// <date>5/25/2015</date>
///-----------------------------------------------------------------------
/// <summary>A simple test script: displays the <code>PauseMenu</code>, <code>LevelFailedMenu</code>, or <code>LevelCompleteMenu</code></summary>
/// <seealso cref="PauseMenu"/>
/// <seealso cref="LevelFailedMenu"/>
/// <seealso cref="LevelCompleteMenu"/>
public class MenuTest : MonoBehaviour
{
    public void OnPauseClicked()
    {
        Singleton.Get<MenuManager>().Show<PauseMenu>();
    }
    public void OnFailedClicked()
    {
        Singleton.Get<MenuManager>().Show<LevelFailedMenu>();
    }
    public void OnCompleteClicked()
    {
        Singleton.Get<MenuManager>().Show<LevelCompleteMenu>();
    }
    public void OnSoundClicked()
    {
        SoundEffect sound = GetComponent<SoundEffect>();
        if(sound != null)
        {
            sound.Play();
        }
    }
}