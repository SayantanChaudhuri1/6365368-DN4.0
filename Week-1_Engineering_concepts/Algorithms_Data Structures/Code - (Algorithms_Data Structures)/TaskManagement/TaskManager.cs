using System;

namespace TaskManagement
{
    public class TaskManager
    {
        private TaskNode? head;

        public void AddTask(Task task)
        {
            TaskNode newNode = new TaskNode(task);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                TaskNode current = head;
                while (current.Next != null)
                    current = current.Next;

                current.Next = newNode;
            }
            Console.WriteLine(" Task added.");
        }

        public Task? SearchTask(string taskId)
        {
            TaskNode? current = head;
            while (current != null)
            {
                if (current.Task.TaskId == taskId)
                    return current.Task;
                current = current.Next;
            }
            return null;
        }

        public void DisplayTasks()
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            TaskNode? current = head;
            while (current != null)
            {
                Console.WriteLine(current.Task);
                current = current.Next;
            }
        }

        public void DeleteTask(string taskId)
        {
            if (head == null)
            {
                Console.WriteLine(" No tasks to delete.");
                return;
            }

            if (head.Task.TaskId == taskId)
            {
                head = head.Next;
                Console.WriteLine(" Task deleted.");
                return;
            }

            TaskNode? current = head;
            while (current.Next != null)
            {
                if (current.Next.Task.TaskId == taskId)
                {
                    current.Next = current.Next.Next;
                    Console.WriteLine(" Task deleted.");
                    return;
                }
                current = current.Next;
            }

            Console.WriteLine(" Task not found.");
        }
    }
}
