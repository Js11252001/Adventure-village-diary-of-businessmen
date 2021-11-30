using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum SeasonKind
{
    spring = 1,
    summer,
    fall,
    winter
}
public delegate void PerDayDelegate();

public class TimeWeather : MonoBehaviour
{
    public static TimeWeather _instance;
    int month = 1;
    int date = 28;
    int season = ((int)SeasonKind.spring);
    int year = 323;

    float timer = 0;

    float dayTime = 2;

    public PerDayDelegate perDay;

    private void Awake()
    {
        _instance = this;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= dayTime)
        {
            timer = 0;
            date += 1;
            if(date > 28)
            {
                date = 1;
                month += 1;
                if(month > 12)
                {
                    month = 1;
                    year += 1;
                }
            }
        }
        if(perDay != null)
        {
            perDay();
        }
    }
}
