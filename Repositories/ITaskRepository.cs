using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Repositories
{
    public interface ITaskRepository
    {
        TaskModel Get(int taskId);
        IQueryable<TaskModel> GetAllActive();
        void Add(TaskModel taskModel);
        void Update(int taskId, TaskModel task);
        void Delete(int taskId);
    }
}
