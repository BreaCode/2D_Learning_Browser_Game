﻿using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpriteAnimationConfig", menuName = "Config/SpriteAnimationConfig", order = 999)]
public class SpriteAnimationConfig : ScriptableObject
{
    [SerializeField]
    private List<SpritesSequence> _sequences;

    public List<SpritesSequence> Sequences => _sequences;
}
