﻿
using BlApi;
namespace BlImplementation;
/// <summary>
/// A business layer object
/// </summary>
internal class Bl : IBl
{
    public IEngineer Engineer =>  new EngineerImplementation();
    public ITask Task => new TaskImplementation();
    public IMilestone Milestone => new MilestoneImplementation();
    public IEngineerInTask EngineerInTask =>  new EngineerInTaskImplementation();
    public IEngineerInList EngineerInList => new EngineerInListImplementation();
    public ITaskInList TaskInList => new TaskInListImplementation();
    public IMilestoneInList MilestoneInList => new MilestoneInListImplementation();
    public IMilestoneInTask MilestoneInTask => new MilestoneInTaskImplementation();

}
