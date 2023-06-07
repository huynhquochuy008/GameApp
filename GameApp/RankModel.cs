using System;

public class RankModel
{
	private DateTime time;
	private string level;
	private int score;

    public RankModel()
    {
     
    }
    public RankModel(DateTime time, string level, int score)
	{
		this.time = time;
		this.level = level;
		this.score = score;
	}

	public DateTime getTime()
	{
		return time;
	}
    public string getLevel()
    {
        return level;
    }
    public int getScore()
    {
        return score;
    }
	public void setLevel(string level)
	{
		this.level = level;
	}
    public void setScore(int score)
    {
        this.score = score;
    }
    public void setTime(DateTime time)
    {
        this.time = time;
    }

}
