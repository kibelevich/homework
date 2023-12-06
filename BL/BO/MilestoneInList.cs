﻿
namespace BO;

public class MilestoneInList
{
    public int ID { get; init; }
    public required string description { get; set; }
    public required string alias { get; set; }
    public Status? status { get; set; }
    public int? completionPercentage { get; set; }
}
