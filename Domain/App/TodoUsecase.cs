using TodoApi.Domain.Model;

namespace TodoApi.Domain.App
{
    public class TodoUsecase : ITodoUsecase
    {
        public Todo findTodo()
        {
            return new Todo() { Id = 11, Name = "TodoUsecase created" };
        }
    }
}