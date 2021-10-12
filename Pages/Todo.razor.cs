using System.Collections.Generic;
using LatihanBlazor.Models;

namespace LatihanBlazor.Pages
{
    public partial class Todo
    {
        private List<Todoitem> todos = new();
        private string newTodo;
        private void addTodo() {
            if(!string.IsNullOrWhiteSpace(newTodo)){
                todos.Add(new Todoitem{ Title=newTodo });
                newTodo = string.Empty;
            }
        }
    }
}