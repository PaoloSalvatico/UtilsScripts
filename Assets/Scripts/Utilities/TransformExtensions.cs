using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TransformExtensions
{
    #region GetLocalDirection Utils
    public static Vector3 GetLocalForward(this Transform value)
    {
        return value.worldToLocalMatrix.MultiplyVector(value.forward);
    }
    public static Vector3 GetLocalRight(this Transform value)
    {
        return value.worldToLocalMatrix.MultiplyVector(value.right);
    }
    public static Vector3 GetLocalUp(this Transform value)
    {
        return value.worldToLocalMatrix.MultiplyVector(value.up);
    }
    #endregion
}
