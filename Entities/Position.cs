﻿namespace StudyPlannerSoft.Entities;

public class Position
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Pab { get; set; } = 0;
}