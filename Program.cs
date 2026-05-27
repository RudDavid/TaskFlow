using System;

namespace TaskFlow {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("=== Тестирование класса TaskItem ===\n");

      // Создаем тестовую задачу
      TaskItem task1 = new TaskItem(
          "Сдать лабораторную работу",
          "Нужно реализовать паттерн Observer в C#",
          DateTime.Now.AddDays(7)  // Дедлайн через неделю
      );

      // Выводим информацию
      Console.WriteLine("Создана задача:");
      task1.DisplayInfo();

      // Меняем статус
      Console.WriteLine("Меняем статус...");
      task1.ChangeStatus("В работе");
      task1.DisplayInfo();

      // Пробуем установить тот же статус
      Console.WriteLine("Пробуем установить тот же статус...");
      task1.ChangeStatus("В работе");

      Console.WriteLine("Нажми любую клавишу для выхода...");
      Console.ReadKey();
    }
  }
}