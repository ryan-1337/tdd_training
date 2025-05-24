namespace Stack;
public class StackService
{
  private int size = 0;
  private int element = 0;

  public bool IsEmpty()
  {
    return size == 0;
  }
  
  public void Push(int element)
  {
    this.element = element;
    size++;
  }

  public int Pop()
  {
    if (IsEmpty())
    {
      throw new InvalidOperationException("Underflow");
    }
    size--;
    return element;
  }
}
