namespace Green;

public class RecommendationService : IRecommendationService
{
    private readonly Dictionary<string, List<RecommendationItem>> _recommendations = new ()
    {
        {
            "porsche",
            [
                new RecommendationItem("Green Caravan", "reco_3.jpg"),
                new RecommendationItem("Red Caravan", "reco_5.jpg"),
                new RecommendationItem("Barrow", "reco_6.jpg"),
            ]
        },
        {
            "fendt",
            [
                new RecommendationItem("Green Caravan", "reco_3.jpg"),
                new RecommendationItem("Barrow", "reco_6.jpg"),
                new RecommendationItem("Utility Caravan", "reco_4.jpg"),
            ]
        },
        {
            "eicher",
            [
                new RecommendationItem("Käfer", "reco_1.jpg"),
                new RecommendationItem("Formula One", "reco_8.jpg"),
                new RecommendationItem("Gondola", "reco_7.jpg"),
            ]
        },
    };

    public IEnumerable<RecommendationItem> GetRecommendationsFor(string id)
    {
        if (_recommendations.TryGetValue(id, out var recos))
        {
            return recos;
        }

        return Enumerable.Empty<RecommendationItem>();
    }
}
