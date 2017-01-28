namespace TaskManager.NUnitTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    using NUnit.Framework;
    
    [TestFixture]
    public class TaskManagerTests
    {
        [Test]
        public void AddingNewNullTaskShouldThrowAnException()
        {
            // Arrange
            var taskManager = new TaskManager();
            
            // Assert
            Assert.Throws(typeof(ArgumentNullException), () => { taskManager.AddTask(null); });
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(13)]
        public void AddingNewTaskShouldProperlyUpdateTheCount(int count)
        {
            // Arrange
            var taskManager = new TaskManager();

            // Act
            for (int i = 0; i < count; i++)
            {
                taskManager.AddTask(new Task());
            }

            // Assert
            Assert.AreEqual(count, taskManager.TasksCount,
                string.Format("Tasks count is {0} whisch is incorect value.", taskManager.TasksCount));
        }
    }
}
