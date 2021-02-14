using System;

namespace TodoApi.Domain.Model
{
    public class Todo
    {
        public Int64 Id { get; set; }
        public String Name { get; set; }

        public Todo() { }
    }

}