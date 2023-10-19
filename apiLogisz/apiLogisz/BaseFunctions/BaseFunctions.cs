public class BaseFunctions
{
    public int calulateTotalProfits(List<int> profits)
    {
        var totalprofit = profits.Select(p => p).Sum();
        return totalprofit;
    }
}
