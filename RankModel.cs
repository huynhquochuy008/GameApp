using System;

public class RankModel
{
	private DateTime time;
	private string level;
	private string score;

    public RankModel(DateTime time, string level, string score)
	{
		this.time = time;
		this.level = level;
		this.score = score;
	}
    public RankModel()
    {
       
    }

    public DateTime getTime()
	{
		return time;
	}
    public string getLevel()
    {
        return level;
    }
    public string getScore()
    {
        return score;
    }
	public void setLevel(string level)
	{
		this.level = level;
	}
    public void setScore(string score)
    {
        this.score = score;
    }
    public void setTime(DateTime time)
    {
        this.time = time;
    }

}
