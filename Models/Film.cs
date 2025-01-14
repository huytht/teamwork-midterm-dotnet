﻿using System;

public class Film
{
	public int ID { get; set; }
	public String Name { get; set; }
	public DateTime Time { get; set; }
	public ICollection<FilmSchedule> FilmSchedules { get; set; }

	public Film()
	{
		FilmSchedules = new HashSet<FilmSchedule>();
	}
}
