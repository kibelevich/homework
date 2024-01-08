﻿using BlApi;


namespace BlImplementation;
/// <summary>
/// The implementation of milestoneInList's CRUD methods in BL
/// </summary>

internal class MilestoneInListImplementation : IMilestoneInList
{
    public BO.MilestoneInList? Read(int ID)
    {
        IBl bl = Factory.Get();
        BO.Milestone? milestone = bl.Milestone.Read(ID);
        if (milestone == null)
            return null;
        return new BO.MilestoneInList()
        {
            ID = milestone.ID,
            description = milestone.description,
            alias = milestone.alias,
            status = milestone.status,  
            completionPercentage = milestone.completionPercentage
        };
    }
}
