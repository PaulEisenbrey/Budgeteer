namespace Database.Trupanion.Entity.Claims.PetStamp;

public  class ClaimsPetStampPphxItem
{
    public ClaimsPetStampPphxItem()
    {
        PphxItemSelectionHistories = new HashSet<ClaimsPetStampPphxItemSelectionHistory>();
        PphxItemSelections = new HashSet<ClaimsPetStampPphxItemSelection>();
    }

    public int Id { get; set; }
    public int? PphxTypeId { get; set; }
    public string? Name { get; set; }
    public bool NotesRequired { get; set; }

    public virtual ICollection<ClaimsPetStampPphxItemSelectionHistory> PphxItemSelectionHistories { get; set; }
    public virtual ICollection<ClaimsPetStampPphxItemSelection> PphxItemSelections { get; set; }
}

