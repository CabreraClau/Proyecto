using Library;
public class Rating
{
    List<int> Ratings { get; set; }
    public Rating()
    {
        this.Ratings = new List<int>();
    }
    public int GetAverageRating()
    {
        int ratingsCount = 0;
        int ratingTotal = 0;
        foreach (int valRatings in this.Ratings)
        {
            ratingsCount++;
            ratingTotal += valRatings;
        }
        if (ratingsCount != 0)
        {
            return ratingTotal / ratingsCount;
        }
        return 3;
    }
    public void AddRating(int rating)
    {
        this.Ratings.Add(rating);
    }
}