using TodoApi.Domain.Model;

namespace TodoApi.Domain.App
{
    public interface ITodoUsecase
    {
        public Todo findTodo();
    }
}