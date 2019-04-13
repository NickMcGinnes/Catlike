using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
	public Transform HoursTransform, MinutesTransform, SecondsTransform;

	const float DegreesPerHour = 30f, DegreesPerMinute = 6f, DegreesPerSecond = 6f;

	public bool continuous;

	private void Update()
	{
		if (continuous)
		{
			UpdateContinuous();
		}
		else
		{
			UpdateDiscrete();
		}
			
	}

	void UpdateContinuous()
	{
		TimeSpan time = DateTime.Now.TimeOfDay;
		HoursTransform.localRotation = Quaternion.Euler(0f, (float) time.TotalHours * DegreesPerHour, 0f);
		MinutesTransform.localRotation = Quaternion.Euler(0f, (float) time.TotalMinutes * DegreesPerMinute, 0f);
		SecondsTransform.localRotation = Quaternion.Euler(0f, (float) time.TotalSeconds * DegreesPerSecond, 0f);
	}
	
	void UpdateDiscrete()
	{
		DateTime time = DateTime.Now;
		HoursTransform.localRotation = Quaternion.Euler(0f, time.Hour * DegreesPerHour, 0f);
		MinutesTransform.localRotation = Quaternion.Euler(0f, time.Minute * DegreesPerMinute, 0f);
		SecondsTransform.localRotation = Quaternion.Euler(0f, time.Second * DegreesPerSecond, 0f);
	}

	
		
	
	
}