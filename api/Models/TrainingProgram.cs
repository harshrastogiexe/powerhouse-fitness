﻿using System.ComponentModel.DataAnnotations;

namespace API.Models;

#nullable disable

public class TrainingProgram
{
	[Key]
	public int ProgramId { get; set; }

	[Required(ErrorMessage = $"{nameof(Name)} is required")]
	[MaxLength(100)]
	public string Name { get; set; }

	[Required(ErrorMessage = $"{nameof(Duration)} is required")]
	[DataType(DataType.Duration)]
	public TimeSpan Duration { get; set; }

	[Required(ErrorMessage = $"{nameof(Description)} is required")]
	[MaxLength(1000)]
	public string Description { get; set; }

	[Required(ErrorMessage = $"{nameof(Cost)} is required")]
	[DataType(DataType.Currency)]
	public decimal Cost { get; set; }

}
