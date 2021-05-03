using System;
using System.Collections.Generic;

public class Department
{
	public string Name { get { return this.name; } }
	string name;
	public List<Job> jobs = new List<Job>();
	public Department(string name)
	{
		this.name = name;
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
