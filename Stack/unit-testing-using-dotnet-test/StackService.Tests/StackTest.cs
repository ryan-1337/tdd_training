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
    Action removal = () => stack.Pop();
    
    // then there should be an Error
    Assert.Throws<InvalidOperationException>(removal);
  }

  [Fact]
  public void AfterOnePushAndOnePop_StackWillBeEmpty()
  {
    // given a stack with only 1 element
    stack.Push(1);
    
    // when removing it
    stack.Pop();
    
    // then stack should be empty
    Assert.True(stack.IsEmpty());
  }
  
  [Fact]
  public void AfterTwoPushAndOnePop_StackWillBeNotEmpty()
  {
    // given a stack with 2 elements
    stack.Push(1);
    stack.Push(1);
    
    // when removing only one 
    stack.Pop();
    
    // then stack should not be empty
    Assert.False(stack.IsEmpty());
  }

  [Fact]
  public void AfterOnePushAndOnePop_ReturnThePopValue()
  {
    // given a stack with only one element
    stack.Push(1);
    
    // when adding one element to stack
    var popped = stack.Pop();
    
    // then should return the element value
    Assert.Equal(1, popped);
  }
}
