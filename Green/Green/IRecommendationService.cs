namespace Green;

public interface IRecommendationService
{
    IEnumerable<RecommendationItem> GetRecommendationsFor(string id);
}
