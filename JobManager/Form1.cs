using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobManager
{
    public partial class JobManager : Form
    {
        private int orderNum = 10000;
        public List<Department> Departments { get; set; }
        public List<string> departmentNames = new List<string>();
        public List<string> jobNames = new List<string>();
        private Department activeDepartment;
        private Job activeJob;
        public JobManager()
        {
            this.Departments = new List<Department>();
            InitializeComponent();
            this.initialize_data();
            this.departmentList.DataSource = this.departmentNames;
            this.inDepartment.DataSource = this.jobNames;
        }

        private void AddDepartment(string name)
        {
            List<string> temp_desciptions = new List<string>();
            temp_desciptions.Add("McDonalds");
            temp_desciptions.Add("Valvoline");
            temp_desciptions.Add("LaQuinta");
            Department new_department = new Department(name);
            this.Departments.Add(new_department);
            this.departmentNames.Add(name);
            Order order = new Order(orderNum);
            for (int i = 0; i < 10; i++)
            {
                Job job = new Job(orderNum * 10 + i, temp_desciptions[i % 3], order, new_department);
                order.AddJob(job);
            }
            orderNum++;
        }

        private void departmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.activeDepartment = Departments[this.departmentList.SelectedIndex];
            this.jobNames.Clear();
            foreach (Job job in this.activeDepartment.jobs)
            {
                this.jobNames.Add(string.Format("{0, 5:D5} - {1}", job.ID, job.Description));
            }
            this.inDepartment.DataSource = null;
            this.inDepartment.DataSource = this.jobNames;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inDepartmentLabel_Click(object sender, EventArgs e)
        {

        }

        private void inDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.activeJob = this.activeDepartment.jobs[this.inDepartment.SelectedIndex];
                this.curTask.Text = this.activeJob.ActiveTask.FormattedString;
            }
            catch (Exception)
            {
                this.activeJob = null;
                this.curTask.Text = "No Jobs";
            }
        }

        private void initialize_data()
        {
            this.AddDepartment("Welding");
            this.AddDepartment("Painting");
            this.AddDepartment("Fabrication");
            this.AddDepartment("Final");
            this.AddDepartment("Packaging");

            foreach (Department department in this.Departments)
            {
                List<Job> tmp_jobs = new List<Job>(department.jobs);
                foreach (Job job in tmp_jobs)
                {
                    if (job.Tasks.Count == 0)
                    {
                        job.FillTasks(this.Departments);
                    }
                }
                if (department.Name != "Welding")
                    department.jobs.Clear();
            }

        }

        private void startTaskButton_Click(object sender, EventArgs e)
        {
            this.activeJob.ActiveTask.StartTask();
            this.startTaskButton.Enabled = false;
            this.stopTaskButton.Enabled = true;
            this.inDepartment.Enabled = false;
            this.departmentList.Enabled = false;
        }

        private void stopTaskButton_Click(object sender, EventArgs e)
        {
            this.activeJob.ActiveTask.StopTask();
            this.startTaskButton.Enabled = true;
            this.stopTaskButton.Enabled = false;
            this.inDepartment.Enabled = true;
            this.departmentList.Enabled = true;
        }

        private void moveDepartment_Click(object sender, EventArgs e)
        {
            this.activeJob.NextDepartment();
            this.jobNames.Clear();
            foreach (Job job in this.activeDepartment.jobs)
            {
                this.jobNames.Add(string.Format("{0, 5:D5} - {1}", job.ID, job.Description));
            }
            this.inDepartment.DataSource = null;
            this.inDepartment.DataSource = this.jobNames;
        }
    }
}
