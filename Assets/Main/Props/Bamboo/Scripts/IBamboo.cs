using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBamboo
{
    Transform GetBitePoint();
    float GetSpeedMultiplier();
    float LetGo();
}
