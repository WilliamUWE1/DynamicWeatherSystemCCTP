﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkovModel : MonoBehaviour
{

    //define states here
    public struct States
    {
        public Overcast overcast;
        public Rain rain;
        public Sunny sunny;
        public Fog fog;
        public Snow snow;
        public Thunderstorm thunder;
    }

    States states;

    MarkovModel()
    {
      
    }
    public void PlayWeather(BaseWeather newWeather)
    {

    }

}
