using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SampleSecureCoding.Models;

public class Student
{
    [Key]
    public string Nim { get; set;} = null!;
    public string FullName { get; set;} = null!;
}