namespace TaskManager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TaskManager
    {
        //int count = 0;
        ICollection<Task> tasks = new List<Task>();

        public int TasksCount
        {
            get
            {
                //refactoring
                //return this.count;
                return tasks.Count;
            }
        }

        public void AddTask(Task task)
        {
            if (task == null)
            {
                throw new ArgumentNullException("task");
            }

            this.tasks.Add(task);
            //count++;
        }
    }
}
