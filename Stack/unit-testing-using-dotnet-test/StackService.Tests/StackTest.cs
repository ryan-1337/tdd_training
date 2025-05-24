using Xunit.Sdk;

namespace Stack.Tests;

public class StackTest
{
  private readonly StackService stack = new StackService();

  [Fact]
  public void StackEmpty_WhenStackCreate()
  {
    // given an empty stack
    
    // when stack created
    
    // then stack should be empty
    Assert.True(stack.IsEmpty());
  }
  
  [Fact]
  public void AfterOnePush_StackIsNotEmpty()
  {
    // given an empty stack
    
    // when adding something
    stack.Push(1);
    
    // then stack is not empty
    Assert.False(stack.IsEmpty());
  }

  [Fact]
  public void AfterPop_WhenEmptyStackThrowUnderflow()
  {
    // given an empty stack
    
    // when trying to remove something
    
    // then there should be an Error
    Assert.Throws<InvalidOperationException>(() => stack.Pop());
  }

  [Fact]
  public void AfterOnePushAndOnePop_StackWillBeEmpty()
  {
    // given an empty stack
    
    // when adding something and removing it 
    stack.Push(1);
    stack.Pop();
    
    // then stack should be empty
    Assert.True(stack.IsEmpty());
  }
  
  [Fact]
  public void AfterTwoPushAndOnePop_StackWillBeNotEmpty()
  {
    // given an empty stack
    
    // when adding two elements on stack and remove one
    stack.Push(1);
    stack.Push(1);
    stack.Pop();
    
    // then stack should not be empty
    Assert.False(stack.IsEmpty());
  }

  [Fact]
  public void AfterOnePushAndOnePop_ReturnThePopValue()
  {
    // given an empty stack
    
    // when adding one element to stack
    stack.Push(1);
    
    // then should return the element value
    Assert.Equal(1, stack.Pop());
  }
}
