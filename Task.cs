using System;

namespace TaskFlow {
  public class Task {
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    // jfkldksjfjsdkl
    public void Complete() {
      IsCompleted = true;
    }
  }
}
