using System;
using System.ComponentModel.DataAnnotations;

namespace Exam.Models
{
  public class ActivityForm
  {
    [Required]
    public string Title { get; set; }

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime Date { get; set; }

    [Required]
    [DataType(DataType.Time)]
    public TimeSpan Time { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int Duration { get; set; }

    [Required]
    public string HMD {get;set;}

    [Required]
    public string Description { get; set; }
  }
}