using System.ComponentModel.DataAnnotations;

namespace Workshop.Data.Entities;

public class Artist {
    public Guid Id { get; set; } = Guid.Empty;

    [MaxLength(100)] public string Name { get; set; } = String.Empty;
}