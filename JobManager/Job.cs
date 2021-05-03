using System;
using System.Collections.Generic;

public class Job
{
	public string Description { get; set; }
	public Department Location { get; set; }
	public Task ActiveTask
    {
        get
        {
			if (this.tasks.Count == 0 || this.activeTaskIndex >= this.tasks.Count)
            {
				return new Task(0, "Empty Task");
            }
			return this.tasks[this.activeTaskIndex];
        }
    }
	public int ID
	{
		get { return this.id; }
	}
	private int id;
	public List<Task> Tasks
	{
		get { return this.tasks; }
	}
	private List<Task> tasks = new List<Task>();
	private int activeTaskIndex = 0;
	private Order order;
	private Department department;

	public Job(int jobID)
	{
		this.id = jobID;
	}
	public Job(int jobID, string description)
    {
		this.id = jobID;
		this.Description = description;
    }
	public Job(int jobID, string description, Order parentOrder)
    {
		this.id = jobID;
		this.Description = description;
		this.order = parentOrder;
	}
	public Job(int jobID, string description, Order parentOrder, Department department)
	{
		this.id = jobID;
		this.Description = description;
		this.order = parentOrder;
		this.department = department;
		department.AddJob(this);
	}

	public void FillTasks(List<Department> departments)
    {
		this.tasks.Add(new Task(10, "Form Frame", this, departments.Find(x => x.Name == "Welding")));
		this.tasks.Add(new Task(20, "Skin Frame", this, departments.Find(x => x.Name == "Fabrication")));
		this.tasks.Add(new Task(30, "Clean Frame", this, departments.Find(x => x.Name == "Painting")));
		this.tasks.Add(new Task(40, "Paint Frame", this, departments.Find(x => x.Name == "Painting")));
		this.tasks.Add(new Task(50, "Assemble Frame", this, departments.Find(x => x.Name == "Final")));
		this.tasks.Add(new Task(60, "Package Frame", this, departments.Find(x => x.Name == "Packaging")));
		this.department = this.ActiveTask.department;
		this.MoveDepartment(this.department);
	}

	public void NextDepartment()
    {
		this.activeTaskIndex++;
		if (this.activeTaskIndex >= this.tasks.Count)
			this.department.RemoveJob(this);
		else
			this.MoveDepartment(this.ActiveTask.department);
    }

	public void MoveDepartment(Department department)
    {
		this.department.RemoveJob(this);
		this.department = department;
		department.AddJob(this);
    }

	public void AddTask(Task task)
	{
		if (!this.tasks.Contains(task))
		{
			this.tasks.Add(task);
		}
	}

	public void RemoveTask(Task task)
	{
		this.tasks.Remove(task);
	}

	public override bool Equals(object obj) => this.Equals(obj as Job);
	public bool Equals(Job job)
    {
		return this.ID == job.ID;
    }
}
