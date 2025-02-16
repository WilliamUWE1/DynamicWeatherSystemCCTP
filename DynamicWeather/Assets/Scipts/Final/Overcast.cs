﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Overcast : BaseWeather
{

    public Overcast()
    {
        name = nameof(Overcast);

        //define start probability
        startProbability = 0.3;
        //define transition probabilities
        overcastTransition = 0.2;
        rainTransition = 0.2;
        sunnyTransition = 0.3;
        fogTransition = 0.1;
        snowTransition = 0.1;
        stormTransition = 0.1;

    }

    [RuntimeInitializeOnLoadMethod]
    static void Start()
    {
        icon[0] = GameObject.Find("Overcast");
        icon[0].SetActive(false);
    }
}
