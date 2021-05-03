using System;
using System.Collections.Generic;

public class Order
{
	public int ID
    {
		get { return this.ID; }
    }
	private int id;

	public List<Job> Jobs
    {
		get { return this.jobs; }
    }
	private List<Job> jobs = new List<Job>();
	public Order(int orderID)
	{
		this.id = orderID;
	}

	public void AddJob(Job job)
    {
		if (!this.jobs.Contains(job))
        {
			this.jobs.Add(job);
        }
    }

	public void RemoveJob(Job job)
    {
		this.jobs.Remove(job);
    }
}
