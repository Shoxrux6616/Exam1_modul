﻿namespace Exam1Modul.DataAcces.Entities;

public class Music
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double MB { get; set; }
    public string AuthorName {  get; set; }
    public string Description { get; set; }
    public int QuentityLike { get; set; }

}
