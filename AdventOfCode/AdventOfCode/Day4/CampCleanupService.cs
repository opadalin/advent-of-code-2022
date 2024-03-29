using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day4;

public class CampCleanupService
{
    private readonly IEnumerable<Pair> _pairs;

    public CampCleanupService(string inputDataAsString)
    {
        if (string.IsNullOrWhiteSpace(inputDataAsString))
        {
            throw new ArgumentNullException(nameof(inputDataAsString));
        }

        _pairs = GetPairs(inputDataAsString);
    }

    private static IEnumerable<Pair> GetPairs(string inputDataAsString)
    {
        return inputDataAsString.Split(Environment.NewLine)
            .Select(pairsAsString => pairsAsString.Split(','))
            .Select(pairAsStringArray => new Pair(pairAsStringArray[0], pairAsStringArray[1]))
            .ToList();
    }

    public int GetTotalNumberOfPairsWithFullyOverlappingAssignments()
    {
        return _pairs.Count(pair => pair.HasFullyOverlappingAssignments());
    }

    public int GetTotalNumberOfPairsWithAnyOverlappingAssignments()
    {
        return _pairs.Count(pair => pair.HasAnyOverlappingAssignments());
    }
}