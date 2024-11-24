﻿namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboFaxLine
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual List<TruDatDboFaxLineNumber> FaxLineNumbers { get; set; } = new();
}
