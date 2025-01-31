﻿namespace Dal;
using DO;

/// <summary>
/// Data source for DalList 
/// </summary>
internal static class DataSource
{
    //Lists of the entities
    internal static List<Engineer> Engineers = new();
    internal static List<Task> Tasks = new();
    internal static List<Dependency> Dependencies = new();

    //Running numbers for entities
    internal static class Config
    {
        internal const int startId = 1;
        private static int nextIdT = startId;
        private static int nextIdD = startId;
        internal static int NextIdT  { get => nextIdT++; }
        internal static int NextIdD { get => nextIdD++; }

    }
}
