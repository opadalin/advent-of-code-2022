namespace AdventOfCode.Day2;

public class Elf
{
    public Elf(Selection selection)
    {
        Selection = selection;
        Score = selection.Option switch
        {
            Option.Rock => 1,
            Option.Paper => 2,
            Option.Scissors => 3,
            _ => Score
        };
    }

    public int Score { get; private set; }
    public Selection Selection { get; }

    public void AddToScore(int score)
    {
        Score += score;
    }

    public override string ToString()
    {
        return $"Elf with {Selection} chosen";
    }
}