using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Player {

    public static float Level {
        get => Mathf.Pow(Mathf.Max(0, (4 * (minerals - 23) / 25f)), 1 / 2.462f);
    }
    public static float bulletSpeed = 20;
    public static float bulletRange = 8;
    public static float shootRate = 3f;
    public static float damage = 10f;
    public static int minerals = 0;

    static bool initialized = false;

    public static void Init() {
        if (initialized) return;
        initialized = true;
    }

    public static int MineralsRequired(int level) {
        return (int)((25 * Mathf.Pow(level, 2.462f)) / 4 + 23);
    }

}
