
public class Player
{
    private string playerID;
    private ScoreCard ScoreCard;
    private ReportCard ReportCard;
    private User currentUser = new User();

    public Player createPlayer(string playerName )
    {
        playerID = playerName + currentUser.Uid;
            return this;
    }

    public Player getPlayer()
    {
        return this;
    }

    public Player updateScoreCard(ScoreCard sc)
    {
        this.ScoreCard = sc;
        return this;
    }
    public Player updateReportCard(ReportCard rc)
    {
        this.ReportCard = rc;
        return this;
    }
}
