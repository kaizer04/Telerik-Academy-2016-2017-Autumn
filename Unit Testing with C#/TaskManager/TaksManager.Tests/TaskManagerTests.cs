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
            // Arrange
            var taskManager = new TaskManager();

            // Act
            taskManager.AddTask(new Task()); 
            
            // Assert
            Assert.AreEqual(1, taskManager.TasksCount, 
                string.Format("Tasks count is {0} whisch is incorect value.", taskManager.TasksCount));
        }

        // not a test method
        public  void DoSomething()
        {

        }
    }
}
