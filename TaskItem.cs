using System;

namespace TaskFlow {
  // Класс, представляющий задачу
  public class TaskItem {
    // Свойства доступны только для чтения извне
    public string Title { get; private set; }
    public string Description { get; private set; }
    public DateTime Deadline { get; private set; }
    public string Status { get; private set; }

    // Конструктор - задаем начальные значения
    public TaskItem(string title, string description, DateTime deadline) {
      Title = title;
      Description = description;
      Deadline = deadline;
      Status = "Новая";  // Любая новая задача получает этот статус
    }

    // Метод для смены статуса
    public void ChangeStatus(string newStatus) {
      // Проверяем, что статус действительно изменился
      if (Status != newStatus) {
        Status = newStatus;
        Console.WriteLine($"Статус задачи '{Title}' изменен на '{newStatus}'");
      }
    }

    // Удобный вывод информации о задаче
    public void DisplayInfo() {
      Console.WriteLine($"Задача: {Title}");
      Console.WriteLine($"Описание: {Description}");
      Console.WriteLine($"Дедлайн: {Deadline:dd.MM.yyyy HH:mm}");
      Console.WriteLine($"Статус: {Status}");
      Console.WriteLine(new string('-', 30));
    }
  }
}