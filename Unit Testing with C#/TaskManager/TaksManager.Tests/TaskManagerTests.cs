namespace TaksManager.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TaskManager;

    [TestClass]
    public class TaskManagerTests
    {
        [TestMethod]
        public void AddingNewTaskShouldProperlyUpdateTheCount()
        {
            var taskManager = new TaskManager();

            taskManager.AddTask(new Task()); 

            Assert.AreEqual(1, taskManager.TasksCount, 
                string.Format("Tasks count is {0} whisch is incorect value.", taskManager.TasksCount));
        }

        // not a test method
        public  void DoSomething()
        {

        }
    }
}
