using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskManagerContext _context;
        public TaskRepository(TaskManagerContext context)
        {
            _context = context;
        }

        public TaskModel Get(int taskId)
            => _context.Tasks.SingleOrDefault(x => x.TaskId == taskId);

        public IQueryable<TaskModel> GetAllActive()
            => _context.Tasks.Where(x => !x.Done);

        public void Add(TaskModel taskModel)
        {
            _context.Tasks.Add(taskModel);
            _context.SaveChanges();
        }

        public void Update(int taskId, TaskModel task)
        {
            var resultTask = _context.Tasks.SingleOrDefault(x => x.TaskId == taskId);
            if(resultTask != null)
            {
                resultTask.Name = task.Name;
                resultTask.Description = task.Description;
                resultTask.Done = task.Done;
                _context.SaveChanges();
            }
        }

        public void Delete(int taskId)
        {
            var resultTask = _context.Tasks.SingleOrDefault(x => x.TaskId == taskId);
            if(resultTask != null)
            {
                _context.Tasks.Remove(resultTask);
                _context.SaveChanges();
            }
        }  
    }
}
