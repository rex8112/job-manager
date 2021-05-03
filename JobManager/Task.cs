using System;

public class Task
{
    public string FormattedString
    {
        get { return string.Format("{0,2:D2} - {1}", opSeq, description); }
    }
	private int opSeq;
	private string description;
	private DateTime startTime;
	private DateTime stopTime;
    private Job job;
    public Department department;

	public TimeSpan Duration
    {
		get
        {
            try
            {
				return stopTime - startTime;
            }
            catch (Exception)
            {
                try
                {
				    return DateTime.Now - startTime;
                }
                catch (Exception)
                {

                    return TimeSpan.Zero;
                }
            }
        }
    }
	public Task(int opSeq, string desc)
	{
		this.opSeq = opSeq;
		this.description = desc;
	}
    public Task(int opSeq, string desc, Job job, Department department)
    {
        this.opSeq = opSeq;
        this.description = desc;
        this.department = department;
        this.job = job;
    }

    public void StartTask()
    {
		startTime = DateTime.Now;
    }

	public void StopTask()
    {
		stopTime = DateTime.Now;
    }
}
